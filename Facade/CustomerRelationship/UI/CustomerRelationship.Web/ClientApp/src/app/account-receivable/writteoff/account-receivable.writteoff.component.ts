import { Component, OnInit } from "@angular/core";
import { Billing } from "../../model/billing";

@Component({
  selector: "account-receivable-writteoff",
  templateUrl: "./account-receivable.writteoff.component.html",
  styleUrls: ["./account-receivable.writteoff.component.css"]
})
export class AccountReceivableWritteoffComponent implements OnInit {
  public billing: Billing;
  
  constructor() {
  }
  ngOnInit(): void {
    var billingOnSession = sessionStorage.getItem("billingSession");
    if (billingOnSession) {
      this.billing = JSON.parse(billingOnSession);
      sessionStorage.setItem("billingSession", null);
    }
  }
}
