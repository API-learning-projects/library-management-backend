using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerUtils
    {
        private readonly TestService testService;

        public TestController(TestService testService)
        {
            this.testService = testService;
        }

        [HttpPost]
        public IActionResult Test()
        {
            return RunLogic(() => {
                testService.Test();
                return Ok();
            });
        }
    }
}
