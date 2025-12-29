using EvolvingApp.Infrastructure;

namespace EvolvingApp.Application;
public class CommandHandler : ICommandHandler
{
    private readonly ICalculator _sum;
    private readonly IOutputWriter _output;

    public CommandHandler(
        ICalculator sum,
        IOutputWriter output)
    {
        _sum = sum;
        _output = output;
    }

    public bool Handle(string input)
    {
        if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        {
            _output.WriteLine("Bye!");
            return false;
        }

        var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 2 ||
            !int.TryParse(parts[0], out var x) ||
            !int.TryParse(parts[1], out var y))
        {
            _output.WriteLine("Please enter two numbers separated by space.");
            return true;
        }

        var result = _sum.Sum(x, y);
        _output.WriteLine($"Result: {result}");

        return true;
    }
}
