using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public static class KISSFizzBuzzLogic
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
            StringBuilder result = new StringBuilder();

            if (value % 3 == 0)
            {
                result.Append("Fizz");
            }

            if (value % 5 == 0)
            {
                result.Append("Buzz");
            }

            return result.Length == 0 ? value.ToString(CultureInfo.InvariantCulture) : result.ToString();
        }
    }
}
