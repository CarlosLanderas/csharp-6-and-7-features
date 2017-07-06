using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace csharp.features._7._0
{
    public class AsyncReturnTypes : IRunnable
    {
        public static string CachedData = string.Empty;
        public void Run()
        {
            var result = GetData().GetAwaiter().GetResult();
            var result2 = GetData().GetAwaiter().GetResult();
        }

        public async ValueTask<string> GetData()
        {
            if (string.IsNullOrEmpty(CachedData))
            {
                var httpClient = new HttpClient();
                var result = await httpClient.GetStringAsync("http://www.microsoft.com");

                CachedData = result;
                return result;
            }
                
            return CachedData;
        }
    }
}
