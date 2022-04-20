using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        
    }
}
