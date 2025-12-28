// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using EvolvingApp.Application;
using EvolvingApp.ConsoleApp;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile(
    "appsettings.json",
    optional: false,
    reloadOnChange: true);

// Application
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<ICalculator, Calculator>();
builder.Services.AddSingleton<IInputValidator, InputValidator>();

var host = builder.Build();
await host.RunAsync();
