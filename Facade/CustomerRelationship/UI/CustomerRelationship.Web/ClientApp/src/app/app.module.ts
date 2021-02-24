import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
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

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AccountReceivableComponent,
    BillingComponent,
    CustomerSearchComponent,
    CustomerRegisterComponent
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
      { path: 'billing', component: BillingComponent },
      { path: 'customer-search', component: CustomerSearchComponent },
      { path: 'customer-register', component: CustomerRegisterComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
