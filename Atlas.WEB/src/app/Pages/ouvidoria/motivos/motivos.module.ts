import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MotivosRoutingModule } from './motivos-routing.module';
import { FormMotivosComponent } from './form-motivos/form-motivos.component';
import { ListMotivosComponent } from './list-motivos/list-motivos.component';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [FormMotivosComponent, ListMotivosComponent],
  imports: [
    CommonModule,
    MotivosRoutingModule,
    SharedModule,
  ]
})
export class MotivosModule { }
