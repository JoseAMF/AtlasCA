import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListCanaisReclamacaoComponent } from './list-canais-reclamacao/list-canais-reclamacao.component';
import { FormCanaisReclamacaoComponent } from './form-canais-reclamacao/form-canais-reclamacao.component';


const routes: Routes = [
  {path: '', component: ListCanaisReclamacaoComponent},
  {path: 'new', component: FormCanaisReclamacaoComponent},
  {path: ':id', component: FormCanaisReclamacaoComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CanaisReclamacaoRoutingModule { }
