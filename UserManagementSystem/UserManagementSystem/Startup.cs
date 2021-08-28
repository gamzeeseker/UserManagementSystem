using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.DataAccess.Context;
using UserManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace UserManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(_ => _.UseSqlServer(Configuration["ConnectionStrings:SqlServerConnectionString"]));
            services.AddRazorPages();
            services.AddControllersWithViews();
            //services.AddAuthentication( options=> {
            //    options.DefaultAuthenticateScheme;
            //});
            services.AddAuthentication(
                opt =>
                {
                    opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddCookie();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

         
            services.AddHttpContextAccessor();
            services.AddScoped<DbContext, AppDbContext>();
            // Identity services
            services.AddScoped<IUserValidator<UserEntity>, UserValidator<UserEntity>>();
            services.AddScoped<IPasswordValidator<UserEntity>, PasswordValidator<UserEntity>>();
            services.AddScoped<IPasswordHasher<UserEntity>, PasswordHasher<UserEntity>>();
            services.AddScoped<IUserStore<UserEntity>, UserStore<UserEntity>>();
            services.AddScoped<IRoleStore<RoleEntity>, RoleStore<RoleEntity>>();
            services.AddScoped<ILookupNormalizer, UpperInvariantLookupNormalizer>();
            services.AddScoped<IRoleValidator<UserEntity>, RoleValidator<UserEntity>>();
            // No interface for the error describer so we can add errors without rev'ing the interface
            services.AddScoped<IdentityErrorDescriber>();
            services.AddScoped<ISecurityStampValidator, SecurityStampValidator<UserEntity>>();
            services.AddScoped<ITwoFactorSecurityStampValidator, TwoFactorSecurityStampValidator<UserEntity>>();
            services.AddScoped<IUserClaimsPrincipalFactory<UserEntity>, UserClaimsPrincipalFactory<UserEntity, RoleEntity>>();
            services.AddScoped<IUserConfirmation<UserEntity>, DefaultUserConfirmation<UserEntity>>();
            services.AddScoped<UserManager<UserEntity>>();
            services.AddScoped<SignInManager<UserEntity>>();
            services.AddScoped<RoleManager<RoleEntity>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
