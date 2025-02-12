namespace DamageCalculatorMAOF.DamageGame;

public class UserInputValidator
{
    public bool ValidateInput(string input, List<string> validInputs)
    {
        if (validInputs.Contains(input.ToLower()))
        {
            return true;
        }
        else if (input == "no invalid message")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter a valid input");
            return false;
        }
    }
    
    
}