import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Billing } from '../model/billing';
import { Customer } from '../model/Customer';

@Component({
  selector: 'account-receivable',
  templateUrl: './account-receivable.component.html',
  styleUrls: ['./account-receivable.component.css']
})
export class AccountReceivableComponent {
  public billings: Billing[];

  constructor(private router: Router) {
    this.getAllBillings();
  }

  public setBillingWritteOff(billing: Billing) {
    sessionStorage.setItem("billingSession", JSON.stringify(billing));
    this.router.navigate(['account-receivable-writteoff']);
  }

  public getAllBillings() {
    this.billings = [
      {
        id: 1010,
        invoiceNumber: "0010926",
        emissionDate: new Date(2020, 10, 11),
        dueDate: new Date(2021, 10, 10),
        description: "NF",
        value: 200,
        discountValue: 0,
        increasedValue: 0,
        receiptValue: 0,
        customer: {
          id: 1,
          federalIdentification: "1234",
          name: "Customer 1",
          address: { addressLine1: "Address1", addressLine2: "", postalCode:"0000"}
        }
      },
      {
        id: 1011,
        invoiceNumber: "2310988",
        emissionDate: new Date(2020, 10, 11),
        dueDate: new Date(2021, 10, 10),
        paymentDate: new Date(2021, 10, 10),
        description: "NF",
        value: 300,
        discountValue: 0,
        increasedValue: 0,
        receiptValue: 0,
        customer: {
          id: 2,
          federalIdentification: "1235",
          name: "Customer 2",
          address: { addressLine1: "Address2", addressLine2: "", postalCode: "0000" }
        }
      }
    ];
  }
}
