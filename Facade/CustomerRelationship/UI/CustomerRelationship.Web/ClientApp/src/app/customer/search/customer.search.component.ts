import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { Customer } from "../../model/Customer";
import { CustomerService } from "../../services/customer/customer.service";

@Component({
  selector: "customer-search",
  templateUrl: "./customer.search.component.html",
  styleUrls: ["./customer.search.component.css"]
})
export class CustomerSearchComponent {
    public customers: Customer[];

  constructor(private customerService: CustomerService, private router: Router) {
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

  public addCustomer() {
    sessionStorage.setItem('customerEditSession', '');
    this.router.navigate(['/customer-register']);
  }

  public editCustomer(customer: Customer) {
    sessionStorage.setItem('customerEditSession', JSON.stringify(customer));
    this.router.navigate(['/customer-register']);
  }

  public removeCustomer(customerId: number) {
    if (confirm("Are you sure you want to permanently delete this customer?") == true) {
      this.customerService.deleteCustomer(customerId).subscribe(
        success => {
          this.customers = success;
        },
        e => {
          console.log(e.error);
        }
      );
    }
  }
}
