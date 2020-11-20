import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceFormComponent } from 'src/app/shared/Components/base-resource-form/base-resource-form.component';
import { MotivoDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-form-motivos',
  templateUrl: './form-motivos.component.html',
  styleUrls: ['./form-motivos.component.css']
})
export class FormMotivosComponent extends BaseResourceFormComponent<MotivoDTO> {

  protected buildResourceForm(): void {
    this.resourceForm = this.formBuilder.group({
      id: [null],
      idMotivo: [null, Validators.required],
      descricao: [null, [Validators.required, Validators.minLength(4)]]
    });
}
  protected getServiceCall(): (Id: string | number) => Observable<MotivoDTO> {
    return this.ouvidoriaService.getMotivo.bind(this.ouvidoriaService);
  }
  protected putServiceCall(): (resource: MotivoDTO) => Observable<any> {
    return this.ouvidoriaService.putMotivo.bind(this.ouvidoriaService);
  }
  protected postServiceCall(): (resource: MotivoDTO) => Observable<any> {
    return this.ouvidoriaService.postMotivo.bind(this.ouvidoriaService);
  }
  protected jsonDataToResourceFn(Data: any): MotivoDTO {
    return Object.assign(new MotivoDTO(), Data);
  }

  constructor(injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector, new MotivoDTO());
   }


}
