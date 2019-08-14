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
            var results = FizzBuzzReadable(1, 100);

            Console.WriteLine(
                    string.Join(Environment.NewLine, results).ToArray()
                );

            Console.Read();
        }

        /// <summary>
        /// FizzBuzz implementation 
        /// Here, I understand that if both conditions are true we print FizzBuzz, because conditions are true independently. 
        /// FizzBuzz is not a new value, it's the result of the two values of both conditions being printed.
        /// </summary>
        /// <param name="minimumValue">First number in the sequence.</param>
        /// <param name="maximumValue">Last number in the sequence.</param>
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

        /// <summary>
        /// FizzBuzz implementation with Linq where every condition is explicit.
        /// </summary>
        /// <param name="minimumValue">First number in the sequence.</param>
        /// <param name="maximumValue">Last number in the sequence.</param>
        /// <returns></returns>
        public static List<string> FizzBuzzRedeableWithLinq(int minimumValue, int maximumValue)
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

        /// <summary>
        /// FizzBuzz solutioon where every condition is explicit.
        /// </summary>
        /// <param name="minimumValue"></param>
        /// <param name="maximumValue"></param>
        /// <returns>List of FizzBuzz elements.</returns>
        public static List<string> FizzBuzzReadable(int minimumValue, int maximumValue)
        {
            List<string> resultValues = new List<string>();

            foreach (var value in Enumerable.Range(minimumValue, maximumValue))
            {
                if(value % 3 == 0 && value % 5 == 0)
                {
                    resultValues.Add("FizzBuzz");
                }
                else if(value % 3 == 0)
                {
                    resultValues.Add("Fizz");
                }
                else if(value % 5 == 0)
                {
                    resultValues.Add("Buzz");
                }
                else
                {
                    resultValues.Add(value.ToString(CultureInfo.InvariantCulture));
                }
            }

            return resultValues;
        }
    }
}
