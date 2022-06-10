using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;
using Telamoveis.DataAccess;



namespace Telamoveis
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://62a1f3cbcd2e8da9b0ff6b9f.mockapi.io/IMOVEL/");
               // c.BaseAddress = new Uri("https://localhost:44387/");

            });

            await builder.Build().RunAsync();
        }
    }
}
