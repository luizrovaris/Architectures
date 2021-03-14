using CustomerRelationship.Facade.Exchange.CustomerRelationship;
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
                    result = Ok(output.Customers);
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
            var input = new SaveCustomerInput();
            SaveCustomerOutput output;

            try
            {
                input.Customer = customer;
                output = await this._facadeOrchestratorCustomer.SaveCustomerAsync(input);

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ActionResult result;
            var input = new DeleteCustomerInput();
            DeleteCustomerOutput output;

            try
            {
                input.CustomerId = id;
                output = await this._facadeOrchestratorCustomer.DeleteCustomerAsync(input);

                if (output.Success)
                {
                    result = Ok(output.Success);
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
