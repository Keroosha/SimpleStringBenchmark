using System;
using System.Net;
using BenchmarkDotNet.Running;

namespace StringBenchmark
{
    /// <summary>
    /// Simple benchmark of string.ToUpper overhead in equals
    /// Thanks @AlexCode :3 
    /// </summary>
    /// <author>
    /// Keroosha
    /// Telegram: @Keroosha
    /// Twitter: @mrdeadtoast
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            var equlityBenchmarkResults1 = BenchmarkRunner.Run<EqualityBenchmark>();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
