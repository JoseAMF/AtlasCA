import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-loading-spinner',
  template: `
<div class="spinner-form" *ngIf="isLoading">
  <mat-spinner></mat-spinner>
</div>
  `,
  styleUrls: ['./loading-spinner.component.css']
})
export class LoadingSpinnerComponent implements OnInit {

  @Input() isLoading: boolean;
  constructor() { }

  ngOnInit(): void {
  }

}
