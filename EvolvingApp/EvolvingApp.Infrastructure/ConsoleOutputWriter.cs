namespace EvolvingApp.Infrastructure;

public class ConsoleOutputWriter : IOutputWriter
{
    public void Write(string message)
        => Console.Write(message);

    public void WriteLine(string message)
        => Console.WriteLine(message);
}
