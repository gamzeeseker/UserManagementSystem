using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Domain.Entities;

namespace UserManagementSystem.DataAccess.Context
{
    public class AppDbContext : IdentityDbContext<UserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext) { }
    }
}
