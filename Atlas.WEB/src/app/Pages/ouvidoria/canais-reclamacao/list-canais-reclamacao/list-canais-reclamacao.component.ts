import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceListComponent } from 'src/app/shared/Components/base-resource-list/base-resource-list.component';
import { CanalReclamacaoDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-canais-reclamacao',
  templateUrl: './list-canais-reclamacao.component.html',
  styleUrls: ['./list-canais-reclamacao.component.css']
})
export class ListCanaisReclamacaoComponent extends BaseResourceListComponent<CanalReclamacaoDTO>  {

  protected getServiceCall(): () => Observable<CanalReclamacaoDTO[]> {
    return this.ouvidoriaService.listCanalReclamacao.bind(this.ouvidoriaService);
  }
  protected fetchId(resource: CanalReclamacaoDTO): string | number {
    return resource.id;
  }
  protected deleteServiceCall(): (Id: string | number) => Observable<any> {
    return this.ouvidoriaService.deleteCanalReclamacao.bind(this.ouvidoriaService);
  }

  constructor(protected injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector);
   }

}
