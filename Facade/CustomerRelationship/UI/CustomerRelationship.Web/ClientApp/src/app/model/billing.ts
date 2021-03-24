import { Customer } from "./Customer";

export class Billing {
  public id: number;
  public invoiceNumber: string;
  public emissionDate: Date;
  public dueDate: Date;
  public paymentDate?: Date;
  public description: string;
  public value: number;
  public receiptValue?: number;
  public increasedValue?: number;
  public discountValue?: number;

  public customerId: number;
  public customer: Customer;
}
