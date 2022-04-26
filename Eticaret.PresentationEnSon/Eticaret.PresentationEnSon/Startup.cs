using Eticaret.Business.Helpers;
using Eticaret.Business.Services;
using Eticaret.DataAccess.Abstract;
using Eticaret.DataAccess.Concrete;
using Eticaret.PresentationEnSon.Areas.Admin.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon
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
            services.AddControllersWithViews();
            services.AddScoped<ICookieHelper, CookieHelper>();
            services.AddScoped<IStringHelper, StringHelper>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDal,UserDal>();

            services.AddScoped<IUserTokenService, UserTokenService>();
            services.AddScoped<IUserTokenDal, UserTokenDal>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryDal, CategoryDal>();

            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderDal, SliderDal>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDal, ProductDal>();

            services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IProductImageDal, ProductImageDal>();

            services.AddSingleton<ICacheManager, CacheManager>();
            services.AddSingleton<IMemoryCache, MemoryCache>();
            services.AddScoped<IAdminChecker, AdminChecker>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDal, OrderDal>();


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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "urun", pattern: "/urun/{name}", defaults: new 
                    { controller = "Product", action = "Index"});

                endpoints.MapControllerRoute(name: "basket", pattern: "/basket", defaults: new
                { controller = "Basket", action = "AddBasket" });

                endpoints.MapControllerRoute(name: "getbasket", pattern: "/get-basket", defaults: new
                { controller = "Basket", action = "GetBasket" });

                endpoints.MapControllerRoute(name: "basketDetail", pattern: "/mybasket", defaults: new
                { controller = "Basket", action = "Index" });

                endpoints.MapControllerRoute(name: "order", pattern: "/order", defaults: new
                { controller = "Checkout", action = "Index" });

                endpoints.MapControllerRoute(name: "shop", pattern: "/kategori/{name}/{page?}", defaults: new
                { controller = "Shop", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "AdminArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
