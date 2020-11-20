import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-form-field-alerts',
  template: `
  <div>
    <div class="alert alert-primary" *ngIf="success">
      <p style="text-align: center;">{{ success }}</p>
    </div>
    <div class="alert alert-danger" *ngIf="errorList">
      <p *ngFor="let error of errorList" style="text-align: center;">{{ error }}</p>
    </div>
  </div>
  `,
  styleUrls: ['./form-field-alerts.component.css']
})
export class FormFieldAlertsComponent implements OnInit {

  @Input() errorList: string[];
  @Input() success: string;
  constructor() { }

  ngOnInit(): void {
  }

}
