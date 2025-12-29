namespace EvolvingApp.Infrastructure;
public interface IOutputWriter
{
    void Write(string message);
    void WriteLine(string message);
}
