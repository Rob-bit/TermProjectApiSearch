using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace ProfileSearchAPIProject
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

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                //Set the session's timeout period and optional settings
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                //options.Cookie.Name = ".CIS3342.SessionCookie";
                //options.Cookie.HttpOnly = true;
            }); //end of AddSession() method

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(options =>
                {
                    options.AddPolicy("Access-Control-Allow-Origin", builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowCredentials();
                    }); //end of AddPolicy() method

                }); //end of AddCors() method



        } // end of ConfigureServices() method

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //configure Cors
            app.UseCors("Access-Control-Allow-Origin");
            app.UseHttpsRedirection();
            app.UseSession();
            app.UseMvc();
        }
    }
}
