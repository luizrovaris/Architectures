import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbDateAdapter, NgbDateParserFormatter, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { AccountReceivableComponent } from './account-receivable/account-receivable.component';
import { BillingComponent } from './billing/billing.component';
import { CustomerSearchComponent } from './customer/search/customer.search.component';
import { CustomerRegisterComponent } from './customer/register/customer.register.component';
import { CustomerRegisterContactComponent } from './customer/register/contact/customer.register.contact.component';
import { AccountReceivableWritteoffComponent } from './account-receivable/writteoff/account-receivable.writteoff.component';
import { CustomerService } from './services/customer/customer.service';
import { BillingService } from './services/billing/billing.service';
import { CustomDateAdapter } from './helpers/custom.date.adapter';
import { CustomDateParserFormatter } from './helpers/custom.date.parser.formatter';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DashboardClosedBillingComponent } from './dashboard/closed-billing/dashboard.closed-billing.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AccountReceivableComponent,
    AccountReceivableWritteoffComponent,
    BillingComponent,
    CustomerSearchComponent,
    CustomerRegisterComponent,
    CustomerRegisterContactComponent,
    DashboardClosedBillingComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgbModule,
    FormsModule,
    FontAwesomeModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'account-receivable', component: AccountReceivableComponent },
      { path: 'account-receivable-writteoff', component: AccountReceivableWritteoffComponent },
      { path: 'billing', component: BillingComponent },
      { path: 'customer-search', component: CustomerSearchComponent },
      { path: 'customer-register', component: CustomerRegisterComponent }
    ])
  ],
  providers: [CustomerService, BillingService,
              { provide: NgbDateAdapter, useClass: CustomDateAdapter },
              { provide: NgbDateParserFormatter, useClass: CustomDateParserFormatter }],
  bootstrap: [AppComponent]
})
export class AppModule { }
