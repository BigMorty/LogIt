using System;
using System.Threading.Tasks;

namespace LogIt
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                count += 1;
                Console.WriteLine("Hello World " + count);
                await Task.Delay(1000);
            }
        }
    }
}