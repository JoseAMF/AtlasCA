import { Component, OnInit, Injector } from '@angular/core';
import {
  AssuntoDTO,
  OuvidoriaService,
} from 'src/app/core/utils/apiClient.generated';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { switchMap } from 'rxjs/operators';
import { BaseResourceFormComponent } from 'src/app/shared/Components/base-resource-form/base-resource-form.component';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-form-assunto',
  templateUrl: './form-assunto.component.html',
  styleUrls: ['./form-assunto.component.css'],
})
export class FormAssuntoComponent extends BaseResourceFormComponent<AssuntoDTO> {
  protected jsonDataToResourceFn(Data: any): AssuntoDTO {
    return Object.assign(new AssuntoDTO(), Data);
  }

  protected buildResourceForm(): void {
    this.resourceForm = this.formBuilder.group({
      id: [null],
      idAssunto: [null, Validators.required],
      descricao: [null, [Validators.required, Validators.minLength(4)]]
    });
  }
  protected getServiceCall(): (Id: string | number) => Observable<AssuntoDTO> {
    return this.ouvidoriaService.getAssunto.bind(this.ouvidoriaService);
  }
  protected putServiceCall(): (resource: AssuntoDTO) => Observable<any> {
    return this.ouvidoriaService.putAssunto.bind(this.ouvidoriaService);
  }
  protected postServiceCall(): (resource: AssuntoDTO) => Observable<any> {
    return this.ouvidoriaService.postAssunto.bind(this.ouvidoriaService);
  }

  constructor(private ouvidoriaService: OuvidoriaService, injector: Injector) {
    super(injector, new AssuntoDTO());
  }

}
