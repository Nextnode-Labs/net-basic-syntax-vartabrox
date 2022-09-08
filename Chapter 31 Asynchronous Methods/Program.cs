/* An asynchronous method is a method that can return before it has finished
executing. Any method that performs a potentially long-running task, such
as accessing a web resource or reading a file, can be made asynchronous
to improve the responsiveness of the program. */

using static System.Console;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncMethods
{
    class AsyncStream
    {
        string[] progLang = { "C#", "C++", "Python", "PHP", "Java" };
        public async IAsyncEnumerable<string> DataAsyncStream()
        {
            for (int i = 0; i < progLang.Length; i++)
            {
                Console.WriteLine($"Getting {i + 1} element");
                await Task.Delay(2000);
                yield return progLang[i];
            }
        }
    }

    class Program
    {
        async void AsyncMethod()
        {
            WriteLine("WriteLine #1");
            await System.Threading.Tasks.Task.Delay(2000);
            WriteLine("WriteLine #3");
        }

        private static async ValueTask<double> PowTwo(double x)
        {
            if (x < 15 && x > -5)
            {
                return System.Math.Pow(x, 2);
            }

            return await Task.Run(() => System.Math.Pow(x, 2));
        }

        async static Task Main()
        {
            new Program().AsyncMethod();
            WriteLine("WriteLine #2");
            ReadKey();

            WriteLine("--- Async Return Types ---");

            await PrintAsync();   // calling an asynchronous method
            Console.WriteLine("Just an inscription #2 on the command line");

            void Print()
            {
                Thread.Sleep(3000); // simulation of work 3 seconds
                Console.WriteLine("Just an inscription #1 on the command line");
            }

            async Task PrintAsync()
            {
                Console.WriteLine("Starting an async method");
                await Task.Run(() => Print());
                Console.WriteLine("End of asynchronous method");
            }

            WriteLine("--- Custom Async Methods ---");

            Func<string, Task> print = async (mess) =>
            {
                await Task.Delay(2000);
                WriteLine(mess);
            };

            await print("Async #1");
            await print("Async #2");

            WriteLine("--- Extended Return Types ---");

            double num = await PowTwo(4);
            WriteLine(num); // 16

            WriteLine("--- Async Streams ---");

            AsyncStream repo = new AsyncStream();
            IAsyncEnumerable<string> progLang = repo.DataAsyncStream();
            await foreach (var lang in progLang)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
