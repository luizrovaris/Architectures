"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Customer = void 0;
var Address_1 = require("./Address");
var Customer = /** @class */ (function () {
    function Customer() {
        this.address = new Address_1.Address();
        this.contacts = [];
    }
    return Customer;
}());
exports.Customer = Customer;
//# sourceMappingURL=Customer.js.map