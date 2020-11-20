import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BilheteRoutingModule } from './bilhete-routing.module';
import { SearchBilheteComponent } from './search-bilhete/search-bilhete.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormBilheteComponent } from './form-bilhete/form-bilhete.component';


@NgModule({
  declarations: [SearchBilheteComponent, FormBilheteComponent],
  imports: [
    CommonModule,
    BilheteRoutingModule,
    SharedModule
  ]
})
export class BilheteModule { }
