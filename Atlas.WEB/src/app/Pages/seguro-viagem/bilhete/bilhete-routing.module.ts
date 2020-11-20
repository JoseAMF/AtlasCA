import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SearchBilheteComponent } from './search-bilhete/search-bilhete.component';
import { FormBilheteComponent } from './form-bilhete/form-bilhete.component';


const routes: Routes = [
  {path: ':Bilhete', component: FormBilheteComponent},
  {path: '', component: SearchBilheteComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BilheteRoutingModule { }
