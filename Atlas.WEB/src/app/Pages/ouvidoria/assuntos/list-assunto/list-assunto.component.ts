import { Component, OnInit, Injector } from '@angular/core';
import { BaseResourceListComponent } from 'src/app/shared/Components/base-resource-list/base-resource-list.component';
import { AssuntoDTO, OuvidoriaService } from 'src/app/core/utils/apiClient.generated';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-assunto',
  templateUrl: './list-assunto.component.html',
  styleUrls: ['./list-assunto.component.css']
})
export class ListAssuntoComponent extends BaseResourceListComponent<AssuntoDTO> {

  protected getServiceCall(): () => Observable<AssuntoDTO[]> {
    return this.ouvidoriaService.listAssunto.bind(this.ouvidoriaService);
  }
  protected fetchId(resource: AssuntoDTO): string | number {
    return resource.id;
  }
  protected deleteServiceCall(): (Id: string | number) => Observable<any> {
    return this.ouvidoriaService.deleteAssunto.bind(this.ouvidoriaService);
  }

  protected orderResourceList(resources: AssuntoDTO[]): AssuntoDTO[] {
    return resources.sort((a, b) => b.idAssunto - a.idAssunto);
  }

  constructor(protected injector: Injector, private ouvidoriaService: OuvidoriaService) {
    super(injector);
   }

}
