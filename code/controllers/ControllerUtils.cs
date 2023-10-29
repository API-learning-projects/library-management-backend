using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class ControllerUtils : ControllerBase
    {
        public static IActionResult RunLogic(Func<IActionResult> func)
        {
            try
            {
                return new OkObjectResult(func());
            }
            catch (BadHttpRequestException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}