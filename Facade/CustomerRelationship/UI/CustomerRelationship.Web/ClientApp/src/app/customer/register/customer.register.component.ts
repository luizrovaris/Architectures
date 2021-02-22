import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Customer } from "../../model/Customer";

@Component({
  selector: "customer-register",
  templateUrl: "./customer.register.component.html",
  styleUrls: ["./customer.register.component.css"]
})
export class CustomerRegisterComponent implements OnInit {
  public customer: Customer;
  public activateSpinner: boolean;

  constructor(private router: Router) {

  }
  ngOnInit(): void {
    var customerOnSession = sessionStorage.getItem("customerEditSession");
    if (customerOnSession) {
      this.customer = JSON.parse(customerOnSession);
      sessionStorage.setItem("customerEditSession", null);
    } else {
      this.customer = new Customer();
    }
  }

  public save() {
    this.activateSpinner = true;
    //this.customerService.save(this.customer)
    //  .subscribe(
    //    customerJson => {
    //      this.activateSpinner = false;
    //      this.router.navigate(['/customer-search']);
    //    },
    //    e => {
    //      this.message = e.error;
    //      this.activateSpinner = false;
    //    }
    //  );
  }
}
