import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/core/Services/authentication.service';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-trocar-senha-dialog',
  template: `
<div class="card">
  <div class="card-body" >
    Deseja Trocar a senha da conta ?
  </div >

  <div class="card-body">
    <div class="container">
      <div class="alert alert-danger mb-0" *ngIf="error">
        <p style="text-align: center;">{{ error }}</p>
      </div>
      <mat-form-field>
        <input matInput type="password" placeholder="Senha Atual" [(ngModel)]="Senha">
      </mat-form-field>
      <mat-form-field>
        <input matInput type="password" placeholder="Senha nova" [(ngModel)]="NovaSenha">
      </mat-form-field>
      <mat-form-field>
        <input matInput type="password" placeholder="Repita a senha nova" [(ngModel)]="RepetirSenha">
      </mat-form-field>
    </div>
  </div>

  <div class="card-footer">
    <button class="btn btn-primary mr-5" matDialogClose>Cancelar</button>
    <button mat-raised-button class="btn btn-danger" (click)="onConfirm()">Confirmar</button>
  </div>
</div>
  `,
  styleUrls: ['./trocar-senha-dialog.component.css']
})
export class TrocarSenhaDialogComponent implements OnInit {


  Senha: string;
  NovaSenha: string;
  RepetirSenha: string;

  error = null;

  constructor(public dialogRef: MatDialogRef<TrocarSenhaDialogComponent>, private authService: AuthenticationService) { }

  ngOnInit(): void {
  }

  onConfirm(): void {
    if (this.RepetirSenha !== this.NovaSenha) {return; }
    // Close the dialog, return true
    this.authService.updatePassword(this.Senha, this.NovaSenha)
    .subscribe(result => {
      this.dialogRef.close(true);
    },
    error => {
      this.error = error;
    });
  }

}
