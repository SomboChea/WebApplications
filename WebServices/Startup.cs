using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SE.WebInfrastrutures.Data;

namespace SE.WebServices
{
    public class Startup
    {
        ILogger logger;
        IFormatter formatter;

        public Startup(ILoggerFactory loggerFactory, IFormatter formatter, IConfiguration configuration)
        {
            this.logger = loggerFactory.CreateLogger<Startup>();
            this.formatter = formatter;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);
            logger.LogDebug($"Total Services Initially: {services.Count}");

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(option => option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidateLifetime = false,
            
            //        ValidIssuer = "serverwebaddress",
            //        ValidAudience = "clientwebaddress",
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTsecretkey"]))
            //    });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            //Console.WriteLine("Start\n\n" + Configuration["JWTsecretkey"] + "\nEnd");

            services.AddDbContext<SEDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("SECommerceDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IFormatter formatter)
        {
            logger.LogDebug("Configure() started...");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseAuthentication();
            app.UseMvc();
            logger.LogDebug("Configure() complete.");
        }
    }

    public interface IFormatter
    {
        string Format(string input);
    }

    public class LowercaseFormatter : IFormatter
    {
        public string Format(string input)
        {
            return input.ToLower();
        }
    }

}
