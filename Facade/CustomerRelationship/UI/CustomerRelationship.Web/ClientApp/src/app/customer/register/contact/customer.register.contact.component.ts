import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { Contact } from "../../../model/contact";

@Component({
  selector: 'customer-register-contact',
  templateUrl: 'customer.register.contact.component.html',
  styleUrls: ['customer.register.contact.component.css']
})
export class CustomerRegisterContactComponent implements OnInit {
  public contactMessage: string;
  public contact: Contact;
  public isEditing: boolean;
  @Input() contacts: Contact[];
  @Output() newContactsEvent = new EventEmitter<Contact[]>();

  constructor() {
  }
  ngOnInit(): void {
    this.contact = new Contact();
    this.isEditing = false;
  }

  public addContact() {
    this.contactMessage = "";

    if (this.isEditing) {
      this.contact = new Contact();
    }
    else {
      let currentContact = this.contacts.find(x => x.name === this.contact.name);
      
      if (currentContact) {
        this.contactMessage = "Already exists a contatct with the same name";
      }
      else {
        this.contacts.push(this.contact);
        this.newContactsEvent.emit(this.contacts);
        this.contact = new Contact();
      }
    }

    this.isEditing = false;
  }

  public editContact(currentContact: Contact) {
    this.isEditing = true;
    this.contact = this.contacts.find(x => x.name === currentContact.name);
  }

  public removeContact(currentContact: Contact) {
    const index = this.contacts.indexOf(currentContact, 0);
    if (index > -1) {
      this.contacts.splice(index, 1);
    }
  }
}
