namespace EvolvingApp.Console;

public static class Validator 
{
    
    public static int Validate (System.ConsoleKeyInfo keyInput)
    {
        if (char.IsDigit(keyInput.KeyChar))
{
    // Convert the single character to a string, then parse it to an int
    var number = int.Parse(keyInput.KeyChar.ToString());
    return number;
    
}
else
{
   return 1;
}
    }

}