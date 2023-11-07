using System;
using nanoFramework.TestFramework;

namespace MathUnitTests
{
    [TestClass]
    public class Max_Tests
    {
        [TestMethod]
        public void Max_Double_returns_greater_value()
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
                val1[0], val1[1], val1[2], val1[3], val2[4], val2[5], val2[6], val2[7]
            };

            for (var i = 0; i < val1.Length; i++)
            {
                var actual = Math.Max(val1[i], val2[i]);

                Assert.IsFalse((expected[i] - actual) > 0.0001d || (expected[i] - actual) < -0.0001d);
            }
        }

        [TestMethod]
        public void Max_Double_returns_NaN_if_both_val1_and_val2_are_NaN()
        {
            var actual = Math.Max(double.NaN, double.NaN);

            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Double_returns_NaN_if_val1_is_NaN()
        {
            var actual = Math.Max(double.NaN, Math.PI);

            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Double_returns_NaN_if_val2_is_NaN()
        {
            var actual = Math.Max(Math.PI, double.NaN);

            Assert.IsTrue(double.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Double_treats_positive_zero_as_greater_than_negative_zero()
        {
            // 00-00-00-00-00-00-00-00
            var positiveZero = 0.0d;

            // 00-00-00-00-00-00-00-80
            var negativeZero = -0.0d;

            var result1 = Math.Max(positiveZero, negativeZero);
            var result2 = Math.Max(negativeZero, positiveZero);

            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(result1)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(result2)));

            Assert.AreEqual(positiveZero, result1);
            Assert.AreEqual(positiveZero, result2);
        }

        [TestMethod]
        public void Max_Float_returns_greater_value()
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
                val1[0], val1[1], val1[2], val1[3], val2[4], val2[5], val2[6], val2[7]
            };

            for (var i = 0; i < val1.Length; i++)
            {
                var actual = Math.Max(val1[i], val2[i]);

                Assert.AreEqual(expected[i], actual);
            }
        }

        [TestMethod]
        public void Max_Float_returns_NaN_if_both_val1_and_val2_are_NaN()
        {
            var actual = Math.Max(float.NaN, float.NaN);

            Assert.IsTrue(float.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Float_returns_NaN_if_val1_is_NaN()
        {
            var actual = Math.Max(float.NaN, (float)Math.PI);

            Assert.IsTrue(float.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Float_returns_NaN_if_val2_is_NaN()
        {
            var actual = Math.Max((float)Math.PI, float.NaN);

            Assert.IsTrue(float.IsNaN(actual));
        }

        [TestMethod]
        public void Max_Float_treats_positive_zero_as_greater_than_negative_zero()
        {
            // 00-00-00-00-00-00-00-00
            var positiveZero = 0.0f;

            // 00-00-00-00-00-00-00-80
            var negativeZero = -0.0f;

            var result1 = Math.Max(positiveZero, negativeZero);
            var result2 = Math.Max(negativeZero, positiveZero);

            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(result1)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(result2)));

            Assert.AreEqual(positiveZero, result1);
            Assert.AreEqual(positiveZero, result2);
        }

        [TestMethod]
        public void Max_Int_returns_greater_value()
        {
            var expect = 12345678;
            var lower = expect / 2;

            Assert.AreEqual(expect, Math.Max(expect, lower));
            Assert.AreEqual(expect, Math.Max(lower, expect));
        }
    }
}
