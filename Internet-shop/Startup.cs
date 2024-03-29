﻿using System;
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
using Internet_shop.Models;

namespace Internet_shop
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
            // получаем строку подключения из файла конфигурации
            string Shirt = Configuration.GetConnectionString("ShirtConnection");
            string Human = Configuration.GetConnectionString("HumanConnection");
            string Jeans = Configuration.GetConnectionString("JeansConnection");
            string Hats = Configuration.GetConnectionString("HatsConnection");

            // добавляем контекст MobileContext в качестве сервиса в приложение
            services.AddDbContext<ShirtContext>(options =>
                options.UseSqlServer(Shirt));
            services.AddDbContext<HumanContext>(options =>
                options.UseSqlServer(Human));
            services.AddDbContext<JeansContext>(options =>
                options.UseSqlServer(Jeans));
            services.AddDbContext<HatContext>(options =>
                options.UseSqlServer(Hats));

            services.AddMvc();
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
