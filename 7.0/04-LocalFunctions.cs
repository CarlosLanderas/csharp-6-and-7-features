using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp.features._7._0
{
    public class LocalFunctions : IRunnable
    {
        public void Run()
        {
            foreach(var number in Enumerable.Range(1, 5))
            {
                ShowFactorial(number);
            }
        }
        
        public void ShowFactorial(int number)
        {
            Console.WriteLine($"Factorial of {number} is {CalculateFactorial()}");

            int CalculateFactorial()
            {
                return Enumerable.Range(1, number).Aggregate((acc, x) => acc * x);
            }
        }
    }
}
