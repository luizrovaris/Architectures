import { Component } from '@angular/core';
import { Billing } from '../model/billing';

@Component({
  selector: 'billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent {
  public billing: Billing;
}
