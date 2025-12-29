// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using EvolvingApp.Application;
using EvolvingApp.ConsoleApp;
using EvolvingApp.Infrastructure;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile(
    "appsettings.json",
    optional: false,
    reloadOnChange: true);

// Application
builder.Services.AddSingleton<IConsoleApp, ConsoleApp>();
builder.Services.AddSingleton<IInputReader, ConsoleInputReader>();
builder.Services.AddSingleton<IOutputWriter, ConsoleOutputWriter>();
builder.Services.AddSingleton<ICommandHandler, CommandHandler>();
builder.Services.AddSingleton<ICalculator, Calculator>();

var host = builder.Build();

var app = host.Services.GetRequiredService<IConsoleApp>();
await app.RunAsync(CancellationToken.None);
