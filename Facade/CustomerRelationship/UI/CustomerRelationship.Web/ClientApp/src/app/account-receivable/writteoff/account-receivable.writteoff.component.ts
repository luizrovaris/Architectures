import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Billing } from "../../model/billing";
import { BillingService } from "../../services/billing/billing.service";

@Component({
  selector: "account-receivable-writteoff",
  templateUrl: "./account-receivable.writteoff.component.html",
  styleUrls: ["./account-receivable.writteoff.component.css"]
})
export class AccountReceivableWritteoffComponent implements OnInit {
  public billing: Billing;
  public activateSpinner: boolean;
  public message: string;

  constructor(private billingService: BillingService, private router: Router) {
  }
  ngOnInit(): void {
    var billingOnSession = sessionStorage.getItem("billingSession");
    if (billingOnSession) {
      this.billing = JSON.parse(billingOnSession);
      if (this.billing != null) {
        this.billing.receiptValue = this.billing.value;
        this.billing.increasedValue = 0;
        this.billing.discountValue = 0;
        this.billing.totalValue = this.billing.value;
      }
      sessionStorage.setItem("billingSession", null);
    }
  }

  public save() {
    this.activateSpinner = true;

    this.billingService.saveBilling(this.billing)
      .subscribe(
        () => {
          this.activateSpinner = false;
          this.router.navigate(['/account-receivable']);
        },
        error => {
          this.message = error.error;
          this.activateSpinner = false;
        }
      );
  }

  public onValueReceipted() {
    if (this.billing.receiptValue > this.billing.value) {
      this.billing.increasedValue = this.billing.receiptValue - this.billing.value;
      this.billing.receiptValue = this.billing.value;
      this.billing.discountValue = 0;
    } else if (this.billing.receiptValue < this.billing.value) {
      this.billing.discountValue = this.billing.value - this.billing.receiptValue;
      this.billing.receiptValue = this.billing.value;
      this.billing.increasedValue = 0;
    } else {
      this.billing.increasedValue = 0;
      this.billing.discountValue = 0;
    }
  }

  public onValueAdittionalChanged() {
    this.billing.totalValue = this.billing.receiptValue + this.billing.increasedValue - this.billing.discountValue;
  }
}
