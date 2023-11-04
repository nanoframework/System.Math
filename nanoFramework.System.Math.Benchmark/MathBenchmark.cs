using System;
using System.Diagnostics;
using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;

namespace MathBenchmarks
{
    [DebugLogger]
    [ConsoleParser]
    [IterationCount(500)]
    public class MathBenchmark
    {
        public MathBenchmark()
        {
            Debug.WriteLine("\n\nStarting MathBenchmark...");
        }

        [Benchmark]
        public void Math_Abs_int()
        {
            var test = Math.Abs(-15);
        }
        [Benchmark]
        public void Math_Abs_float()
        {
            var test = Math.Abs(-15f);
        }
        [Benchmark]
        public void Math_Abs_double()
        {
            var test = Math.Abs(-15d);
        }
        [Benchmark]
        public void Math_Acos()
        {
            var test = Math.Acos(-15);
        }
        [Benchmark]
        public void Math_Asin()
        {
            var test = Math.Asin(-15);
        }
        [Benchmark]
        public void Math_Atan()
        {
            var test = Math.Atan(-15);
        }
        [Benchmark]
        public void Math_Atan2()
        {
            var test = Math.Atan2(-15, -15);
        }
        [Benchmark]
        public void Math_Cbrt()
        {
            var test = Math.Cbrt(144);
        }
        [Benchmark]
        public void Math_Ceiling()
        {
            var test = Math.Ceiling(-15);
        }
        [Benchmark]
        public void Math_Clamp_double()
        {
            var test = Math.Clamp(15d, -15d, 150d);
        }
        [Benchmark]
        public void Math_Clamp_long()
        {
            var test = Math.Clamp(15L, -15L, 150L);
        }
        [Benchmark]
        public void Math_Clamp_long_usigned()
        {
            var test = Math.Clamp(15u, -15u, 150u);
        }
        [Benchmark]
        public void Math_Clamp_float()
        {
            var test = Math.Clamp(15f, -15f, 150f);
        }
        [Benchmark]
        public void Math_Cos()
        {
            var test = Math.Cos(-15);
        }
        [Benchmark]
        public void Math_Cosh()
        {
            var test = Math.Cosh(-15);
        }
        [Benchmark]
        public void Math_Exp()
        {
            var test = Math.Exp(-15);
        }
        [Benchmark]
        public void Math_Floor()
        {
            var test = Math.Floor(-15);
        }
        [Benchmark]
        public void Math_IEEERemainder()
        {
            var test = Math.IEEERemainder(-15, 15);
        }
        [Benchmark]
        public void Math_Log()
        {
            var test = Math.Log(-15);
        }
        [Benchmark]
        public void Math_Log10()
        {
            var test = Math.Log10(-15);
        }
        [Benchmark]
        public void Math_Max_int()
        {
            var test = Math.Max(-15, 15);
        }
        [Benchmark]
        public void Math_Max_double()
        {
            var test = Math.Max(-15d, 15d);
        }
        [Benchmark]
        public void Math_Max_float()
        {
            var test = Math.Max(-15f, 15f);
        }
        [Benchmark]
        public void Math_Min_int()
        {
            var test = Math.Min(-15, 15);
        }
        [Benchmark]
        public void Math_Min_double()
        {
            var test = Math.Min(-15d, 15d);
        }
        [Benchmark]
        public void Math_Min_float()
        {
            var test = Math.Min(-15f, 15f);
        }
        [Benchmark]
        public void Math_Pow()
        {
            var test = Math.Pow(-15, 15);
        }
        [Benchmark]
        public void Math_Round()
        {
            var test = Math.Round(-15);
        }
        [Benchmark]
        public void Math_Sign_double()
        {
            var test = Math.Sign(-15d);
        }
        [Benchmark]
        public void Math_Sign_float()
        {
            var test = Math.Sign(-15f);
        }
        [Benchmark]
        public void Math_Sin()
        {
            var test = Math.Sin(-15);
        }
        [Benchmark]
        public void Math_Sinh()
        {
            var test = Math.Sinh(-15);
        }
        [Benchmark]
        public void Math_Sqrt()
        {
            var test = Math.Sqrt(-15);
        }
        [Benchmark]
        public void Math_Tan()
        {
            var test = Math.Tan(-15);
        }
        [Benchmark]
        public void Math_Tanh()
        {
            var test = Math.Tanh(-15);
        }
        [Benchmark]
        public void Math_Truncate()
        {
            var test = Math.Truncate(-15);
        }
    }
}
