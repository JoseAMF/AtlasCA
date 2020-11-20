import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AuthenticationService } from '../../Services/authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  isLoading = false;
  error: string = null;
  constructor(private authService: AuthenticationService, private router: Router) { }

  onLogin(form: NgForm) {
    if (!form.valid) {
      return;
    }
    const username = form.value.user;
    const password = form.value.pass;


    this.isLoading = true;

    this.authService.login(username, password).subscribe(resData => {
      this.isLoading = false;
      this.router.navigate(['']);
    },
    errorMessage => {
      this.error = errorMessage;
      this.isLoading = false;
    });

    form.reset();
  }

  onRegister(form: NgForm) {
    if (form.value.pass !== form.value.pass2) {
      this.error = 'A confirmação de senha não corresponde a senha.';
      return;
    }
    if ( form.value.pass.length < 6) {
      this.error = 'A senha deve ter no mínimo seis caractéres.';
      return;
    }

    this.authService.register( form.value.user, form.value.pass, form.value.email)
    .subscribe(response => {
      this.error = 'Usuário criado com sucesso, contate o administrador do sistema para configuração do perfil.';
    },
    error => {
      this.error = error;
    });
  }

}
