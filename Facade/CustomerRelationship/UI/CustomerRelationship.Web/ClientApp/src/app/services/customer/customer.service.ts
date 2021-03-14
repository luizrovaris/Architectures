import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Customer } from "../../model/Customer";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class CustomerService implements OnInit {
  private baseUrl: string;
  public customers: Customer[];

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }
  ngOnInit(): void {
    this.customers = [];
  }

  get header(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getAllCustomers(): Observable<Customer[]> {
    return this.httpClient.get<Customer[]>(this.baseUrl + "api/customer", { headers: this.header });
  }

  public saveCustomer(customer: Customer) {
    return this.httpClient.post<Customer>(this.baseUrl + "api/customer", JSON.stringify(customer), { headers: this.header });
  }

  public deleteCustomer(customerId: number) {
    return this.httpClient.delete<Customer[]>(this.baseUrl + "api/customer/" + customerId);
  }
}
