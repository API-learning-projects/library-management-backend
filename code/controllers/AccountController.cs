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
                AccountOutgoingDTO accountDTO = accountService.Login(authorization);
                return Ok(accountDTO);
            });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterIncomingDTO register)
        {
            string username = register.Username;
            string password = register.Password;
            string email = register.Email;

            return RunLogic(() => {
                accountService.Register(username, password, email);
                return Ok();
            });
        }
    }
}
