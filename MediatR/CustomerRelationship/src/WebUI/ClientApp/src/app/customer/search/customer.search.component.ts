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
    
  }
}
