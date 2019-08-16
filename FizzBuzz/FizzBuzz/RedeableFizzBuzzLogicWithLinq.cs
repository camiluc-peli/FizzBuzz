using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    class RedeableFizzBuzzWithLinq
    {
        public static List<string> GetElements(int minimumValue, int maximumValue)
        {
            return Enumerable.Range(minimumValue, maximumValue)
                .Select(
                    value => (
                        value % 3 == 0 && value % 5 == 0 ? "FizzBuzz" :
                            value % 3 == 0 ? "Fizz" :
                                value % 5 == 0 ? "Buzz" :
                                    value.ToString(CultureInfo.InvariantCulture)))
                .ToList();
        }
    }
}
