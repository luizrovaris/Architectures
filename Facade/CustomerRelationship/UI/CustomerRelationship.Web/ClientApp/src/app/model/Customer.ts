import { Address } from "./Address";

export class Customer {
  constructor() {
    this.address = new Address();
  }
  public id: number;
  public federalIdentification: string;
  public name: string;
  public address: Address;
}
