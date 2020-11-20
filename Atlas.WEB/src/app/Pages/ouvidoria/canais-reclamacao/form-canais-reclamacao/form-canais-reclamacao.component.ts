import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceFormComponent } from 'src/app/shared/Components/base-resource-form/base-resource-form.component';
import { CanalReclamacaoDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Validators } from '@angular/forms';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-form-canais-reclamacao',
  templateUrl: './form-canais-reclamacao.component.html',
  styleUrls: ['./form-canais-reclamacao.component.css']
})
export class FormCanaisReclamacaoComponent extends BaseResourceFormComponent<CanalReclamacaoDTO> {

  protected buildResourceForm(): void {
    this.resourceForm = this.formBuilder.group({
      id: [null],
      idCanalReclamacao: [null, Validators.required],
      descricao: [null, [Validators.required, Validators.minLength(4)]]
    });
  }

  protected getServiceCall(): (Id: string | number) => Observable<CanalReclamacaoDTO> {
    return this.ouvidoriaService.getCanalReclamacao.bind(this.ouvidoriaService);
  }
  protected putServiceCall(): (resource: CanalReclamacaoDTO) => Observable<any> {
    return this.ouvidoriaService.putCanalReclamacao.bind(this.ouvidoriaService);
  }
  protected postServiceCall(): (resource: CanalReclamacaoDTO) => Observable<any> {
    return this.ouvidoriaService.postCanalReclamacao.bind(this.ouvidoriaService);
  }
  protected jsonDataToResourceFn(Data: any): CanalReclamacaoDTO {
    return Object.assign(new CanalReclamacaoDTO(), Data);
  }

  constructor(injector: Injector, protected ouvidoriaService: OuvidoriaService) {
    super(injector, new CanalReclamacaoDTO());
  }

}
