import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Billing } from "../../model/billing";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class BillingService implements OnInit{
  private baseUrl: string;
  public billings: Billing[];

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }
  ngOnInit(): void {
    this.billings = [];
  }

  get header(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getAllBillings(): Observable<Billing[]> {
    return this.httpClient.get<Billing[]>(this.baseUrl + "api/billing", { headers: this.header });
  }
}
