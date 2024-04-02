using Carteles.Frontend;
using Carteles.Frontend.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); 
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7195/") }); // provee servicios de backend

builder.Services.AddScoped<IRepository, Repository>();//inyectando clase
await builder.Build().RunAsync();
