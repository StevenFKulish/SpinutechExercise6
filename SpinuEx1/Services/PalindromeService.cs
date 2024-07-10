using SpinuEx1.Models;
using SpinuEx1.Services.Interfaces;

namespace SpinuEx1.Services
{
    public class PalindromeService : IPalindromeService
    {
        public bool PalindromeDataCheck(PalindromeTest obj)
        {
            bool returnValue = false;
            int parseValue;

            // take out any commas 
            obj.InputNumeric = obj.InputNumeric.Replace(",", "");

            if (int.TryParse(obj.InputNumeric, out parseValue))
            {
                if (parseValue > 0)
                {
                    returnValue = true;
                }
                else
                {
                    obj.ErrorMessage = "The number must be a positive value.";
                }
            }
            else
            {
                // no number to process
                obj.ErrorMessage = "You must enter a numeric value.";
            }

            return returnValue;
        }

        public string PalindromeCalculator(int value)
        {
            /* 
                checks whether a positive number is a palindrome or not. For
                example, 121 is a palindrome, but 123 is not
            */

            string returnValue = string.Empty;
            int tempNumber = value;
            int reverseValue = 0;

            while (tempNumber != 0)
            {
                reverseValue = (reverseValue * 10) + tempNumber % 10;
                tempNumber /= 10;
            }

            if (value == reverseValue)
            {
                returnValue = "The number is a palindrome.";
            }
            else
            {
                returnValue = "The number is not a palindrome.";
            }

            return returnValue;
        }
    }
}
