using EmployeeManagement.Models;
using EmployeeManagement.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*
               using addDbContextPool means every time an instance 
              of this AppDbContext class
              is requested instead of creating brand new instance 
            */
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_config.GetConnectionString("DefaultConnection")));

            //register service for identity user and role which will create table after migration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>();

            //For confuguration through IdentityOption mean we can override 
            // default configuration. such as passowordOption or UserOption 
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;

            });

            services.AddMvc(option =>
            {
                /*
                    we will set up policy which basically saying 
                    when it comes to any controller and it's related method
                    make them authorization required. 
                 */
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();

                // we will filter the policy
                option.Filters.Add(new AuthorizeFilter(policy));
                option.EnableEndpointRouting = false;
            });

            
            // this method is for user claim weather he is authorize to do something
            services.AddAuthorization(options =>
            {
                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Delete Role")
                                   .RequireClaim("Create Role"));

            // this is only edit role policy
            //options.AddPolicy("EditRolePolicy",
            //  policy => policy.RequireClaim("Edit Role"));

            // this is for who is admin and has authorize to edit role 
            // or super admin

            options.AddPolicy("EditRolePolicy", policy =>
            {
                policy.RequireAssertion(context =>
                    context.User.IsInRole("Admin") &&
                    context.User.HasClaim(claim => claim.Type == "Edit Role") ||
                    context.User.IsInRole("Super Admin"));
            });

            // this is for custom claim authorization
            //options.AddPolicy("EditRolePolicy", 
            //    policy => policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));

            options.AddPolicy("AdminRolePolicy",
                    policy => policy.RequireRole("Admin"));
            });

            // amader normally access denied view ache kintu 
            // amra chachi je. jokhon kno authorization error hobe tokhon amra 
            // specific page e seta send korbo. ata korar jonno niche service

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Administrator/AccessDenied");
            });

            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();

            // to ad custome authorization we need use extention method
           // services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndHandler>();
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
                // this method will show only status code and related message
                // when use this middle ware we need to environment set to production
                //app.UseStatusCodePages();

                // this method will reqirect with code and custome view
                // akhane /error/{0}/ mane holo jodi 404 error hoy 
                // tahole ata error controller ar 404 page e jabe 

                //in this middleware /Error means Error Controller and {0} is placeholder
                //app.UseStatusCodePagesWithRedirects("/Error/{0}");

                //for global expection handling if any error happen in production
                // then it will go error controller and will be completed it's process
                app.UseExceptionHandler("/Error");

                // which will replace the url to custom error page
                app.UseStatusCodePagesWithReExecute("/Error/{0}");

            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

        }
    }
}
