using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace csharp.features._6._0
{
    public class ExceptionFilters : IRunnable
    {
        public void Run()
        {
            var httpClient = new HttpClient();
            var streamTask = httpClient.GetStringAsync("https://www.microsoft.com");

            try
            {
                var data = streamTask.GetAwaiter().GetResult();
            }
            catch(Exception e) when (e.LogException())
            {
                //This will be never reached unless LogException 
                //extension method returns TRUE
                throw;
            }
            catch (HttpRequestException ex) when (ex.Message.Contains("404"))
            {                
                throw;
            }
           
        }
    }

    public static class ExceptionExtensions
    {
        public static bool LogException(this Exception ex)
        {
            Console.Error.WriteLine($"Exceptions happen: {ex.Message}");
            return true;
        }
    }
  
}
