using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using escuela_asp_net_core.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Facturacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            //Asegurándome que primero la BD esté creada
            var host = CreateWebHostBuilder(args).Build();

            //Para que no se quede vivo en memoria utilizamos el using
            using(var scope = host.Services.CreateScope()){
                var services = scope.ServiceProvider;

                try{ 
                    var context = services.GetRequiredService<EscuelaContext>();
                    context.Database.EnsureCreated();
                }
                catch(Exception ex){
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex , "An error ocurred creating the BD");
                } 
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
