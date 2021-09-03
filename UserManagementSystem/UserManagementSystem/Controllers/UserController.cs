using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Business.Services;
using UserManagementSystem.Domain.Entities;
using UserManagementSystem.Model.DTOModels;
using UserManagementSystem.Model.Models;

namespace UserManagementSystem.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var requestResult = await _userService.GetAllUser();
            if (requestResult.Status == Model.Enum.ResultStatus.Success)
                return View(requestResult.Data);
            else
                return base.View(new List<UserRegisterDto>());
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
            ViewBag.IsCreate = false;
            if (!ModelState.IsValid)
            {
                var errorList = new List<string>();
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errorList.Add(error.ErrorMessage);
                    }
                }
                ViewBag.Errors = string.Join(',', errorList);
                return View();
            }
            else
            {
                var result = await _userService.CreateUserAsync(userRegisterDto);
                if (result.Status == Model.Enum.ResultStatus.Success)
                    ViewBag.IsCreate = true;
                else
                    ViewBag.Errors = result.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult DeleteForm(string id)
        {
            return View(new DeleteModel() { Id = id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var result = await _userService.DeleteAsync(id);
            if (result.Status == Model.Enum.ResultStatus.Success)
                return Ok();
            return StatusCode(500, result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> EditAsync(string id)
        {
            ViewBag.IsCreate = false;
            return View(await _userService.GetUserAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(Model.DTOModels.UserEditDto userRegisterDto)
        {
            ViewBag.IsCreate = false;
            var result = await _userService.EditAsync(userRegisterDto);
            if (result.Status == Model.Enum.ResultStatus.Fail)
                ViewBag.Errors = result.Message;
            else
                ViewBag.IsCreate = true;

            return View();
        }

        public async Task<IActionResult> UserName(string UserName)
        {
            var result = await _userService.IsExits(UserName);
            return Json(!result);
        }
    }
}