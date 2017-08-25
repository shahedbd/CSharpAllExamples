using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAllExamples.Examples.AwaitAndAsync
{
    class AwaitAndAsync
    {
        private static async Task<long> GetPageLengthsAsync(string[] args)
        {
            var client = new HttpClient();
            long pageLengths = 0;

            for (int ctr = 1; ctr < args.Length; ctr++)
            {
                var uri = new Uri(Uri.EscapeUriString(args[ctr]));
                string pageContents = await client.GetStringAsync(uri);
                Interlocked.Add(ref pageLengths, pageContents.Length);
            }
            return pageLengths;
        }

        public static void AwaitAndAsyncIMP()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length < 2)
                throw new ArgumentNullException("No URLs specified on the command line.");

            long characters = GetPageLengthsAsync(args).Result;
            Console.WriteLine($"{args.Length - 1} pages, {characters:N0} characters");
        }

        public static async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public static async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); //1 seconds delay
            return 1;
        }

    }


}
