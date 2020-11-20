import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListMotivosComponent } from './list-motivos/list-motivos.component';
import { FormMotivosComponent } from './form-motivos/form-motivos.component';


const routes: Routes = [
  {path: '', component: ListMotivosComponent},
  {path: 'new', component: FormMotivosComponent},
  {path: ':id', component: FormMotivosComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MotivosRoutingModule { }
