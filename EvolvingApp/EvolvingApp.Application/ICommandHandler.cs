namespace EvolvingApp.Application;
public interface ICommandHandler
{
    bool Handle(string input);
}