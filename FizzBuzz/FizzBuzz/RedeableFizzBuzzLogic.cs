using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    public static class RedeableFizzBuzzLogic
    {
        public static List<string> GetElements(int minimumValue, int maximumValue)
        {
            List<string> resultValues = new List<string>();

            foreach (var value in Enumerable.Range(minimumValue, maximumValue))
            {
                resultValues.Add(FizzOrBuzz(value));
            }

            return resultValues;
        }

        private static string FizzOrBuzz(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
