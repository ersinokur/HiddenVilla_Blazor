using DataAccess.Data;
using HiddenVilla_Server.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using Business.Repository;
using HiddenVilla_Server.Service.IServices;
using HiddenVilla_Server.Service;
using Microsoft.AspNetCore.Identity;

namespace HiddenVilla_Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DeafultConnetion")));

            // identity tablolari oldutuktan sonra bu servisi ekle
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders()
                .AddDefaultUI();

           

            //automapper blazor taraf�nda kullanmak i�in ayarlad�k.
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IHotelRoomRepository, HotelRoomRepository>();
            services.AddScoped<IHotelRoomImagesRepository, HotelRoomImagesRepository>();
            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddHttpContextAccessor();
            

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //IDBInitializer'i de ekle
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            //scaffold identity eklendikten sonra
            app.UseAuthentication();
            app.UseAuthorization();
            //kurulu�ta rol, admin ve admin rol tan�mlar� i�in olu�turdu�umuz seed s�n�f�n� �al��t�r
            dbInitializer.Initalize();

           

            app.UseEndpoints(endpoints =>
            {
                //ekle
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
