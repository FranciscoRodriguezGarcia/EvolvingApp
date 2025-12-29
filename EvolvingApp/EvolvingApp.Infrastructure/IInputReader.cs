namespace EvolvingApp.Infrastructure;
public interface IInputReader
{
    Task<string?> ReadAsync();
}
