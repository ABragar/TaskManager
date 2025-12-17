using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TaskManager.App;
using TaskManager.App.Abstractions;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.ConfigureServices();

using var host = builder.Build();
var lifetime = host.Services.GetRequiredService<IHostApplicationLifetime>();
var app = host.Services.GetRequiredService<IConsoleService>();

await app.RunAsync(lifetime.ApplicationStopped);
