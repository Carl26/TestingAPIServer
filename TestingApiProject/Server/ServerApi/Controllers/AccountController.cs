using Microsoft.AspNetCore.Mvc;
using ServerApi.Models;
using ServerApi.Services;

namespace ServerApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController 
    {
        public IAccountService AccountService { get; set; }

        public AccountController(IAccountService service)
        {
            AccountService = service;
        }

        [HttpGet]
        public ActionResult<AccountResponse> GetUser(AccountRequest request)
        {
            var user = AccountService.GetUser(request.Username);
            return new AccountResponse {
                UserInfo = user
            };
        }

        [HttpPost]
        public ActionResult<AccountResponse> CreateUser(AccountRequest request)
        {
            var newUser = AccountService.CreateUser(new User {
                Username = request.Username
            });
            return new AccountResponse 
            {
                UserInfo = newUser
            };
        }
    }
    
}