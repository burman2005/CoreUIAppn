using Core3MeetingApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CoreUIAppn
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddMvc(option => option.EnableEndpointRouting = false)
            //    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            //    .ConfigureApiBehaviorOptions(o => { o.SuppressModelStateInvalidFilter = true; })
            //    .AddJsonOptions(options =>
            //    {
            //        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            //        options.JsonSerializerOptions.PropertyNamingPolicy = null;
            //    });

            //Add framework services
            services.AddDbContext<MeetingContext>(options =>
                 options.UseSqlServer("Server=DESKTOP-8QJT82P\\MSSQLSERVER2019; Database=MeetingManagement; Trusted_Connection=True; MultipleActiveResultSets=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.Use(async (ctx, next) =>
            {
                await next();
                if (ctx.Response.StatusCode == 204)
                {
                    ctx.Response.ContentLength = 0;
                }
            });
        }
    }
}
