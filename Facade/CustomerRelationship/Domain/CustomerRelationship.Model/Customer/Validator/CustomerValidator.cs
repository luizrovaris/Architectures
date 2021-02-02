﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRelationship.Model.Customer.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}