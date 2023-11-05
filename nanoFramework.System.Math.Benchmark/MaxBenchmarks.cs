using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;
using System;

namespace MathBenchmarks
{
    [IterationCount(Iterations)]
    public class MaxBenchmarks: BenchmarksBase
    {
        protected const double DoublePositive1 = Math.PI;
        protected const double DoublePositive2 = DoublePositive1 * 2;
        protected const double DoubleNegative1 = DoublePositive1 * -1;

        protected const float FloatPositive1 = (float)Math.PI;
        protected const float FloatPositive2 = FloatPositive1 * 2;
        protected const float FloatNegative1 = FloatPositive1 * -1;

        protected const int IntPositive1 = 123456789;
        protected const int IntPositive2 = IntPositive1 * 2;
        protected const int IntNegative1 = IntPositive1 * -1;

        [Benchmark]
        public void Max_Double()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Max(DoublePositive1, DoubleNegative1);
                var result2 = Math.Max(DoublePositive2, DoublePositive1);
                var result3 = Math.Max(double.NaN, DoublePositive2);
            });
        }

        [Benchmark]
        public void Max_Float()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Max(FloatPositive1, FloatNegative1);
                var result2 = Math.Max(FloatPositive2, FloatPositive1);
                var result3 = Math.Max(float.NaN, FloatPositive2);
            });
        }

        [Benchmark]
        public void Max_Int()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Max(IntPositive1, IntNegative1);
                var result2 = Math.Max(IntPositive2, IntPositive1);
                var result3 = Math.Max(IntNegative1, IntPositive2);
            });
        }
    }
}
