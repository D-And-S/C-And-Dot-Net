using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        
        [Route("Error/{statusCode}")]

        // this method is for .. it user redirect to any invalid URL
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found";
                    _logger.LogWarning($"404 Error Occured. Path = {statusCodeResult.OriginalPath}" +
                                       $" and QueryString = {statusCodeResult.OriginalQueryString}");
                    break;
            }
            return View("NotFound");
        }

        // this method allow how to handle unhandled exception like 500 error
        // in startup class we configure to /error controller that's why 
        // we use route as error
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            // to get the exception details we used this below code
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            // if we want to show details exception then we can set this
            ViewBag.ExceptionPath = exceptionDetails.Path;
            ViewBag.ExceptionMessage = exceptionDetails.Error.Message;
            ViewBag.StackTrace = exceptionDetails.Error.StackTrace;

            _logger.LogError($"The path {exceptionDetails.Path} threw and exception {exceptionDetails.Error}");

            return View("Error");
        }
    }
}
