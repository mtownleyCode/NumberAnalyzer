using NumberAnalyzer.Models;


namespace NumberAnalyzer.Helpers
{
    public class UserInputs
    {        
        public void SetUsersName(User user)
        {

            bool validAnswer = false;

            while (validAnswer == false)
            {

                Console.WriteLine("What is your name?");

                user.userName = Console.ReadLine();

                Console.WriteLine();

                if (user.userName == "")
                {
                    Console.WriteLine("Enter a valid name.");
                }
                else 
                { validAnswer = true; };

            }

            validAnswer = false;

        }

        public void GetNumber(User user)
        {
            int validNumber;

            bool redoLoop = true;

            while (redoLoop)
            {
                Console.WriteLine($"Enter a number between 1 and 100:");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > 100))
                {
                    Console.WriteLine("Enter a valid number between 1 and 100.");
                    redoLoop = true;                    
                }

                else 
                { 
                    user.inputtedNumber = validNumber;
                    redoLoop = false;
                }

            }

        }

        public bool ContinueAnalyzer(User user)
        {
            char validAnswer;

            bool redoLoop = true;
            bool continueAnalyzer = false;

            while (redoLoop)
            {
                Console.WriteLine($"{ user.userName }, do you wish to continue? y/n");

                if (!char.TryParse(Console.ReadLine().ToLower(), out validAnswer) ||
                    validAnswer != 'y' &&
                    validAnswer != 'n') 
                {
                    Console.WriteLine("Enter y or n only.");
                    redoLoop = true;                    
                }

                else
                {
                    if (validAnswer == 'y')                        
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{ user.userName }, you chose to continue with another number.");
                        Console.WriteLine();
                        continueAnalyzer = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Have a nice day { user.userName }. Goodbye.");
                        continueAnalyzer = false;
                    }

                    redoLoop = false;
                }

            }

            return continueAnalyzer;

        }

    }

}
