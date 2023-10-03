using NumberAnalyzer.Models;


namespace NumberAnalyzer.Helpers
{
    public class NumberLogic
    {
        public string GetMessage(User user)
        {
            bool even = user.inputtedNumber % 2 == 0;
                        
            string? returnMessage;
                        
            if (!even &&
                user.inputtedNumber < 60)
            {
                returnMessage = $"{ user.userName }, { user.inputtedNumber } is odd and less than 60.";
            }
            else if (even &&
                     user.inputtedNumber >= 2 &&
                     user.inputtedNumber <= 24)
            {
                returnMessage = $"{ user.userName }, your number is even and less than 25.";
            }
            else if (even &&
                     user.inputtedNumber >= 26 &&
                     user.inputtedNumber <= 60)
            {
                returnMessage = $"{ user.userName }, your number is even and between 26 and 60 inclusive.";
            }
            else if (even &&
                     user.inputtedNumber > 60)
            {
                returnMessage = $"{ user.userName }, { user.inputtedNumber } is even and greater than 60.";
            }
            else if (!even &&
                     user.inputtedNumber > 60)
            {
                returnMessage = $"{ user.userName }, { user.inputtedNumber } is odd and greater than 60.";
            }
            else
            {
                returnMessage = $"{ user.userName }, your number did not match any of the criteria.";
            }

            return returnMessage;
        
        }

    }
}
