using System.Diagnostics;
using System;
using System.Threading;
using nanoFramework.Benchmark;

namespace MathBenchmarks
{
    public class Program
    {
        public static void Main()
        {
#if DEBUG
            Console.WriteLine("Benchmarks should be run in a release build.");
            Debugger.Break();
            return;
#endif
            Console.WriteLine("Running benchmarks...");

            BenchmarkRunner.RunClass(typeof(MaxBenchmarks));
            BenchmarkRunner.RunClass(typeof(MinBenchmarks));

            BenchmarkRunner.RunClass(typeof(MathBenchmark));

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
