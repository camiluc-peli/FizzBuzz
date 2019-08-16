using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public static class RedeableFizzBuzzLogicWithLinqAndPatternMatching
    {
        public static List<string> GetElements(int minimumValue, int maximumValue)
        {
            return Enumerable.Range(minimumValue, maximumValue)
                .Select(
                    value => (value % 3 == 0, value % 5 == 0) switch
                    {
                        (true, true) => "FizzBuzz",
                        (true, false) => "Fizz",
                        (false, true) => "Buzz",
                        _ => value.ToString(CultureInfo.InvariantCulture)
                    }).ToList();
        }
    }
}
