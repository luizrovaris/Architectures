import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { Billing } from '../model/billing';
import { Customer } from '../model/Customer';
import { BillingService } from '../services/billing/billing.service';
import { CustomerService } from '../services/customer/customer.service';

@Component({
  selector: 'billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.css']
})
export class BillingComponent implements OnInit {
  public billing: Billing;
  public selectedCustomer: Customer;
  public customers: Customer[];
  public activateSpinner: boolean;
  public message: string;

  constructor(private customerService: CustomerService, private billingService: BillingService, private router: Router) {
    this.getAllCustomers();
  }
  ngOnInit(): void {
    this.billing = new Billing();
  }

  public save() {
    this.activateSpinner = true;

    this.billingService.saveBilling(this.billing)
      .subscribe(
        () => {
          this.activateSpinner = false;
          this.router.navigate(['/customer-search']);
        },
        error => {
          this.message = error.error;
          this.activateSpinner = false;
        }
      );
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

  public selectCustomerChanged() {
    this.billing.customerId = this.selectedCustomer.id;
    this.billing.customer = this.selectedCustomer;
  }
}
