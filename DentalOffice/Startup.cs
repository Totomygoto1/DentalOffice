using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice
{
    public class Startup
    {

        // Implementation of Dependency Injection Pattern in C# (construct) on ProductList, Product
        // not only => dependency injection till mer än endast controllers och dbcontext
        // TODO
        // Easy search for earlier Appointments (find images & notes), Available times
        // Add Search functionality for Visit Class same as ... =>
        // Add Search functionality for DentistAvailable Class same as ... =>
        // .. => https://github.com/Totomygoto1/ContosoUniversity/blob/master/ContosoUniversity/Pages/Students/Index.cshtml
        // .. => https://github.com/Totomygoto1/ContosoUniversity/blob/master/ContosoUniversity/Pages/Students/Index.cshtml.cs

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<DentalOfficeDBContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DentalOfficeDBContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
