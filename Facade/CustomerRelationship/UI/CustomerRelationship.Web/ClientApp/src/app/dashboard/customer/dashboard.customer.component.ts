import { Component, OnInit } from "@angular/core";
import { Customer } from "../../model/Customer";
import { CustomerService } from "../../services/customer/customer.service";

@Component({
  selector: 'dashboard-customer-cr',
  templateUrl: './dashboard.customer.component.html',
  styleUrls: ['./dashboard.customer.component.css']
})
export class DashboardCustomerComponent implements OnInit {
  customers: Customer[];

  constructor(private customerService: CustomerService) {

  }
  ngOnInit(): void {
    this.getAllCustomers();
  }

  public getAllCustomers() {
    this.customerService.getAllCustomers()
      .subscribe(
        success => {
          this.customers = success;
        },
        error => {
          console.log(error.error);
        }
      );
  }
}
