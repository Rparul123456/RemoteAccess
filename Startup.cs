using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RemoteServerAccess.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Server.IISIntegration;
using SignalRChat.Hubs;
using RemoteServerAccess.Hub;
using Owin;
using Microsoft.AspNetCore.SignalR;

namespace RemoteServerAccess
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
            services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();
            // services.AddScoped<Login,Login>();
            services.AddDbContextPool<BusinessContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddHttpContextAccessor();
            services.AddAuthentication(IISDefaults.AuthenticationScheme);
            services.AddControllersWithViews();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddRazorPages().AddNewtonsoftJson();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSignalR();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
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

            app.UseSession();

            // app.UseMvcWithDefaultRoute();
            app.UseMvc();

           // var idProvider = new CustomUserIdProvider();

            //GlobalHost.DependencyResolver.Register(typeof(Microsoft.AspNet.SignalR.IUserIdProvider), () => idProvider);
            //GlobalHost.DependencyResolver.Register(typeof(Microsoft.AspNet.SignalR.IUserIdProvider), () => idProvider());

            // Any connection or hub wire up and configuration should go here
            // app.MapSignalR();

            // app.MapSignalR();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Test}");
            });

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chathub");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapHub<ChatHub>("/chathub");
            //});

            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:44307")
                .AllowAnyHeader().AllowAnyMethod().AllowCredentials();
            });
        }
    }
}
