using System.Threading;
using nanoFramework.Benchmark;

namespace MathBenchmarks
{
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run(typeof(IAssemblyHandler).Assembly);
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
