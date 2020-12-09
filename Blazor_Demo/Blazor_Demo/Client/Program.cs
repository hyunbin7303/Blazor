using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazor_Demo.Business;
using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.TestFake;
using Blazor_Demo.Client.ItemEdit;

namespace Blazor_Demo.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            //builder.Services.AddSingleton<IUserManager, UserManager>(); //DI
            builder.Services.AddScoped<IUserManager, UserManagerFake>(); //DI
            builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
            builder.Services.AddScoped<ItemEditService>();

            var host = builder.Build();
            var curUserService = host.Services.GetRequiredService<ICurrentUserService>();
            TestData.CreateTestUser();
            curUserService.CurrentUser = TestData.Tuser;

            await host.RunAsync();
            
            //await builder.Build().RunAsync();
        }
    }
}
