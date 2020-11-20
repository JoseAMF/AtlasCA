import { Component, Input } from '@angular/core';
import { AuthenticationService } from 'src/app/core/Services/authentication.service';
import { DialogService } from '../../Services/dialog.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent{

  @Input() title: string;
  usuario: string;

  constructor(private authService: AuthenticationService, private dialogService: DialogService) {
    this.authService.user.subscribe(usuario => {
      this.usuario = usuario.username;
    });
   }

   trocarSenha() {
     this.dialogService.openTrocarSenhaDialog();
   }

   logout() {
     this.authService.logout();
   }
}
