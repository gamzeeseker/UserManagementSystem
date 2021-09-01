using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UserManagementSystem.Domain.Entities;
using UserManagementSystem.Model.DTOModels;

namespace UserManagementSystem.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly UserManager<UserEntity> _userManager;

        public AccountController(SignInManager<UserEntity> signInManager,
            UserManager<UserEntity> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.ErrorMessage = "";
            if (this.User.Identity.IsAuthenticated)
                return RedirectToAction("index", "User");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user != null)
                {
                    var pass = await _userManager.CheckPasswordAsync(user, loginDto.Password);
                    if (pass)
                    {
                        var roles = await _userManager.GetRolesAsync(user);
                        var claims = new List<Claim>();

                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.Email, user.Email));
                        foreach (var rol in roles)
                            claims.Add(new Claim(ClaimTypes.Role, rol));

                        var id = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        var claimsPrincipal = new ClaimsPrincipal(id);

                        await HttpContext.SignInAsync(claimsPrincipal);

                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Username or password is wrong";
                        loginDto.UserName = "";
                        loginDto.Password = "";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Username or password is wrong";
                    loginDto.UserName = "";
                    loginDto.Password = "";
                }
                return View();
            }
        }
    }
}
