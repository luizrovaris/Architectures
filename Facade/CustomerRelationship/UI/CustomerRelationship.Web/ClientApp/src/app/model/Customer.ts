import { Address } from "./Address";
import { Contact } from "./contact";

export class Customer {
  constructor() {
    this.address = new Address();
    this.contacts = [];
  }
  public id: number;
  public federalIdentification: string;
  public name: string;
  public address: Address;
  public contacts: Contact[];
}
