import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CanaisReclamacaoRoutingModule } from './canais-reclamacao-routing.module';
import { ListCanaisReclamacaoComponent } from './list-canais-reclamacao/list-canais-reclamacao.component';
import { FormCanaisReclamacaoComponent } from './form-canais-reclamacao/form-canais-reclamacao.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { OuvidoriaModule } from '../ouvidoria.module';


@NgModule({
  declarations: [ListCanaisReclamacaoComponent, FormCanaisReclamacaoComponent],
  imports: [
    CommonModule,
    CanaisReclamacaoRoutingModule,
    SharedModule,
    OuvidoriaModule
  ]
})
export class CanaisReclamacaoModule { }
