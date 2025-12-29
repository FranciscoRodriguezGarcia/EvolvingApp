namespace EvolvingApp.Application;

public interface IConsoleApp
{
    Task RunAsync(CancellationToken ct);
}