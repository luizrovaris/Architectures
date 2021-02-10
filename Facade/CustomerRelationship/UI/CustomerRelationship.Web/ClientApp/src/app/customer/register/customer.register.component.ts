import { Component } from "@angular/core";
import { Customer } from "../../model/Customer";

@Component({
  selector: "customer-register",
  templateUrl: "./customer.register.component.html",
  styleUrls: ["./customer.register.component.css"]
})
export class CustomerRegisterComponent {
  public customer: Customer;
}
