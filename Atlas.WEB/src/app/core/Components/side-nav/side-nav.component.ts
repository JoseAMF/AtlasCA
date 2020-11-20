import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../Services/authentication.service';

@Component({
  selector: 'app-side-nav',
  templateUrl: './side-nav.component.html',
  styleUrls: ['./side-nav.component.css']
})
export class SideNavComponent implements OnInit {
  roles: string[];
  isLoading: boolean;
  constructor(private authService: AuthenticationService) { }

  ngOnInit(): void {
  }

  hasRole(role: string) {
    return true;
    for ( const x of this.roles) {
      if (x.includes(role)) { return true; }
    }
    return false;
  }

  onLogout() {
    this.authService.logout();
  }

  // onChangePassword() {
  //   const dialogRef = this.dialog.open(TrocarSenhaDialogComponent);
  // }
}
