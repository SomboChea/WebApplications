using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Runtime.Serialization;

namespace SE.WebServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(s =>
                {
                    s.AddSingleton<IFormatter, LowercaseFormatter>();
                })
                .ConfigureLogging(f => f.AddConsole())
                .UseStartup<Startup>();
    }
}
