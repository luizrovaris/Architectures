import { Component, OnInit } from "@angular/core";
import { Billing } from "../../model/billing";
import { Customer } from "../../model/Customer";
import { BillingService } from "../../services/billing/billing.service";

@Component({
  selector: 'dashboard-billing-cr',
  templateUrl: './dashboard.billing.component.html',
  styleUrls: ['./dashboard.billing.component.css']
})
export class DashboardBillingComponent implements OnInit {
  closedBillings: Billing[];
  openBillings: Billing[];

  constructor(private billingService: BillingService) {

  }
  ngOnInit(): void {
    this.getAllBillings();
  }

  public getAllBillings() {
    this.billingService.getAllBillings()
      .subscribe(
        success => {
          this.closedBillings = success.filter(b => b.paymentDate != null);
          this.openBillings = success.filter(b => b.paymentDate == null)
        },
        error => {
          console.log(error.error);
        }
      );
  }
}
