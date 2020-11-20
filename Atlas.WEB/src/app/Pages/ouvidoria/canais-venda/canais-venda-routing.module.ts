import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListCanaisVendaComponent } from './list-canais-venda/list-canais-venda.component';
import { FormCanaisVendaComponent } from './form-canais-venda/form-canais-venda.component';


const routes: Routes = [
  {path: '', component: ListCanaisVendaComponent},
  {path: 'new', component: FormCanaisVendaComponent},
  {path: ':id', component: FormCanaisVendaComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CanaisVendaRoutingModule { }
