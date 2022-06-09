using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using shop_react_.net_back.Data.DTOs;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly UserManager<user> _userManager;
        public AccountController(UserManager<user> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult<user>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
            {
                return Unauthorized(new { message = "Niepoprawny login lub hasło" });
            }

            // alternatywnie można użyć dodatkowy warunek w ifie zamiast kodu ponieżej

            // var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            // if (!result)
            // {
            //     return Unauthorized(new { message = "Niepoprawny login lub hasło" });
            // }

            return Ok(user);        // zwraca usera, zamiennie z "return user;"
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)

        // nie będziemy zwracać Usera w tej metodzie, dlatego nie uzyjemy Task<ActionResult<User>>
        // po zarejestrowaniu poprosimy ich po prostu o zalogowanie się, nie będziemy automatycznie ich logować po rejestracji
        {
            var user = new user
            {
                UserName = registerDto.UserName,
                // FirstName = registerDto.FirstName,      // SPRAWDZENIE CZY JEST TO POTRZEBNE
                // LastName = registerDto.LastName,        // SPRAWDZENIE CZY JEST TO POTRZEBNE
                // DateOfBirth = registerDto.DateOfBirth,  // SPRAWDZENIE CZY JEST TO POTRZEBNE
                Email = registerDto.Email,
                // PasswordHash = registerDto.Password     // SPRAWDZENIE CZY JEST TO POTRZEBNE
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)  // loopujemy aray of errors
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return ValidationProblem();
                
                // alternatywna wersja zwracająca błędy
                // return BadRequest(new { message = "Nie udało się zarejestrować użytkownika" });
            }

            await _userManager.AddToRoleAsync(user, "Customer");

            // return StatusCode(201); // ???? 

            return Ok(user);        // zwraca usera, zamiennie z "return user;"
        }
    }
}
