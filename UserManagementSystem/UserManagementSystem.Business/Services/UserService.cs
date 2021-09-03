using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.DataAccess.Context;
using UserManagementSystem.Domain.Entities;
using UserManagementSystem.Model.DTOModels;
using UserManagementSystem.Model.Enum;
using UserManagementSystem.Model.Models;

namespace UserManagementSystem.Business.Services
{
    public class UserService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly AppDbContext _appDbContext;

        public UserService(UserManager<UserEntity> userManager,
            AppDbContext appDbContext)
        {
            _userManager = userManager;
            this._appDbContext = appDbContext;
        }

        public async Task<ResultModelGeneic<List<UserRegisterDto>>> GetAllUser()
        {
            // Test code
            //var list = new List<string>();
            //foreach (var dbEntityEntry in _appDbContext.ChangeTracker.Entries<UserEntity>())
            //{
            //    list.Add(dbEntityEntry.Entity.Id);
            //}

            var result = new ResultModelGeneic<List<UserRegisterDto>>();
            result.Status = ResultStatus.Success;
            result.Data = await _userManager.Users.Select(c => new UserRegisterDto()
            {
                Id=c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                PhoneNumber = c.PhoneNumber,
                Email = c.Email,
            }).AsNoTracking().ToListAsync();

            return result;
        }

        public async Task<ResultModel> CreateUserAsync(UserRegisterDto userRegisterDto)
        {
            var result = new ResultModel();
            try
            {
                var user = new UserEntity
                {
                    UserName = userRegisterDto.UserName,
                    FirstName = userRegisterDto.FirstName,
                    LastName = userRegisterDto.LastName,
                    PhoneNumber = userRegisterDto.PhoneNumber,
                    Birthday = userRegisterDto.Birthday,
                    Email = userRegisterDto.Email
                };
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userRegisterDto.Password);
                await _userManager.CreateAsync(user);
                result.Status = ResultStatus.Success;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Status = ResultStatus.Fail;
            }

            return result;
        }

        public async Task<ResultModel> DeleteAsync(string id)
        {
            var result = new ResultModel();
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                result.Status = ResultStatus.Fail;
                result.Message = "User not found";
            }
            else
            {
                await _userManager.DeleteAsync(user);
                result.Status = ResultStatus.Success;
            }

            return result;
        }
        public async Task<bool> IsExits(string UserName)
        {
            var user = await _userManager.FindByNameAsync(UserName);
            return user != null;
        }
        public async Task<Model.DTOModels.UserEditDto> GetUserAsync(string id)
        {
            var user = await _appDbContext.Users.AsNoTracking()
                                      .FirstOrDefaultAsync(au => au.Id == id);

            return new Model.DTOModels.UserEditDto()
            {
                Birthday = user.Birthday,
                Email = user.Email,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                PhoneNumber = user.PhoneNumber
            };
        }

        public async Task<ResultModel> EditAsync(Model.DTOModels.UserEditDto dto)
        {
            var user = await _userManager.FindByIdAsync(dto.Id);

            var list = new List<string>();

            var result = new ResultModel();
            try
            {
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;
                user.PhoneNumber = dto.PhoneNumber;
                user.Birthday = dto.Birthday;
                user.Email = dto.Email;

                var identityResult = await _userManager.UpdateAsync(user);

                if (identityResult.Succeeded)
                    result.Status = ResultStatus.Success;
                else
                {
                    result.Status = ResultStatus.Fail;
                    result.Message = string.Join(',', identityResult.Errors.Select(c => c.Description).ToList());
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Status = ResultStatus.Fail;
            }

            return result;
        }

    }
}
