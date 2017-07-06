using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace csharp.features._6._0
{
    public class AwaitInCatchAndFinally : IRunnable
    {
        public void Run()
        {
            var processed = DoSomething(true).GetAwaiter().GetResult();
        }

        public async Task<bool> DoSomething(bool fails)
        {
            bool result = true;
            
            try
            {
                if (fails) throw new Exception("Error happened");
                return result;
            }
            catch (Exception ex)
            {
                result = false;
                await LogError(ex);
                return result;
            }
            finally
            {
                await LogResult(result);
            }
        }

        public async Task<bool> LogError(Exception exception)
        {
            //We log exception error to database for example
            return await Task.FromResult(true);
        }

        public async Task<bool> LogResult(bool result)
        {
            //We do async result logging
            return await Task.FromResult(true);
        }
    }
}
