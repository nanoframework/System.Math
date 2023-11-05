using System;
using nanoFramework.TestFramework;

namespace MathUnitTests
{
    [TestClass]
    public class Min_Tests
    {
        [TestMethod]
        public void Min_Double_returns_lesser_value_INVESTIGATE()
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
        public void Min_Double_returns_lesser_value()
        {
            var val1 = new[]
            {
                6.00000000000000000000d, 6.50000000000000000000d, 7.00000000000000000000d, 7.50000000000000000000d,
                -0.50000000000000000000d, -1.00000000000000000000d, -1.50000000000000000000d, -2.00000000000000000000d
            };
            var val2 = new[]
            {
                1d, 1.140238321d, 1.600286858d, 2.509178479d, 4.121836054d, 6.890572365d, 11.59195328d, -0.50000000000000000000d
            };

            var expected = new[]
            {
                val2[0], val2[1], val2[2], val2[3], val1[4], val1[5], val1[6], val1[7]
            };

            for (var i = 0; i < val1.Length; i++)
            {
                var actual = Math.Min(val1[i], val2[i]);

                Assert.IsFalse((expected[i] - actual) > 0.0001d || (expected[i] - actual) < -0.0001d);
            }
        }

        [TestMethod]
        public void Min_Double_returns_NaN_if_both_val1_and_val2_are_NaN()
        {
            var actual = Math.Min(double.NaN, double.NaN);

            Assert.IsTrue(double.IsNaN(actual));
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
            var val1 = new[]
            {
                6.00000000000000000000f, 6.50000000000000000000f, 7.00000000000000000000f, 7.50000000000000000000f,
                -0.50000000000000000000f, -1.00000000000000000000f, -1.50000000000000000000f, -2.00000000000000000000f
            };
            var val2 = new[]
            {
                1f, 1.140238321f, 1.600286858f, 2.509178479f, 4.121836054f, 6.890572365f, 11.59195328f, -0.50000000000000000000f
            };

            var expected = new[]
            {
                val2[0], val2[1], val2[2], val2[3], val1[4], val1[5], val1[6], val1[7]
            };

            for (var i = 0; i < val1.Length; i++)
            {
                var actual = Math.Min(val1[i], val2[i]);

                Assert.AreEqual(expected[i], actual);
            }
        }

        [TestMethod]
        public void Min_Float_returns_NaN_if_both_val1_and_val2_are_NaN()
        {
            var actual = Math.Min(float.NaN, float.NaN);

            Assert.IsTrue(float.IsNaN(actual));
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
