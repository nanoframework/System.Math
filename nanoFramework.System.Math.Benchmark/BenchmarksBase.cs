using System;

namespace MathBenchmarks
{
    public abstract class BenchmarksBase
    {
        protected const int Iterations = 250;
        protected const int Loops = 100;

        public void RunIterations(int iterations, Action action)
        {
            for (var i = 0; i < iterations; i++)
            {
                action();
            }
        }
    }
}
