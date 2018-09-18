using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Library {

    public class Startup {

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddDbContext<LibraryData.Database.LibraryContext>(options 
                => options.UseSqlServer(Configuration.GetConnectionString("LibraryConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment())
                SetupDevelopment(app);
            else
                SetupProduction(app);
            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes());
        }

        private static void SetupProduction(IApplicationBuilder app) {
            app.UseExceptionHandler("/Home/Error");
        }

        private static void SetupDevelopment(IApplicationBuilder app) {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
        }

        private static Action<IRouteBuilder> ConfigureRoutes() {
            return routes => {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            };
        }

    }

}