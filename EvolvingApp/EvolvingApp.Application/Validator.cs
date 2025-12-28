namespace EvolvingApp.Application;

public class InputValidator : IInputValidator
{
    public int Validate(ConsoleKeyInfo keyInput)
    {
        if (char.IsDigit(keyInput.KeyChar))
            return int.Parse(keyInput.KeyChar.ToString());

        return 1;
    }
}
