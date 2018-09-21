using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace SE.WebBackEnd
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Custom Handle errors
            app.Use(async (ctx, next) =>
            {
                await next();
                string originalPath = ctx.Request.Path.Value;
                ctx.Items["originalPath"] = originalPath;
                string err = "/Error.jsx";

                if(!ctx.Response.HasStarted)
                {
                    switch(ctx.Response.StatusCode)
                    {
                        case 404:
                            ctx.Request.Path = err;
                            await next();
                            break;
                        case 403:
                            ctx.Request.Path = err + "?code=403";
                            await next();
                            break;
                        case 500:
                            ctx.Request.Path = err + "?code=500";
                            await next();
                            break;
                    }
                }

                //if (ctx.Response.StatusCode == 500 && !ctx.Response.HasStarted)
                //{ 
                //    ctx.Request.Path = "/Error.jsx?code=500";
                //    await next();
                //}
                //else if(ctx.Response.StatusCode == 403 && !ctx.Response.HasStarted)
                //{
                //    ctx.Request.Path = "/Error.jsx?code=403";
                //    await next();
                //}
                //else if(ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
                //{
                //    ctx.Request.Path = "/Error.jsx";
                //    await next();
                //}
                
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            
            string url = "https://localhost:44374/Error.jsx?code=404";
            //app.UseStatusCodePagesWithReExecute("/Home/Error.jsx?code={0}");
            
            //app.Use(async (context, next) =>
            //{
            //    await next();
            //    if(context.Response.StatusCode == 404)
            //    {
            //        context.Request.Path = "/Error.jsx";
            //        await next();
            //    }   
            //    //context.Response.Redirect("https://" + context.Request.Host.Value + "/Error.jsx");
            //    //await context.Response.WriteAsync(JsonConvert.SerializeObject(new { msg = context.Request.Host }));
            //});


            //var trackProductRouteHandler = new RouteHandler(context =>
            //{
            //    var routeValues = context.GetRouteData().Values;
            //    return context.Response.WriteAsync($"Line: { string.Join(",",routeValues )}");
            //});

            //var routeBuilder = new RouteBuilder(app, trackProductRouteHandler);
            //routeBuilder.MapRoute(
            //    "Track Product Route:", 
            //    "products/{operation:regex(^track|create|detonate$)}/{id:int}"
            //);

            //routeBuilder.MapRoute("hello/{name}", context => 
            //{
            //    var name = context.GetRouteValue("name");
            //    return context.Response.WriteAsync($"Hello, {name}");
            //});

            //var routes2 = routeBuilder.Build();
            //app.UseRouter(routes2);
        }


    }
}
