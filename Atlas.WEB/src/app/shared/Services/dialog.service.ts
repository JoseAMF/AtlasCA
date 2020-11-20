import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmDialogModel, ConfirmationDialogComponent } from '../Dialogs/confirmation-dialog/confirmation-dialog.component';
import { TrocarSenhaDialogComponent } from '../Dialogs/trocar-senha-dialog/trocar-senha-dialog.component';

@Injectable({
  providedIn: 'root'
})
export class DialogService {

  constructor(private dialog: MatDialog) { }

  public openConfirmationDialog(Title: string, Body: string) {
    const dialogData = new ConfirmDialogModel(Title, Body);
    const dialogRef = this.dialog.open(ConfirmationDialogComponent, {
    data: dialogData});

    return dialogRef.afterClosed();
  }

  public openTrocarSenhaDialog() {
    this.dialog.open(TrocarSenhaDialogComponent);
  }
}
