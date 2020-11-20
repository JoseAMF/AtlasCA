import { Component, OnInit } from '@angular/core';
import { ECommerceService, User, BilheteDTO } from 'src/app/core/utils/apiClient.generated';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { UserSession } from 'src/app/core/Models/session.model';

@Component({
  selector: 'app-form-bilhete',
  templateUrl: './form-bilhete.component.html',
  styleUrls: ['./form-bilhete.component.css']
})
export class FormBilheteComponent implements OnInit {


  error: string = null;
  isLoading = false;
  nrBilhete: string;
  bilhete: BilheteDTO;

  constructor(
    private eCommerceService: ECommerceService,
    private router: Router,
    private route: ActivatedRoute,
    private http: HttpClient)
    { }

  ngOnInit(): void {
    this.isLoading = true;
    this.nrBilhete = this.route.snapshot.paramMap.get('Bilhete');

    this.eCommerceService.getBilhete(this.nrBilhete)
    .subscribe(retorno => {
      this.bilhete = retorno;
      console.log(retorno);
      this.isLoading = false;
    },
    error => {
      this.error = error;
      this.isLoading = false;
    });
  }

  canCancel() {
    const userData: UserSession = JSON.parse(localStorage.getItem('userData'));
    if (!userData) {
      return false;
    }
    for (const role of userData.roles) {
      if (role.name.toUpperCase() === 'CANCELAMENTOBILHETE_ADMIN' ||
          role.name.toUpperCase() === 'CANCELAMENTOBILHETE_ESCRITA' ||
          role.name.toUpperCase() === 'CANCELAMENTOBILHETE_LEITURA') {
        return true;
      }
    }
    return false;
  }

  openPDF() {
    if (this.nrBilhete[0] === '5') {
     window.open(environment.O4D.PDFFT + this.nrBilhete + '.pdf');
    } else {
      window.open(environment.O4D.PDF + this.nrBilhete + '.pdf');
    }
  }

}
