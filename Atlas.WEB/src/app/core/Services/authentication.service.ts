import { Injectable } from '@angular/core';
import { BehaviorSubject, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { UserSession, Role } from '../Models/session.model';
import { AuthService, LoginCommand, RegisterUserCommand, UpdatePasswordCommand } from '../utils/apiClient.generated';
import { catchError, tap } from 'rxjs/operators';
import { HttpErrorResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  user = new BehaviorSubject<UserSession>(null);
  private tokenExpirationTimer: any;

  constructor(private router: Router, private authService: AuthService) { }

  login(username: string, password: string) {
    const loginCommand: LoginCommand = new LoginCommand();
    loginCommand.username = username;
    loginCommand.password = password;

    return this.authService.login(loginCommand).pipe(catchError(this.handleError),
    tap(token => {
      console.log(token);
      this.handleAuthentication(username, token);
    }));
  }

  logout() {
    this.user.next(null);
    this.router.navigate(['/login']);
    localStorage.removeItem('userData');
    if (this.tokenExpirationTimer) {
      clearTimeout(this.tokenExpirationTimer);
    }
    this.tokenExpirationTimer = null;
  }

  updatePassword(password: string, newPassword: string) {
    const req: UpdatePasswordCommand = new UpdatePasswordCommand();
    const userData: {
      username: string,
      roles: Role[],
      Token: string,
      TokenExpirationDate: string
    } = JSON.parse(localStorage.getItem('userData'));
    if (!userData) {
      return;
    }
    req.username = userData.username;
    req.password = password;
    req.newPassword = newPassword;
    return this.authService.updatePassword(req);
  }

  autoLogin() {
    const userData: {
      username: string,
      roles: Role[],
      Token: string,
      TokenExpirationDate: string
    } = JSON.parse(localStorage.getItem('userData'));
    if (!userData) {
      return;
    }

    const loadedUser = new UserSession(userData.username,
      userData.roles,
      userData.Token,
      new Date(userData.TokenExpirationDate));
    if (loadedUser.token) {
      this.user.next(loadedUser);
      const expirationDuration =
        new Date(userData.TokenExpirationDate).getTime() - new Date().getTime();
      this.autoLogout(expirationDuration);
    }
  }

  autoLogout(expirationDuration: number) {
    this.tokenExpirationTimer = setTimeout(() => {
      this.logout();
    }, expirationDuration);
  }

  register(username: string, password: string, email: string) {
    return this.authService.register({username, password, email} as RegisterUserCommand);
  }

  private handleAuthentication(username: string, token: string) {
    const expirationDate = new Date(new Date().getTime() + 120 * 60 * 1000);
    const user = new UserSession(username, [], token, expirationDate);
    this.user.next(user);

    localStorage.setItem('userData', JSON.stringify(user));
    if (this.user.value !== undefined && this.user.value !== null) {
      this.authService.getUserRoles(this.user.value.username).subscribe(roles => {
        this.user.next(user);
        localStorage.setItem('userData', JSON.stringify(user));
      });
    }
  }

  private handleError(errorRes: HttpErrorResponse) {
    let errorMessage = 'Erro Desconhecido';
    switch (errorRes.status) {
      case 401:
        errorMessage = 'Login ou Senha Inválidos';
        break;
      case 504:
        errorMessage = 'Não foi possível encontrar o Servidor';
        break;
      case 550:
        errorMessage = 'Permissão Negada';
        break;
    }
    return throwError(errorMessage);
  }
}
