using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace csharp.features._7._0
{
    public class TuplesAndDeconstructions : IRunnable
    {
        public void Run()
        {          
            var result = SumNumbers(2, 12, 56, 3);

            var (key, value) = GetGameSetting("GameDifficulty");
        }

        public (int sum, int total, string) SumNumbers(params int[] numbers)
        {
            int total = 0;
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
                total += 1;                
            }
            return (sum, total, "manolo");
        }

        public (string setting, string value) GetGameSetting(string key)
        {
            return configuration.ContainsKey(key) ? 
                    (key, configuration[key]) :
                    throw new Exception("Key not found");          
        }

        private Dictionary<string, string> configuration = new Dictionary<string, string>()
        {
            ["GameDifficulty"] = "Hard",
            ["MaxPlayers"] = "5",
            ["GameMaxTime"] = "2"
        };

        
    }

    class User { }
}
