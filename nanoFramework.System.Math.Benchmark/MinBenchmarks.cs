using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;
using System;

namespace MathBenchmarks
{
    [IterationCount(Iterations)]
    public class MinBenchmarks: BenchmarksBase
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
        public void Min_Double()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Min(DoublePositive1, DoubleNegative1);
                var result2 = Math.Min(DoublePositive2, DoublePositive1);
                var result3 = Math.Min(double.NaN, DoublePositive2);
            });
        }

        [Benchmark]
        public void Min_Float()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Min(FloatPositive1, FloatNegative1);
                var result2 = Math.Min(FloatPositive2, FloatPositive1);
                var result3 = Math.Min(float.NaN, FloatPositive2);
            });
        }

        [Benchmark]
        public void Min_Int()
        {
            RunIterations(Loops, () =>
            {
                var result1 = Math.Min(IntPositive1, IntNegative1);
                var result2 = Math.Min(IntPositive2, IntPositive1);
                var result3 = Math.Min(IntNegative1, IntPositive2);
            });
        }
    }
}
