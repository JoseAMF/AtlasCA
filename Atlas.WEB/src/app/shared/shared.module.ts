import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './Components/header/header.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import { FormFieldAlertsComponent } from './Components/form-field-alerts/form-field-alerts.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { LoadingSpinnerComponent } from './Components/loading-spinner/loading-spinner.component';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { ConfirmationDialogComponent } from './Dialogs/confirmation-dialog/confirmation-dialog.component';
import { MatDialogModule } from '@angular/material/dialog';
import { BreadCrumbComponent } from './Components/bread-crumb/bread-crumb.component';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import { TrocarSenhaDialogComponent } from './Dialogs/trocar-senha-dialog/trocar-senha-dialog.component';


@NgModule({
  declarations: [
    HeaderComponent,
    FormFieldAlertsComponent,
    LoadingSpinnerComponent,
    ConfirmationDialogComponent,
    BreadCrumbComponent,
    TrocarSenhaDialogComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    FormsModule,
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatSnackBarModule,
    MatProgressSpinnerModule,
    MatDialogModule,
    MatIconModule,
    MatMenuModule,
  ],
  exports: [
    CommonModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
    MatButtonModule,

    // Components0
    HeaderComponent,
    FormFieldAlertsComponent,
    LoadingSpinnerComponent,
    BreadCrumbComponent
  ],
  entryComponents: [
    ConfirmationDialogComponent,
    TrocarSenhaDialogComponent
  ]
})
export class SharedModule { }
