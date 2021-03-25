import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Billing } from '../model/billing';
import { BillingService } from '../services/billing/billing.service';

@Component({
  selector: 'account-receivable',
  templateUrl: './account-receivable.component.html',
  styleUrls: ['./account-receivable.component.css']
})
export class AccountReceivableComponent {
  public billings: Billing[];

  constructor(private billingService: BillingService, private router: Router) {
    this.getAllBillings();
  }

  public setBillingWritteOff(billing: Billing) {
    sessionStorage.setItem("billingSession", JSON.stringify(billing));
    this.router.navigate(['account-receivable-writteoff']);
  }

  public getAllBillings() {
    this.billingService.getAllBillings()
      .subscribe(
        success => {
          this.billings = success;
        },
        error => {
          console.log(error.error);
        }
    );
  }
}
