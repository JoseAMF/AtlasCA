import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {path: 'assuntos', loadChildren: () => import('./assuntos/assuntos.module').then(m => m.AssuntosModule)},
  {path: 'canaisreclamacao', loadChildren: () => import('./canais-reclamacao/canais-reclamacao.module')
  .then(m => m.CanaisReclamacaoModule)},
  {path: 'canaisvenda', loadChildren: () => import('./canais-venda/canais-venda.module').then(m => m.CanaisVendaModule)},
  {path: 'motivos', loadChildren: () => import('./motivos/motivos.module').then(m => m.MotivosModule)},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OuvidoriaRoutingModule { }
