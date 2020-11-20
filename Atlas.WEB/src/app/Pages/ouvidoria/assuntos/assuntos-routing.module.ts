import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FormAssuntoComponent } from './form-assunto/form-assunto.component';
import { ListAssuntoComponent } from './list-assunto/list-assunto.component';


const routes: Routes = [
  {path: '', component: ListAssuntoComponent},
  {path: 'new', component: FormAssuntoComponent},
  {path: ':id', component: FormAssuntoComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AssuntosRoutingModule { }
