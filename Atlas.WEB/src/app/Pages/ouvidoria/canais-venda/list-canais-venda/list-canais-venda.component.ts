import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceListComponent } from 'src/app/shared/Components/base-resource-list/base-resource-list.component';
import { CanalVendaDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-canais-venda',
  templateUrl: './list-canais-venda.component.html',
  styleUrls: ['./list-canais-venda.component.css']
})
export class ListCanaisVendaComponent extends BaseResourceListComponent<CanalVendaDTO> {
  protected getServiceCall(): () => Observable<CanalVendaDTO[]> {
    return this.ouvidoriaService.listCanalVenda.bind(this.ouvidoriaService);
  }
      protected deleteServiceCall(): (Id: string | number) => Observable<any> {
        return this.ouvidoriaService.deleteCanalVenda.bind(this.ouvidoriaService);
      }
  protected fetchId(resource: CanalVendaDTO): string | number {
    return resource.id;
  }

  constructor(injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector);
   }
}
