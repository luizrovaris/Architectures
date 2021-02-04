import { Component } from "@angular/core";
import { Customer } from "../../model/Customer";

@Component({
  selector: "customer-search",
  templateUrl: "./customer.search.component.html",
  styleUrls: ["./customer.search.component.css"]
})
export class CustomerSearchComponent {
    public customers: Customer[];

  constructor() {
    this.getAllCustomers();
  }


  public getAllCustomers() {
    this.customers = [
      { id: 1, federalIdentificatin: "1234", name: "Customer 1" },
      { id: 2, federalIdentificatin: "1235", name: "Customer 2" }];

  }
}
