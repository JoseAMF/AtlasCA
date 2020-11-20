import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './core/Services/authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Atlas';
  constructor(private authService: AuthenticationService,  public router: Router) {}

  ngOnInit() {
  this.authService.autoLogin();
  }
}
