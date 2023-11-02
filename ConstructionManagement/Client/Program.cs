global using ConstructionManagement.Client.Services.VehicleServices;
global using ConstructionManagement.Shared;
using ConstructionManagement.Client;
using ConstructionManagement.Client.Services.OrderServices;
using ConstructionManagement.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IUserService, UserService>();

await builder.Build().RunAsync();
