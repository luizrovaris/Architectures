import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Customer } from "../../model/Customer";

@Component({
  selector: "customer-register",
  templateUrl: "./customer.register.component.html",
  styleUrls: ["./customer.register.component.css"]
})
export class CustomerRegisterComponent {
  public customer: Customer;

  constructor(private router: Router) {

  }

  public addCustomer() {
    this.router.navigate['/customer-register'];
  }
}
