import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Billing } from '../model/billing';
import { Customer } from '../model/Customer';
import { BillingService } from '../services/billing/billing.service';

@Component({
  selector: 'billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {
  public billing: Billing;
  public activateSpinner: boolean;
  public message: string;

  constructor(private billingService: BillingService, private router: Router) {
  }
  ngOnInit(): void {
    this.billing = new Billing();
  }

  public save() {
    this.activateSpinner = true;

    this.billingService.saveBilling(this.billing)
      .subscribe(
        () => {
          this.activateSpinner = false;
          this.router.navigate(['/customer-search']);
        },
        error => {
          this.message = error.error;
          this.activateSpinner = false;
        }
      );
  }
}
