using CustomerRelationship.Infrastructure.Model.Exchange;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRelationship.Infrastructure.UI.Controller
{
    /// <summary>
    /// Custom controller with default response methods
    /// </summary>
    public class ControllerCustomBase : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult GetActionResultCreated(string uri, FacadeResponseBase response)
        {
            return this.GetActionResult(response, base.Created(uri, response));
        }

        public IActionResult GetActionResultOk(FacadeResponseBase response)
        {
            return this.GetActionResult(response, base.Ok(response));
        }

        public IActionResult GetActionResultPartialView(FacadeResponseBase response, string partial)
        {
            IActionResult result;

            if (response.Success)
            {
                result = PartialView(partial, response);
            }
            else
            {
                result = GetErrorResult(response);
            }

            return result;
        }

        public IActionResult GetErrorResult(FacadeResponseBase response)
        {
            return View("Error", response.Errors);
        }

        private IActionResult GetActionResult(FacadeResponseBase response, ObjectResult objectResult)
        {
            IActionResult result;

            if (response.Success)
            {
                result = objectResult;
            }
            else
            {
                result = base.BadRequest(response);
            }

            return result;
        }
    }
}
