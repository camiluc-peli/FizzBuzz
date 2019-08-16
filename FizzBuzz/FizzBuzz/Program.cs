using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = FizzBuzzWithSpecs.GetElements(1, 100);

            Console.WriteLine(
                    string.Join(Environment.NewLine, results).ToArray()
                );

            Console.Read();
        }
    }
}
