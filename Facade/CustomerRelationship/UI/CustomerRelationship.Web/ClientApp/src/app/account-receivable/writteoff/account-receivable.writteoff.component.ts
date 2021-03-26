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
}
