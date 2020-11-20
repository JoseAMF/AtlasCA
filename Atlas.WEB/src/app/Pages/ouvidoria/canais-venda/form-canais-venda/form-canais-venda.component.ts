import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceFormComponent } from 'src/app/shared/Components/base-resource-form/base-resource-form.component';
import { CanalVendaDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-form-canais-venda',
  templateUrl: './form-canais-venda.component.html',
  styleUrls: ['./form-canais-venda.component.css']
})
export class FormCanaisVendaComponent extends BaseResourceFormComponent<CanalVendaDTO> {
  protected buildResourceForm(): void {
    this.resourceForm = this.formBuilder.group({
      id: [null],
      idCanalVenda: [null, Validators.required],
      descricao: [null, [Validators.required, Validators.minLength(4)]]
    });
  }
  protected getServiceCall(): (Id: string | number) => Observable<CanalVendaDTO> {
    return this.ouvidoriaService.getCanalVenda.bind(this.ouvidoriaService);
  }
  protected putServiceCall(): (resource: CanalVendaDTO) => Observable<any> {
    return this.ouvidoriaService.putCanalVenda.bind(this.ouvidoriaService);
  }
  protected postServiceCall(): (resource: CanalVendaDTO) => Observable<any> {
    return this.ouvidoriaService.postCanalVenda.bind(this.ouvidoriaService);
  }
  protected jsonDataToResourceFn(Data: any): CanalVendaDTO {
    return Object.assign(new CanalVendaDTO(), Data);
  }

  constructor(protected injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector, new CanalVendaDTO());
   }


}
