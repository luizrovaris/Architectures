import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Customer } from "../../model/Customer";

@Component({
  selector: "customer-search",
  templateUrl: "./customer.search.component.html",
  styleUrls: ["./customer.search.component.css"]
})
export class CustomerSearchComponent {
    public customers: Customer[];

  constructor(private router: Router) {
    this.getAllCustomers();
  }


  public getAllCustomers() {
    this.customers = [
      { id: 1, federalIdentification: "1234", name: "Customer 1" },
      { id: 2, federalIdentification: "1235", name: "Customer 2" }];

  }

  public addCustomer() {
    this.router.navigate(['/customer-register']);
  }
}
