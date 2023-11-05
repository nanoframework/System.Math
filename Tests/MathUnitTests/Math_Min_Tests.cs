using System;
using nanoFramework.TestFramework;

namespace MathUnitTests
{
    [TestClass]
    public class Math_Min_Tests
    {
        [TestMethod]
        public void Min_Double_returns_lesser_value()
        {
            // TODO: Maybe I'm missing something here but the change in precision here seems like a defect as my expectation is that the same value sent in is returned
            Assert.SkipTest("Skipping pending further investigation");

            var expect = 1234.5678d;
            var higher = expect * 2.0d;

            /*
            var actual1 = Math.Min(expect, higher);
            var actual2 = Math.Min(expect, higher);

            Console.WriteLine($"Test: {Math.Abs(expect - actual1)}");
            Console.WriteLine($"Double: {double.Epsilon}");
            Console.WriteLine($"Float: {float.Epsilon}");

            Assert.IsTrue(Math.Abs(expect - actual1) < double.Epsilon);
            Assert.IsTrue(Math.Abs(expect - actual2) < double.Epsilon);
            */

            Assert.AreEqual(expect, Math.Min(expect, higher));
            Assert.AreEqual(expect, Math.Min(higher, expect));

        }

        [TestMethod]
        public void Min_Double_returns_NaN_if_val1_is_NaN()
        {
            var actual = Math.Min(double.NaN, Math.PI);

            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void Min_Double_returns_NaN_if_val2_is_NaN()
        {
            var actual = Math.Min(Math.PI, double.NaN);

            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void Min_Float_returns_lesser_value()
        {
            var expect = 1234.5678f;
            var higher = expect * 2.0f;

            Assert.AreEqual(expect, Math.Min(expect, higher));
            Assert.AreEqual(expect, Math.Min(higher, expect));
        }

        [TestMethod]
        public void Min_Float_returns_NaN_if_val1_is_NaN()
        {
            var actual = Math.Min(float.NaN, (float) Math.PI);

            Assert.IsTrue(float.IsNaN(actual));
        }

        [TestMethod]
        public void Min_Float_returns_NaN_if_val2_is_NaN()
        {
            var actual = Math.Min((float) Math.PI, float.NaN);

            Assert.IsTrue(float.IsNaN(actual));
        }

        [TestMethod]
        public void Min_Int_returns_lesser_value()
        {
            var expect = 12345678;
            var higher = expect * 2;

            Assert.AreEqual(expect, Math.Min(expect, higher));
            Assert.AreEqual(expect, Math.Min(higher, expect));
        }
    }
}
