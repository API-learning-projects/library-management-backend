using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Services;
using LibraryManagement.DTO;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerUtils
    {
        private readonly AccountService accountService;

        public AccountController(AccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            string? authorization = Request.Headers["Authorization"];
            
            return RunLogic(() => {
                AccountDTO accountDTO = accountService.Login(authorization);
                return Ok(accountDTO);
            });
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            return RunLogic(() => {
                accountService.Register();
                return Ok();
            });
        }
    }
}
