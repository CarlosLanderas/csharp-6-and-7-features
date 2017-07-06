using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._7._0
{
    public class IsPatternMatching : IRunnable
    {
        public void Run()
        {
            var elements = new object[] { null,
                                          new Person {Age = 14, Name = "Lucas" },
                                          "155",
                                          Guid.NewGuid(),
                                          14,
                                          new Person { Age = 40, Name = "Johanenson"}                                          
                                         };

            foreach(var element in elements)
            {
                LogUnderAgePerson(element);
                LogNumberGreaterThan10(element);
                Log_Person_With_30_Or_More_Years_And_A_Name_With_More_than_6_Chars(element);
            }

        }

        public void LogUnderAgePerson(object value)
        {
            if (value is Person p && p.Age < 18)
            {
                Console.WriteLine($"{p.Name} is underage, he/she is {p.Age}");
            }
        }
        public void LogNumberGreaterThan10(object value)
        {
            if (value is int i && i > 10 || value is string s && int.TryParse(s, out i))
            {
                Console.WriteLine($"{i} is greater than 10");
            }
        }

        public void Log_Person_With_30_Or_More_Years_And_A_Name_With_More_than_6_Chars(object value)
        {
            if(value is Person p && p.Age >= 30 && p.Name.Length > 6)
            {
                Console.WriteLine($"{p.Name} is older than 30, with a name longer than 6 characters");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
