using majorproject.Client;
using majorproject.Client.Services;
using majorproject.Client.Services;
using majorproject.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("majorproject.ServerAPI", (sp, client) =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.EnableIntercept(sp);
})
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("majorproject.ServerAPI"));

builder.Services.AddHttpClientInterceptor();

builder.Services.AddScoped<HttpInterceptorService>();

builder.Services.AddScoped<UserRoleService>();

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();



