import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-confirmation-dialog',
  template: `
<div class="card">
      <div class="card-header">
  {{title}}
       </div>

  <div class="card-body">
    <p [innerHTML]="message"></p>

    <div>
      <button mat-raised-button class="btn btn-danger" (click)="onConfirm()">Sim</button>
      <button mat-button (click)="onDismiss()">Não</button>
    </div>

  </div>
</div>

  `,
  styleUrls: ['./confirmation-dialog.component.css']
})
export class ConfirmationDialogComponent  {
  title: string;
  message: string;

  constructor(public dialogRef: MatDialogRef<ConfirmationDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: ConfirmDialogModel) {
                this.title = data.title;
                this.message = data.message;
               }

  onConfirm(): void {
    // Close the dialog, return true
    this.dialogRef.close(true);
  }

  onDismiss(): void {
    // Close the dialog, return false
    this.dialogRef.close(false);
  }

}

export class ConfirmDialogModel {

  constructor(public title: string, public message: string) {
  }
}
