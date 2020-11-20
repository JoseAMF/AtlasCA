import { Component, OnInit, Input } from '@angular/core';

interface BreadCrumbItem {
  text: string;
  link?: string;
}


@Component({
  selector: 'app-bread-crumb',
  template: `
  <nav class="mb-5">
  <ol class="breadcrumb">
    <li class="breadcrumb-item">
      <a routerLink="/">Home</a>
    </li>

    <li *ngFor="let item of items" class="breadcrumb-item link" [class.active]="!item.link">
      <span *ngIf="!item.link">
        {{item.text}}
      </span>

      <a *ngIf="!!item.link" [routerLink]="item.link" >
        {{item.text}}
      </a>
    </li>
  </ol>
</nav>
  `,
  styleUrls: ['./bread-crumb.component.css']
})
export class BreadCrumbComponent implements OnInit {

  @Input() items: Array<BreadCrumbItem> = [];
  constructor() { }

  ngOnInit(): void {
  }


}
