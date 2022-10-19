extern alias Core; 
using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;
using System.Diagnostics;

namespace nanoFramework.System.Math.Benchmark
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
            var test = Core.System.Math.Abs(-15);
        }
        [Benchmark]
        public void Math_Abs_float()
        {
            var test = Core.System.Math.Abs(-15f);
        }
        [Benchmark]
        public void Math_Abs_double()
        {
            var test = Core.System.Math.Abs(-15d);
        }
        [Benchmark]
        public void Math_Acos()
        {
            var test = Core.System.Math.Acos(-15);
        }
        [Benchmark]
        public void Math_Asin()
        {
            var test = Core.System.Math.Asin(-15);
        }
        [Benchmark]
        public void Math_Atan()
        {
            var test = Core.System.Math.Atan(-15);
        }
        [Benchmark]
        public void Math_Atan2()
        {
            var test = Core.System.Math.Atan2(-15, -15);
        }
        [Benchmark]
        public void Math_Cbrt()
        {
            var test = Core.System.Math.Cbrt(144);
        }
        [Benchmark]
        public void Math_Ceiling()
        {
            var test = Core.System.Math.Ceiling(-15);
        }
        [Benchmark]
        public void Math_Clamp_double()
        {
            var test = Core.System.Math.Clamp(15d, -15d, 150d);
        }
        [Benchmark]
        public void Math_Clamp_long()
        {
            var test = Core.System.Math.Clamp(15L, -15L, 150L);
        }
        [Benchmark]
        public void Math_Clamp_long_usigned()
        {
            var test = Core.System.Math.Clamp(15u, -15u, 150u);
        }
        [Benchmark]
        public void Math_Clamp_float()
        {
            var test = Core.System.Math.Clamp(15f, -15f, 150f);
        }
        [Benchmark]
        public void Math_Cos()
        {
            var test = Core.System.Math.Cos(-15);
        }
        [Benchmark]
        public void Math_Cosh()
        {
            var test = Core.System.Math.Cosh(-15);
        }
        [Benchmark]
        public void Math_Exp()
        {
            var test = Core.System.Math.Exp(-15);
        }
        [Benchmark]
        public void Math_Floor()
        {
            var test = Core.System.Math.Floor(-15);
        }
        [Benchmark]
        public void Math_IEEERemainder()
        {
            var test = Core.System.Math.IEEERemainder(-15, 15);
        }
        [Benchmark]
        public void Math_Log()
        {
            var test = Core.System.Math.Log(-15);
        }
        [Benchmark]
        public void Math_Log10()
        {
            var test = Core.System.Math.Log10(-15);
        }
        [Benchmark]
        public void Math_Max_int()
        {
            var test = Core.System.Math.Max(-15, 15);
        }
        [Benchmark]
        public void Math_Max_double()
        {
            var test = Core.System.Math.Max(-15d, 15d);
        }
        [Benchmark]
        public void Math_Max_float()
        {
            var test = Core.System.Math.Max(-15f, 15f);
        }
        [Benchmark]
        public void Math_Min_int()
        {
            var test = Core.System.Math.Min(-15, 15);
        }
        [Benchmark]
        public void Math_Min_double()
        {
            var test = Core.System.Math.Min(-15d, 15d);
        }
        [Benchmark]
        public void Math_Min_float()
        {
            var test = Core.System.Math.Min(-15f, 15f);
        }
        [Benchmark]
        public void Math_Pow()
        {
            var test = Core.System.Math.Pow(-15, 15);
        }
        [Benchmark]
        public void Math_Round()
        {
            var test = Core.System.Math.Round(-15);
        }
        [Benchmark]
        public void Math_Sign_double()
        {
            var test = Core.System.Math.Sign(-15d);
        }
        [Benchmark]
        public void Math_Sign_float()
        {
            var test = Core.System.Math.Sign(-15f);
        }
        [Benchmark]
        public void Math_Sin()
        {
            var test = Core.System.Math.Sin(-15);
        }
        [Benchmark]
        public void Math_Sinh()
        {
            var test = Core.System.Math.Sinh(-15);
        }
        [Benchmark]
        public void Math_Sqrt()
        {
            var test = Core.System.Math.Sqrt(-15);
        }
        [Benchmark]
        public void Math_Tan()
        {
            var test = Core.System.Math.Tan(-15);
        }
        [Benchmark]
        public void Math_Tanh()
        {
            var test = Core.System.Math.Tanh(-15);
        }
        [Benchmark]
        public void Math_Truncate()
        {
            var test = Core.System.Math.Truncate(-15);
        }
    }
}
