using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._7._0
{
    public class ExpressionBodiedMembers : IRunnable
    {
        public void Run()
        {
            var snake = new Animal("snake");
            snake = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

    public class Animal
    {
        private string family;
        public string Family
        {
            get => family;
            set => family = value;
        }
        public  Animal(string family) => Family = family;

        ~Animal() => Console.WriteLine("Destructing Animal instance");       
       
    }
}
