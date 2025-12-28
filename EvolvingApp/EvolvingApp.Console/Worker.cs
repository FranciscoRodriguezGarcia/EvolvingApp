using Microsoft.Extensions.Hosting;
using EvolvingApp.Application;

namespace EvolvingApp.ConsoleApp;

public class Worker : BackgroundService
{
    private readonly ICalculator _calculator;
    private readonly IInputValidator _validator;

    public Worker(
        ICalculator calculator,
        IInputValidator validator)
    {
        _calculator = calculator;
        _validator = validator;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        System.Console.Clear();

        System.Console.WriteLine("Insert first value...");
        var x = _validator.Validate(System.Console.ReadKey());

        System.Console.WriteLine("\nInsert second value...");
        var y = _validator.Validate(System.Console.ReadKey());

        var result = _calculator.Sum(x, y);

        System.Console.WriteLine($"\nResult: {result}");

        await Task.Delay(8000, stoppingToken);
    }
}
