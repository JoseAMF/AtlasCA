import { OnInit, Injector } from '@angular/core';
import { BaseResourceModel } from '../../Models/base-resource.model';
import { Observable } from 'rxjs';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DialogService } from '../../Services/dialog.service';


export abstract class BaseResourceListComponent<T> implements OnInit {

  resources: T[] = [];
  serverErrorMessages: string[] = null;
  isLoading = false;

  protected snackBar: MatSnackBar;
  protected dialogService: DialogService;

  constructor(protected injector: Injector) {
    this.snackBar = injector.get(MatSnackBar);
    this.dialogService = injector.get(DialogService);
   }

  ngOnInit() {
    this.isLoading = true;
    this.getServiceCall()().subscribe(
      resources => {
        this.resources = this.orderResourceList(resources);
        this.isLoading = false;
    },
      response => {
        this.openSnackBar('Erro ao carregar a lista', true);
        this.isLoading = false;
        const errorList: string[] = [];
        try {
          for (const field of response.errors) {
            for (const error of field) {
              errorList.push(error);
            }
          }
        } catch {
          console.error(response);
          this.serverErrorMessages = ['Falha na comunicação com o servidor. Por favor, tente mais tarde.'];
        }
        this.serverErrorMessages = errorList;
    }
    );
  }

  deleteResource(resource: T) {
    this.dialogService.openConfirmationDialog('Deletar recurso', 'Você realmente deseja deletar ?').subscribe(
      retorno => {
        if (retorno){
          this.isLoading = true;
          this.deleteServiceCall()(this.fetchId(resource)).subscribe(
            () => {
              this.resources = this.resources.filter(element => element !== resource);
              this.isLoading = false;
            },
            response => {
              this.isLoading = false;
              const errorList: string[] = [];
              try {
                for (const field of response.errors) {
                  for (const error of field) {
                    errorList.push(error);
                  }
                }
              } catch {
                console.error(response);
                this.serverErrorMessages = ['Falha na comunicação com o servidor. Por favor, tente mais tarde.'];
              }
              this.serverErrorMessages = errorList;
            }
          );
        }
      }
    );
  }

  protected orderResourceList(resources: T[]): T[] {
    return resources;
  }

  openSnackBar(msg: string, isError = false) {
    this.snackBar.open(msg, '', {
      duration: 5000,
      horizontalPosition: 'right',
      verticalPosition: 'top',
      panelClass: isError ? ['bg-danger', 'text-white'] : ['bg-success', 'text-white']
    });
  }

  protected abstract getServiceCall(): () => Observable<T[]>;
  protected abstract fetchId(resource: T): string | number;
  protected abstract deleteServiceCall(): (Id: string | number) => Observable<any>;

}
