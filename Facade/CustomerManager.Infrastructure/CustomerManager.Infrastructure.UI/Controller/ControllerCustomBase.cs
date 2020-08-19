using CustomerManager.Infrastructure.Model.Exchange;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManager.Infrastructure.UI.Controller
{
    public class ControllerCustomBase : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult GetActionResult(FacadeResponseBase response)
        {
            IActionResult result;

            if (response.Success)
            {
                result = base.Ok(response);
            }
            else
            {
                result = base.BadRequest(response);
            }

            return result;
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
    }
}
