using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testasp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using testasp.Models;
using testasp.Services;
using testasp.Services;
using Microsoft.Extensions.Logging;

namespace testasp
{
    public class Startup

    {

        public Startup(IHostingEnvironment env)

        {

            var builder = new ConfigurationBuilder()

                .SetBasePath(env.ContentRootPath)

                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)

                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);



            if (env.IsDevelopment())

            {

                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709

                builder.AddUserSecrets<Startup>();

            }



            builder.AddEnvironmentVariables();

            Configuration = builder.Build();

        }



        public IConfigurationRoot Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)

        {

            // Add framework services.

            services.AddDbContext<ApplicationDbContext>(options =>

                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));



            services.AddIdentity<ApplicationUser, IdentityRole>()

                .AddEntityFrameworkStores<ApplicationDbContext>()

                .AddDefaultTokenProviders();



            services.AddMvc();



            // Add application services.

            services.AddTransient<IEmailSender, AuthMessageSender>();

            services.AddTransient<ISmsSender, AuthMessageSender>();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)

        {

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            loggerFactory.AddDebug();



            if (env.IsDevelopment())

            {

                app.UseDeveloperExceptionPage();

                app.UseDatabaseErrorPage();

             //   app.UseBrowserLink();

            }

            else

            {

                app.UseExceptionHandler("/Home/Error");

            }



            app.UseStaticFiles();



            app.UseIdentity();



            app.UseMvc(routes =>

            {

                routes.MapRoute(

                    name: "default",

                    template: "{controller=Home}/{action=Index}/{id?}");

            });

        }

    }

}
