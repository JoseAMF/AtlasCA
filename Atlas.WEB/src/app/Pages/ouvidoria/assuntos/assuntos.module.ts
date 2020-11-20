import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormAssuntoComponent } from './form-assunto/form-assunto.component';
import { ListAssuntoComponent } from './list-assunto/list-assunto.component';
import { OuvidoriaModule } from '../ouvidoria.module';
import { AssuntosRoutingModule } from './assuntos-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [FormAssuntoComponent, ListAssuntoComponent],
  imports: [
    AssuntosRoutingModule,
    SharedModule,
    OuvidoriaModule
  ]
})
export class AssuntosModule { }
