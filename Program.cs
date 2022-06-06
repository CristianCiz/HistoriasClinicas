using TestHistoriasClinicas.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* Participante Participante1 = new Participante();
            Participante1.Apellido = "Ciz";
            Participante1.Nombre = "Cristian";
            int[] nros = Participante1.Jugada;
            for(int i=0; i < nros.Length;i++)
            {
                nros[i] = i + 5;
            }
            Console.WriteLine(nros);*/
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
