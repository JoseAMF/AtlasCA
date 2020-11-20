import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceListComponent } from 'src/app/shared/Components/base-resource-list/base-resource-list.component';
import { MotivoDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-motivos',
  templateUrl: './list-motivos.component.html',
  styleUrls: ['./list-motivos.component.css']
})
export class ListMotivosComponent extends BaseResourceListComponent<MotivoDTO> {

  protected getServiceCall(): () => Observable<MotivoDTO[]> {
    return this.ouvidoriaService.listMotivo.bind(this.ouvidoriaService);
  }
  protected deleteServiceCall(): (Id: string | number) => Observable<any> {
    return this.ouvidoriaService.deleteMotivo.bind(this.ouvidoriaService);
  }
  protected fetchId(resource: MotivoDTO): string | number {
    return resource.id;
  }

  constructor(injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector);
   }

}
