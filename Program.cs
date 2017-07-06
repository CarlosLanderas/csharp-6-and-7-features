using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace csharp.features
{   
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteRunnables();
        }

        private static void ExecuteRunnables()
        {
            var runnables = (from type in typeof(Program).GetTypeInfo().Assembly.GetTypes()
                             let typeInfo = type.GetTypeInfo()
                             where typeInfo.IsClass && typeof(IRunnable).IsAssignableFrom(type)
                             select type).ToList();


            for (int i = 0; i < runnables.Count(); i++)
            {
                var runnable = Activator.CreateInstance(runnables[i]) as IRunnable;
                Console.WriteLine($"--------Example: {runnables[i].Name} ----------");
                runnable.Run();
            }
        }
    }   
}