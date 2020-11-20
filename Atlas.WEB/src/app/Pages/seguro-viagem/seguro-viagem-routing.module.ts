import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {path: 'bilhete', loadChildren: () => import('./bilhete/bilhete.module').then(b => b.BilheteModule)},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SeguroViagemRoutingModule { }
