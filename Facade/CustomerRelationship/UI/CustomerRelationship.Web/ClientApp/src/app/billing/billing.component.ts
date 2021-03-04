import { Component, OnInit } from '@angular/core';
import { Billing } from '../model/billing';

@Component({
  selector: 'billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {
  public billing: Billing;
  public activateSpinner: boolean;

  constructor() {
  }
  ngOnInit(): void {
    this.billing = new Billing();
  }

  public save() {
    this.activateSpinner = true;
  }
}
