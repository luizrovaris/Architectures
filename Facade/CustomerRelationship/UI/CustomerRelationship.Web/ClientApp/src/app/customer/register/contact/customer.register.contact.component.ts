import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { Contact } from "../../../model/contact";

@Component({
  selector: 'customer-register-contact',
  templateUrl: 'customer.register.contact.component.html',
  styleUrls: ['customer.register.contact.component.css']
})
export class CustomerRegisterContactComponent implements OnInit {  
  public contact: Contact;
  @Input() contacts: Contact[];
  @Output() newContactsEvent = new EventEmitter<Contact[]>();

  constructor() {
  }
  ngOnInit(): void {
    this.contact = new Contact();
  }

  public addContact() {
    this.contacts.push(this.contact);
    this.newContactsEvent.emit(this.contacts);
  }
}
