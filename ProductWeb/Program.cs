using Blazored.Modal;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProductWeb;
using ProductWeb.Services;
using ProductWeb.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7114/") });
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddBlazoredModal();
await builder.Build().RunAsync();
