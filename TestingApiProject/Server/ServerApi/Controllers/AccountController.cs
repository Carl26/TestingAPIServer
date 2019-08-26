using Microsoft.AspNetCore.Mvc;
using ServerApi.Models;
using ServerApi.Services;

namespace ServerApi.Controllers
{
    public class AccountController 
    {
        public AccountService AccountService { get; set; }

        public AccountController(AccountService service)
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