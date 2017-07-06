using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._6._0
{
    public class NameOfExpression : IRunnable
    {
        public void Run()
        {
            
            var fighter = new Fighter("Shinobi");
            var fighterStatus = FighterStatus.AllStatus;
            Console.WriteLine(string.Join(" ", fighterStatus));
        }
    }

    public class Fighter
    {
        public Fighter(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
        }
    }

    public class FighterStatus
    {
        public const string Alive = "Alive";
        public const string Dead = "Dead";
        public const string Resurrecting = "Resurrecting";

        public static IEnumerable<string> AllStatus = new[] { nameof(Alive),
                                                              nameof(Resurrecting),
                                                              nameof(Dead) };
    }

    
}
