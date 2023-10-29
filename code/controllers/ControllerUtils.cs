using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class ControllerUtils : ControllerBase
    {
        public IActionResult RunLogic(Func<IActionResult> func)
        {
            try
            {
                return func();
            }
            catch (BadHttpRequestException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}