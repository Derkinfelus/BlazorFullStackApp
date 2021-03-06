using BlazorFullStackApp.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ISuperHeroService, SuperHeroService>();

            builder.Services.AddScoped<ITwodimensionalListService, TwodimensionalListService>();

            builder.Services.AddScoped<IDrop_downListService, Drop_downListService>();

            builder.Services.AddScoped<IMultiDimensionalListService, MultiDimensionalListService>();

            await builder.Build().RunAsync();
        }
    }
}
