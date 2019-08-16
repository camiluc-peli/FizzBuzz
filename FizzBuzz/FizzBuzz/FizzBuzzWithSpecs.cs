using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzzWithSpecs
    {
        public static List<string> GetElements(int minimumValue, int maximumValue)
        {
            var specs = new List<Func<int, string>>()
            {
                i => (i % 3 == 0) ? "Fizz" : null,
                i => (i % 5 == 0) ? "Buzz" : null,
            };

            return Enumerable.Range(minimumValue, maximumValue)
                .Select(value =>
                    {
                        var spec = specs
                            .Select(func => func(value))
                            .Aggregate((s, s1) => s + s1);
                        return string.IsNullOrEmpty(spec) ? value.ToString(CultureInfo.InvariantCulture) : spec;
                    }
                ).ToList();
        }
    }
}
