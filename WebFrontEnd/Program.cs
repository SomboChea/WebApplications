using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using SE.WebFrontEnd.Configs;

namespace SE.WebFrontEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {

            StreamReader rd = new StreamReader("Configs/Lang/en_US.json");
            JsonTextReader jrd = new JsonTextReader(rd);
            //JsonSerializer jsz = new JsonSerializer();

            string str = File.ReadAllText("Configs/Lang/en_US.json");
            var data = JsonConvert.SerializeObject(str);
        
            Console.WriteLine("Json Data: {0}", data);

            CreateWebHostBuilder(args).Build().Run();

            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.ConfigureAppConfiguration(config => { config.AddJsonFile("Configs/Lang/" + Language.Current + ".json", optional:true); })
                .UseStartup<Startup>();
    }
}
