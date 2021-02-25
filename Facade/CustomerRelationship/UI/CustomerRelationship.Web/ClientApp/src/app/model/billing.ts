import { Customer } from "./Customer";

export class Billing {
  public id: number;
  public customer: Customer;
  public invoiceNumber: string;
  public emissionDate: Date;
  public dueDate: Date;
  public description: string;
  public value: number;
}
