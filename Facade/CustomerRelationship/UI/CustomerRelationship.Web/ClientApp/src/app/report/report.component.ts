import { Component } from "@angular/core";
import { Customer } from "../model/Customer";

@Component({
  selector: "report",
  templateUrl: "./report.component.html",
  styleUrls: ["./report.component.css"]
})
export class ReportComponent {
  public customers: Customer[];

}
