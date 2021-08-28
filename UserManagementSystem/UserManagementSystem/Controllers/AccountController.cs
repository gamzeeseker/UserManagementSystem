using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Domain.Entities;
using UserManagementSystem.Model.DTOModels;

namespace UserManagementSystem.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<UserEntity> _userManager;

        public AccountController(SignInManager<UserEntity> signInManager,
            ILogger<AccountController> logger,
            UserManager<UserEntity> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

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
                var result = await _signInManager.PasswordSignInAsync(loginDto.UserName,
                               loginDto.Password, true, lockoutOnFailure: true);

                if (result.Succeeded)
                {


                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
        }
    }
}
