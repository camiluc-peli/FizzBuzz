using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = FizzBuzzIsFizzBuzz(1, 100);

            Console.WriteLine(
                    string.Join(Environment.NewLine, results).ToArray()
                );



            Console.Read();
        }

        /// <summary>
        /// Because the FizzBuzz problem is what it is, 
        /// and any other added specifications or extensions will make FizzBuzz stop being FizzBuzz and becoming another problem, 
        /// this is the KISS implementation.
        /// </summary>
        /// <returns>List of FizzBuzz elements.</returns>
        public static List<string> FizzBuzzIsFizzBuzz(int minimumValue, int maximumValue)
        {
            List<string> resultValues = new List<string>();

            foreach (var value in Enumerable.Range(minimumValue, maximumValue))
            {
                string result = string.Empty;

                if(value % 3 == 0)
                {
                    result = "Fizz";
                }

                if(value % 5 == 0)
                {
                    result += "Buzz";
                }

                if(string.IsNullOrEmpty(result))
                {
                    result = value.ToString(CultureInfo.InvariantCulture);
                }

                resultValues.Add(result);
            }

            return resultValues;
        }
    }
}
