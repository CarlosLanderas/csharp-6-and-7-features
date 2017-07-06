using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace csharp.features._6._0
{
    public class StringInterpolation : IRunnable
    {
        public void Run()
        {
            var averageValue = InterpolationTests.Average(new[] { 5, 6, 100, 2, 4 });
            Console.WriteLine(averageValue);

            var multiPlyResult = InterpolationTests.Multiply(5, 2);
            Console.WriteLine(multiPlyResult);
        }
    }
    public class InterpolationTests
    {
        public static string Average(IEnumerable<int> numbers) => $"Average value of {numbers?.Count()} is {numbers.Average()}";

        public static string Multiply(int number, int multiplyBy)
        {
            Func<int, int> multiplier = (num) => num * multiplyBy;

            return $"{number} multiplied by {multiplyBy} is {multiplier(number)}";
        }
    }
}
