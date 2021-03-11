﻿using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Facade.Orchestration.CustomerRelationship;
using CustomerRelationship.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CustomerRelationship.Web.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IFacadeOrchestratorCustomer _facadeOrchestratorCustomer;

        public CustomerController(IFacadeOrchestratorCustomer facadeOrchestratorCustomer)
        {
            this._facadeOrchestratorCustomer = facadeOrchestratorCustomer;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            ActionResult result;
            var input = new GetCustomersInput();
            GetCustomersOutput output;

            try
            {
                output = await this._facadeOrchestratorCustomer.GetCustomersAsync(input);

                if (output.Success)
                {
                    result = Ok(output);
                }
                else
                {
                    result = BadRequest(output.GetJoinedErrors());
                }
            }
            catch (Exception ex)
            {
                result = BadRequest(ex);
            }

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            ActionResult result;
            var input = new AddCustomerInput();
            AddCustomerOutput output;

            try
            {
                input.Customer = customer;
                output = await this._facadeOrchestratorCustomer.AddCustomerAsync(input);

                if (output.Success)
                {
                    result = Created("api/customer", customer);
                }
                else
                {
                    result = BadRequest(output.GetJoinedErrors());
                }
            }
            catch (Exception ex)
            {
                result = BadRequest(ex);
            }

            return result;
        }
    }
}
