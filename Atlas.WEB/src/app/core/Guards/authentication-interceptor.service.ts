import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler } from '@angular/common/http';
import { take, exhaustMap } from 'rxjs/operators';
import { AuthenticationService } from '../Services/authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationInterceptorService  implements HttpInterceptor {

  constructor(private authService: AuthenticationService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler) {
    return this.authService.user.pipe(
      take(1),
      exhaustMap(user => {
        if (!user) {
          return next.handle(req);
        }
        if (req.url.includes('azure')) {
          return next.handle(req);
        }
        const modifiedReq = req.clone({
          headers: req.headers.append('Authorization', 'Bearer ' + user.token)
        });
        return next.handle(modifiedReq);
      })
    );
  }
}
