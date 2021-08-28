using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Domain.Entities;
using UserManagementSystem.Model.DTOModels;

namespace UserManagementSystem.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IUserStore<UserEntity> userStore;

        public UserController(UserManager<UserEntity> userManager,
            IUserStore<UserEntity> userStore)
        {
            _userManager = userManager;
            this.userStore = userStore;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userManager.Users.Select(c => new UserListModel()
            {
                Email = c.Email,
                //FirstName=c.FirstName,
                Id = c.Id,
                LastName = c.LastName,
                Tel = c.PhoneNumber,
                UserName = c.UserName


            }).ToList());
        }
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.IsCreate = false;
            return View(new UserRegisterDto());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var user = new UserEntity
                {
                    UserName = userRegisterDto.UserName,
                    LastName = userRegisterDto.LastName,
                    PhoneNumber = userRegisterDto.PhoneNumber,
                    Birthday = userRegisterDto.Birthday,
                    Email = userRegisterDto.Email
                };
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userRegisterDto.Password);
                await _userManager.CreateAsync(user);
                ViewBag.IsCreate = true;

                return View();
            }
        }
    }
}
