using Microsoft.Extensions.Hosting;
using EvolvingApp.Application;
using EvolvingApp.Infrastructure;


namespace EvolvingApp.ConsoleApp;

public class ConsoleApp : IConsoleApp
{
    private readonly IInputReader _input;
    private readonly IOutputWriter _output;
    private readonly ICommandHandler _handler;

    public ConsoleApp(
        IInputReader input,
        IOutputWriter output,
        ICommandHandler handler)
    {
        _input = input;
        _output = output;
        _handler = handler;
    }

    public async Task RunAsync(CancellationToken ct)
    {
        _output.WriteLine("Type two numbers (e.g. '3 4') or 'exit' to quit");

        while (!ct.IsCancellationRequested)
        {
            _output.Write("> ");
            var line = await _input.ReadAsync();

            if (line is null)
                continue;

            if (!_handler.Handle(line))
                break;
        }
    }
}