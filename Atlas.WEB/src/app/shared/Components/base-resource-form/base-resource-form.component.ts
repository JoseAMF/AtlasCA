import { OnInit, AfterContentChecked, Injector } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { BaseResourceModel } from '../../models/base-resource.model';

import { switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { MatSnackBar } from '@angular/material/snack-bar';



export abstract class BaseResourceFormComponent<T extends BaseResourceModel> implements OnInit, AfterContentChecked{
  currentAction: string;
  resourceForm: FormGroup;
  pageTitle: string;
  serverErrorMessages: string[] = null;
  isLoading = false;

  protected route: ActivatedRoute;
  protected router: Router;
  protected formBuilder: FormBuilder;
  protected snackBar: MatSnackBar;

  constructor(
    protected injector: Injector,
    public resource: T
  ) {
    this.route = this.injector.get(ActivatedRoute);
    this.router = this.injector.get(Router);
    this.formBuilder = this.injector.get(FormBuilder);
    this.snackBar = this.injector.get(MatSnackBar);
  }


  ngOnInit() {
    this.setCurrentAction();
    this.buildResourceForm();
    this.loadResource();
  }

  ngAfterContentChecked(){
    this.setPageTitle();
  }

  submitForm(){
    this.isLoading = true;

    if (this.currentAction === 'new') {
      this.createResource();
    }
    else { // currentAction === 'edit'
      this.updateResource();
    }
  }


  // PRIVATE METHODS

  protected setCurrentAction() {
    console.log(this.route.snapshot.url);
    if (this.route.snapshot.url[0].path === 'new') {
      this.currentAction = 'new';
    }
    else {
      this.currentAction = 'edit';
    }
  }

  protected loadResource() {
    if (this.currentAction === 'edit') {
      this.isLoading = true;
      this.route.paramMap.pipe(
        switchMap(params => this.getServiceCall()(+params.get('id')))
      )
      .subscribe(
        (resource) => {
          this.resource = resource;
          this.resourceForm.patchValue(resource); // binds loaded resource data to resourceForm
          this.isLoading = false;
        },
        (error) => alert('Ocorreu um erro no servidor, tente mais tarde.')
      );
    }
  }


  protected setPageTitle() {
    if (this.currentAction === 'new') {
      this.pageTitle = this.creationPageTitle();
    }
    else{
      this.pageTitle = this.editionPageTitle();
    }
  }

  protected creationPageTitle(): string{
    return 'Novo';
  }

  protected editionPageTitle(): string{
    return this.route.snapshot.paramMap.get('id');
  }


  protected createResource(){
    const resource: T = this.jsonDataToResourceFn(this.resourceForm.value);

    this.postServiceCall()(resource)
      .subscribe(
        () => this.actionsForSuccess(resource),
        error => this.actionsForError(error)
      );
  }


  protected updateResource(){
    const resource: T = this.jsonDataToResourceFn(this.resourceForm.value);

    this.putServiceCall()(resource)
      .subscribe(
        () => this.actionsForSuccess(resource),
        error => this.actionsForError(error)
      );
  }


  protected actionsForSuccess(resource: T){
    this.openSnackBar('Criado com sucesso');

    this.navigateBack();
  }

  navigateBack(): void {
    if (this.currentAction === 'new') {
      this.router.navigate(['../'], {relativeTo: this.route});
    } else {
      this.router.navigate(['../'], {relativeTo: this.route});
    }
  }

  openSnackBar(msg: string, isError = false) {
    this.snackBar.open(msg, '', {
      duration: 5000,
      horizontalPosition: 'right',
      verticalPosition: 'top',
      panelClass: isError ? ['bg-danger', 'text-white'] : ['bg-success', 'text-white']
    });
  }

  protected actionsForError(response){
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
  protected abstract buildResourceForm(): void;
  protected abstract getServiceCall(): (Id: number | string) => Observable<T>;
  protected abstract putServiceCall(): (resource: T) => Observable<any>;
  protected abstract postServiceCall(): (resource: T) => Observable<any>;
  protected abstract jsonDataToResourceFn(Data: any): T;
}
