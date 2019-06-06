using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoreApp.Data.Entities;
using Microsoft.AspNetCore.Identity.UI.Services;
using CoreApp.Persistence;
using CoreApp.Application.Service;
using CoreApp.Persistence.Repository;
using Microsoft.Extensions.Logging;
using CoreApp.Helpers;
using Newtonsoft.Json.Serialization;
using CoreApp.Application.Helpers;
using AutoMapper;
using CoreApp.Application.ViewModels.System;
using Swashbuckle.AspNetCore.Swagger;
using CoreApp.Application.ViewModels.Products;

namespace CoreApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add service and create Policy with options
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                  builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton(Configuration);
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            Mapper.Initialize(config =>
            {
                config.CreateMap<AppUser, UserRegisterViewModel>().ReverseMap();
                config.CreateMap<AppUser, UserUpdateViewModel>().ReverseMap();
                config.CreateMap<AppRole, AddRoleViewModel>().ReverseMap();
                config.CreateMap<ProductCategory, AddProductCategoryViewModel>().ReverseMap();
                config.CreateMap<Product, AddProductViewModel>().ReverseMap();
            });
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            //Register JwtHelper
            services.AddScoped<IJwtHelper, JwtHelper>();
            //Register ProductCategoryService 
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            //Register FunctionService
            services.AddScoped<IFunctionService, FunctionService>();
            //Register IUserService
            services.AddScoped<IUserService, UserService>();
            //Register IRoleService
            services.AddScoped<IRoleService, RoleService>();
            //Register IUserService
            services.AddScoped<IAuthService, AuthService>();
            //Register IProductService
            services.AddScoped<IProductService, ProductService>();
            // Set Service Provider for IoC Helper
            IoCHelper.SetServiceProvider(services.BuildServiceProvider());
            // Register the Swagger generator, defining one or more Swagger documents
            
            services.AddAuthentication(Microsoft.AspNetCore.Server.IISIntegration.IISDefaults.AuthenticationScheme);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Information User API",
                    Description = "ASP.NET Core API for user.",
                    TermsOfService = "None",
                });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/lich-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Information User API V1");
            });

            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");

            //    routes.MapRoute(
            //        name: "areaRoute",
            //        template: "{area:exists}/{controller=Login}/{action=Index}/{id?}");
            //});
        }
    }
}
