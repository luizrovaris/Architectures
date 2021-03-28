import { Component, OnInit } from "@angular/core";
import { Customer } from "../../model/Customer";
import { CustomerService } from "../../services/customer/customer.service";

@Component({
  selector: 'dashboard-closed-billing-cr',
  templateUrl: './dashboard.closed-billing.component.html',
  styleUrls: ['./dashboard.closed-billing.component.css']
})
export class DashboardClosedBillingComponent implements OnInit {
  customers: Customer[];

}
