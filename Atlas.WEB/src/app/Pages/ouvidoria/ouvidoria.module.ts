import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/shared/shared.module';
import { OuvidoriaRoutingModule } from './ouvidoria-routing.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    OuvidoriaRoutingModule,
    SharedModule
  ]
})
export class OuvidoriaModule { }
