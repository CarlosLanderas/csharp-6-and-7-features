using System;
using System.Collections.Generic;
using System.Text;
using static csharp.features._6._0.Greeter;
using static System.Console;

namespace csharp.features._6._0
{
    public class UsingStatic : IRunnable
    {
        public void Run()
        {
            Salute("Lucas");
        }
    }

    public class Greeter
    {
        public static void Salute(string name)
        {
            WriteLine($"Hello {name}");
        }
    }
}
