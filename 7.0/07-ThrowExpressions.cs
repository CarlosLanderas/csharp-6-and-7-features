using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._7._0
{
    public class ThrowExpressions : IRunnable
    {
        public void Run()
        {
            var personGreeter = new PersonGreeter("Lucas");
            var salute = personGreeter.Greet(() => "Hola, como estas");
            var englishSalute = personGreeter.Greet(() => "Hi, how are you");
           // personGreeter.Greet(null);
        }

      public class PersonGreeter
        {
            public string Name { get;}
            public PersonGreeter(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

            public string Greet(Func<string> greeter)
            {
                var greeting =  greeter?.Invoke() ?? throw new ArgumentNullException(nameof(greeter));
                return $"{greeting} {Name}";
            }            
        }
    }
}
