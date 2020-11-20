import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CanaisVendaRoutingModule } from './canais-venda-routing.module';
import { FormCanaisVendaComponent } from './form-canais-venda/form-canais-venda.component';
import { ListCanaisVendaComponent } from './list-canais-venda/list-canais-venda.component';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [FormCanaisVendaComponent, ListCanaisVendaComponent],
  imports: [
    CommonModule,
    CanaisVendaRoutingModule,
    SharedModule
  ]
})
export class CanaisVendaModule { }
