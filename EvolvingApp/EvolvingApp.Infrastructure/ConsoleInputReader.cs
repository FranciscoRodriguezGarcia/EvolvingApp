namespace EvolvingApp.Infrastructure;

public class ConsoleInputReader : IInputReader
{
    public Task<string?> ReadAsync()
        => Task.FromResult(Console.ReadLine());
}
