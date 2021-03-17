using CustomerRelationship.Facade.Exchange.CustomerRelationship;
using CustomerRelationship.Facade.Orchestration.CustomerRelationship;
using CustomerRelationship.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CustomerRelationship.Web.Controllers
{
    [Route("api/[controller]")]
    public class BillingController : Controller
    {
        private readonly IFacadeOrchestratorBilling _facadeOrchestratorBilling;

        public BillingController(IFacadeOrchestratorBilling facadeOrchestratorBilling)
        {
            this._facadeOrchestratorBilling = facadeOrchestratorBilling;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBillings()
        {
            ActionResult result;
            var input = new GetBillingsInput();
            GetBillingsOutput output;

            try
            {
                output = await this._facadeOrchestratorBilling.GetBillingsAsync(input);

                if (output.Success)
                {
                    result = Ok(output.Billings);
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
        public async Task<IActionResult> Post([FromBody] Billing billing)
        {
            ActionResult result;
            var input = new SaveBillingInput();
            SaveBillingOutput output;

            try
            {
                input.Billing = billing;
                output = await this._facadeOrchestratorBilling.SaveBillingAsync(input);

                if (output.Success)
                {
                    result = Created("api/account-receivable", billing);
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
