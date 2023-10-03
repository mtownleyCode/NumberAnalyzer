using NumberAnalyzer.Helpers;
using NumberAnalyzer.Models;

bool continueAnalyzer = true;

User user = new User();
UserInputs userInputs = new UserInputs();
NumberLogic numberLogic = new NumberLogic();

Console.WriteLine("Welcome to the number analyzer.");

Console.WriteLine();

userInputs.SetUsersName(user);

while (continueAnalyzer)
{
    userInputs.GetNumber(user);

    Console.WriteLine($"You entered { user.inputtedNumber.ToString() }");

    Console.WriteLine();

    Console.WriteLine(numberLogic.GetMessage(user));
    
    Console.WriteLine();
    
    continueAnalyzer = userInputs.ContinueAnalyzer(user);

}