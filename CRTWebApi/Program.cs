using Microsoft.AspNetCore.Hosting;
using CRTWebApi.Model;

namespace CRTWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatehostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreatehostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args).
            ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });


    }
}