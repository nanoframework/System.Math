//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using nanoFramework.TestFramework;
using System;

namespace MathUnitTests
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public static void Clamp_SByte()
        {
            Assert.AreEqual((sbyte)-1, Math.Clamp((sbyte)-1, (sbyte)-1, (sbyte)1));
            Assert.AreEqual((sbyte)0, Math.Clamp((sbyte)0, (sbyte)-1, (sbyte)1));
            Assert.AreEqual((sbyte)1, Math.Clamp((sbyte)1, (sbyte)-1, (sbyte)1));
            Assert.AreEqual((sbyte)1, Math.Clamp((sbyte)1, (sbyte)-1, (sbyte)1));
            Assert.AreEqual((sbyte)-1, Math.Clamp((sbyte)-2, (sbyte)-1, (sbyte)1));
            Assert.AreEqual((sbyte)1, Math.Clamp((sbyte)2, (sbyte)-1, (sbyte)1));
        }

        [TestMethod]
        public static void Clamp_Byte()
        {
            Assert.AreEqual((byte)1, Math.Clamp((byte)1, (byte)1, (byte)3));
            Assert.AreEqual((byte)2, Math.Clamp((byte)2, (byte)1, (byte)3));
            Assert.AreEqual((byte)3, Math.Clamp((byte)3, (byte)1, (byte)3));
            Assert.AreEqual((byte)1, Math.Clamp((byte)1, (byte)1, (byte)1));
            Assert.AreEqual((byte)1, Math.Clamp((byte)0, (byte)1, (byte)3));
            Assert.AreEqual((byte)3, Math.Clamp((byte)4, (byte)1, (byte)3));
        }

        [TestMethod]
        public static void Clamp_Short()
        {
            Assert.AreEqual((short)-1, Math.Clamp((short)-1, (short)-1, (short)1), "Fail 01");
            Assert.AreEqual((short)0, Math.Clamp((short)0, (short)-1, (short)1), "Fail 02");
            Assert.AreEqual((short)1, Math.Clamp((short)1, (short)-1, (short)1), "Fail 03");
            Assert.AreEqual((short)1, Math.Clamp((short)1, (short)-1, (short)1), "Fail 04");
            Assert.AreEqual((short)-1, Math.Clamp((short)-2, (short)-1, (short)1), "Fail 05");
            Assert.AreEqual((short)1, Math.Clamp((short)2, (short)-1, (short)1), "Fail 06");
        }

        [TestMethod]
        public static void Clamp_UShort()
        {
            Assert.AreEqual((ushort)1, Math.Clamp((ushort)1, (ushort)1, (ushort)3));
            Assert.AreEqual((ushort)2, Math.Clamp((ushort)2, (ushort)1, (ushort)3));
            Assert.AreEqual((ushort)3, Math.Clamp((ushort)3, (ushort)1, (ushort)3));
            Assert.AreEqual((ushort)1, Math.Clamp((ushort)1, (ushort)1, (ushort)1));
            Assert.AreEqual((ushort)1, Math.Clamp((ushort)0, (ushort)1, (ushort)3));
            Assert.AreEqual((ushort)3, Math.Clamp((ushort)4, (ushort)1, (ushort)3));
        }

        [TestMethod]
        public static void Clamp_Int()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable S1905 
            Assert.AreEqual((int)-1, Math.Clamp((int)-1, (int)-1, (int)1));
            Assert.AreEqual((int)0, Math.Clamp((int)0, (int)-1, (int)1));
            Assert.AreEqual((int)1, Math.Clamp((int)1, (int)-1, (int)1));
            Assert.AreEqual((int)1, Math.Clamp((int)1, (int)-1, (int)1));
            Assert.AreEqual((int)-1, Math.Clamp((int)-2, (int)-1, (int)1));
            Assert.AreEqual((int)1, Math.Clamp((int)2, (int)-1, (int)1));
#pragma warning restore S1905 
        }

        [TestMethod]
        public static void Clamp_UInt()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.AreEqual((uint)1, Math.Clamp((uint)1, (uint)1, (uint)3));
            Assert.AreEqual((uint)2, Math.Clamp((uint)2, (uint)1, (uint)3));
            Assert.AreEqual((uint)3, Math.Clamp((uint)3, (uint)1, (uint)3));
            Assert.AreEqual((uint)1, Math.Clamp((uint)1, (uint)1, (uint)1));
            Assert.AreEqual((uint)1, Math.Clamp((uint)0, (uint)1, (uint)3));
            Assert.AreEqual((uint)3, Math.Clamp((uint)4, (uint)1, (uint)3));
#pragma warning restore IDE0004
        }

        [TestMethod]
        public static void Clamp_Long()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.AreEqual((long)-1, Math.Clamp((long)-1, (long)-1, (long)1));
            Assert.AreEqual((long)0, Math.Clamp((long)0, (long)-1, (long)1));
            Assert.AreEqual((long)1, Math.Clamp((long)1, (long)-1, (long)1));
            Assert.AreEqual((long)1, Math.Clamp((long)1, (long)-1, (long)1));
            Assert.AreEqual((long)-1, Math.Clamp((long)-2, (long)-1, (long)1));
            Assert.AreEqual((long)1, Math.Clamp((long)2, (long)-1, (long)1));
#pragma warning restore IDE0004 
        }

        [TestMethod]
        public static void Clamp_ULong()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.AreEqual((ulong)1, Math.Clamp((ulong)1, (ulong)1, (ulong)3), "Fail 01");
            Assert.AreEqual((ulong)2, Math.Clamp((ulong)2, (ulong)1, (ulong)3), "Fail 02");
            Assert.AreEqual((ulong)3, Math.Clamp((ulong)3, (ulong)1, (ulong)3), "Fail 03");
            Assert.AreEqual((ulong)1, Math.Clamp((ulong)1, (ulong)1, (ulong)1), "Fail 04");
            Assert.AreEqual((ulong)1, Math.Clamp((ulong)0, (ulong)1, (ulong)3), "Fail 05");
            Assert.AreEqual((ulong)3, Math.Clamp((ulong)4, (ulong)1, (ulong)3), "Fail 06");
#pragma warning restore IDE0004 
        }

        [TestMethod]
        public static void Clamp_Double()
        {
            Assert.AreEqual(double.NegativeInfinity, Math.Clamp(double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity), "Fail 01");
            Assert.AreEqual(1, Math.Clamp(1, double.NegativeInfinity, double.PositiveInfinity), "Fail 02");
            Assert.AreEqual(double.PositiveInfinity, Math.Clamp(double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity), "Fail 03");
            Assert.AreEqual(double.PositiveInfinity, Math.Clamp(1, double.PositiveInfinity, double.PositiveInfinity), "Fail 04");
            Assert.AreEqual(double.NegativeInfinity, Math.Clamp(1, double.NegativeInfinity, double.NegativeInfinity), "Fail 05");
            Assert.IsTrue(double.IsNaN(Math.Clamp(double.NaN, double.NaN, double.NaN)), "Fail 06");
            Assert.IsTrue(double.IsNaN(Math.Clamp(double.NaN, double.NaN, 1)), "Fail 07");
            Assert.IsTrue(double.IsNaN(Math.Clamp(double.NaN, 1, double.NaN)), "Fail 08");
            Assert.IsTrue(double.IsNaN(Math.Clamp(double.NaN, 1, 1)), "Fail 09");
            Assert.AreEqual(1, Math.Clamp(1, double.NaN, double.NaN), "Fail 10");
            Assert.AreEqual(1, Math.Clamp(1, double.NaN, 1), "Fail 11");
            Assert.AreEqual(1, Math.Clamp(1, 1, double.NaN), "Fail 12");
        }

        [TestMethod]
        public static void Clamp_Float()
        {
            Assert.AreEqual(float.NegativeInfinity, Math.Clamp(float.NegativeInfinity, float.NegativeInfinity, float.PositiveInfinity), "Fail 01");
            Assert.AreEqual(1, Math.Clamp(1, float.NegativeInfinity, float.PositiveInfinity), "Fail 02");
            Assert.AreEqual(float.PositiveInfinity, Math.Clamp(float.PositiveInfinity, float.NegativeInfinity, float.PositiveInfinity), "Fail 03");
            Assert.AreEqual(float.PositiveInfinity, Math.Clamp(1, float.PositiveInfinity, float.PositiveInfinity), "Fail 04");
            Assert.AreEqual(float.NegativeInfinity, Math.Clamp(1, float.NegativeInfinity, float.NegativeInfinity), "Fail 05");
            Assert.IsTrue(float.IsNaN(Math.Clamp(float.NaN, float.NaN, float.NaN)), "Fail 06");
            Assert.IsTrue(float.IsNaN(Math.Clamp(float.NaN, float.NaN, 1)), "Fail 07");
            Assert.IsTrue(float.IsNaN(Math.Clamp(float.NaN, 1, float.NaN)), "Fail 08");
            Assert.IsTrue(float.IsNaN(Math.Clamp(float.NaN, 1, 1)), "Fail 09");
            Assert.AreEqual(1, Math.Clamp(1, float.NaN, float.NaN), "Fail 10");
            Assert.AreEqual(1, Math.Clamp(1, float.NaN, 1), "Fail 11");
            Assert.AreEqual(1, Math.Clamp(1, 1, float.NaN), "Fail 12");
        }

        [TestMethod]
        public static void Clamp_MinGreaterThanMax_ThrowsArgumentException()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((sbyte)1, (sbyte)2, (sbyte)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((byte)1, (byte)2, (byte)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((short)1, (short)2, (short)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((ushort)1, (ushort)2, (ushort)1));

            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004
#pragma warning disable S1905
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((int)1, (int)2, (int)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((uint)1, (uint)2, (uint)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((long)1, (long)2, (long)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((ulong)1, (ulong)2, (ulong)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((float)1, (float)2, (float)1));
            Assert.ThrowsException(typeof(ArgumentException), () => Math.Clamp((double)1, (double)2, (double)1));
#pragma warning restore S1905 
#pragma warning restore IDE0004 
        }

        [TestMethod]
        public static void Cbrt()
        {
            double[] d = new double[] { -3.1415926535897932, -2.7182818284590452, -2.3025850929940457, -1.5707963267948966, -1.0, -0.78539816339744831, -0.63661977236758134, -0.31830988618379067, -0.0, double.NaN, 0.0, 0.31830988618379067, 0.63661977236758134, 0.70710678118654752, 1.0, 1.1283791670955126, 1.4426950408889634, 2.3025850929940457, 3.1415926535897932, double.PositiveInfinity };
            double[] answer = new double[] { -1.4645918875615233, -1.3956124250860895, -1.3205004784536852, -1.1624473515096265, -1.0, -0.92263507432201421, -0.86025401382809963, -0.68278406325529568, -0.0, double.NaN, 0.0, 0.68278406325529568, 0.86025401382809963, 0.89089871814033930, 1.0, 1.0410821966965807, 1.1299472763373901, 1.320500478453685, 1.4645918875615233, double.PositiveInfinity };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Cbrt(d[i]);

                if (double.IsNaN(d[i]))
                {
                    Assert.IsTrue(double.IsNaN(res), $"Cbrt(...{d[i]}) -- FAILED AT: {res}");

                }
                else if (double.IsPositiveInfinity(d[i]))
                {
                    Assert.IsTrue(double.IsPositiveInfinity(res), $"Cbrt(...{d[i]}) -- FAILED AT: {res}");

                }
                else
                {
                    Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Cbrt(...{d[i]}) -- FAILED AT: {res}");
                }
            }
        }

        [TestMethod]
        public static void Test_Not_Numbers()
        {
            double nan = 0.0 / 0.0;
            double pos_inf = (3.0 / 0.0);
            double neg_inf = (-3.0 / 0.0);


            Assert.IsTrue(double.IsNaN(nan), "NaN was not correctly identified");
            Assert.IsFalse(double.IsPositiveInfinity(nan), "NaN was incorrectly identified as Positive Infinity");
            Assert.IsFalse(double.IsNegativeInfinity(nan), "NaN was incorrectly identified as Negative Infinity");

            //--//

            Assert.IsTrue(double.IsPositiveInfinity(pos_inf), "Positive Infinity was not correctly identified");
            Assert.IsFalse(double.IsNaN(pos_inf), "Positive Infinity  was incorrectly identified asdouble.NaN");
            Assert.IsFalse(double.IsNegativeInfinity(pos_inf), "Positive Infinity  was incorrectly identified as Negative Infinity");

            //--//

            Assert.IsTrue(double.IsNegativeInfinity(neg_inf), "NegativeInfinity was not correctly identified");
            Assert.IsFalse(double.IsPositiveInfinity(neg_inf), "NegativeInfinity Infinity was incorrectly identified as Positive Infinity");
            Assert.IsFalse(double.IsNaN(neg_inf), "NegativeInfinity Infinity was incorrectly identified asdouble.NaN");
        }

        [TestMethod]
        public static void Test_Abs_double()
        {

            double val = -0.0029832;
            double answer = 0.0029832;
            double res = Math.Abs(val);

            Assert.NotEqual(res, answer, "Abs(...double val - negative) -- FAILED AT: {res}");

            val = 0.0029832;
            answer = 0.0029832;
            res = Math.Abs(val);
            Assert.NotEqual(res, answer, "Abs(...double val - positive) -- FAILED AT: {res}");

        }

        [TestMethod]
        public static void Test_Acos()
        {
            double[] d = new double[] { 1, 0.866025403, 0.5, 0, -0.5, -0.866025403, -1 };
            double[] answer = new double[] { 0, 0.523598776, 1.047197551, 1.570796327, 2.094395102, 2.617993878, 3.141592654 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Acos(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Acos(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Acos(-2);
            Assert.AreEqual(res.ToString("F0"), "NaN", "Acos(...-2) -- PASS");

            res = Math.Acos(2);
            Assert.AreEqual(res.ToString("F0"), "NaN", "Acos(...2) -- PASS");
        }

        [TestMethod]
        public static void Test_Asin()
        {
            double[] d = new double[] { 0.00000000000000000000, 0.50000000000000000000, 0.86602540378443900000, 1.00000000000000000000/*, -0.86602540378443900000, -0.50000000000000000000, -0.00000000000000012251 */};
            double[] answer = new double[] { 0, 0.523598776, 1.047197551, 1.570796327/*, 2.094395102, 2.617993878, 3.141592654 */};
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Asin(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Asin(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Asin(-2);
            Assert.AreEqual(res.ToString("F0"), "NaN", "Asin(...-2) -- PASS");

            res = Math.Asin(2);
            Assert.AreEqual(res.ToString("F0"), "NaN", "Asin(...2) -- PASS");
        }

        [TestMethod]
        public static void Test_Atan()
        {
            double[] d = new double[] { 0.00000000000000000000, 0.57735026918962600000, 1.73205080756888000000, -1.73205080756888000000, -0.57735026918962600000, double.PositiveInfinity, double.NegativeInfinity };
            double[] answer = new double[] { 0, 0.523598776, 1.047197551, -1.0471975511965985, -0.523598775598299, 1.5707963267949, -1.5707963267949 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Atan(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, "Atan(..." + d[i] + ") -- FAILED AT: {res}");
            }

            res = Math.Atan(double.NaN);

            Assert.AreEqual(res.ToString("F0"), "NaN", "Atan(...NaN) -- PASS");
        }

        [TestMethod]
        public static void Test_Atan2()
        {
            //
            // Summary:
            //     Returns the angle whose tangent is the quotient of two specified numbers.
            //
            // Parameters:
            //   y:
            //     The y coordinate of a point.
            //
            //   x:
            //     The x coordinate of a point.
            //
            // Returns:
            //     An angle, θ, measured in radians, such that -π ≤ θ ≤ π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane.
            // Observe the following:
            // For(x, y) in quadrant 1, 0 < θ < π / 2.
            // For(x, y) in quadrant 2, π / 2 < θ ≤ π.
            // For(x, y) in quadrant 3, -π < θ < -π / 2.
            // For(x, y) in quadrant 4, -π / 2 < θ < 0.
            // For points on the boundaries of the quadrants, the return value is the following:
            // If y is 0 and x is not negative, θ = 0.
            // If y is 0 and x is negative, θ = π.
            // If y is positive and x is 0, θ = π / 2.
            // If y is negative and x is 0, θ = -π / 2.
            // If y is 0 and x is 0, θ = 0.
            // If x or y is NaN, or if x and y are either PositiveInfinity or NegativeInfinity, the method returns NaN.

            double[] _x = new double[] { 0.00000000000000000000, 0.57735026918962600000, 2.59807621135332000000, -4.33012701892220000000, -1.73205080756888000000, -0.00000000000000042880 };
            double[] _y = new double[] { 0.5, 1, 1.5, 2.5, 3, 3.5 };
            double[] answers = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119659000000, -1.04719755119659000000, -0.52359877559829900000, -0.00000000000000012251 };
            double res;
            for (int i = 0; i < _x.Length; i++)
            {
                res = Math.Atan2(_x[i], _y[i]); ;

                Assert.IsFalse((answers[i] - res) > 0.0001d || (answers[i] - res) < -0.0001d, $"Atan2(...{_x[i]}, {_y[i]}) -- FAILED AT: {res}");
            }

            double y = 0;
            double x = 1;
            double answer = 0;
            res = Math.Atan2(y, x);

            Assert.AreEqual(res, answer, $"Atan2(...0, not -ve) -- FAILED AT: {res}");

            y = 0;
            x = -1;
            answer = 3.141592654;
            res = Math.Atan2(y, x);

            Assert.IsFalse((answer - res) > 0.0001d || (answer - res) < -0.0001d, $"Atan2(...0, -ve) -- FAILED AT: {res}");

            y = 2;
            x = 0;
            answer = 1.570796327; // ��/2 
            res = Math.Atan2(y, x);

            Assert.IsFalse((answer - res) > 0.0001d || (answer - res) < -0.0001d, $"Atan2(...+ve, 0) -- FAILED AT: {res}");

            y = -2;
            x = 0;
            answer = -1.570796327; //-��/2 
            res = Math.Atan2(y, x);

            Assert.IsFalse((answer - res) > 0.0001d || (answer - res) < -0.0001d, $"Atan2(...0, -ve) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Ceiling()
        {
            // Summary:
            //     Returns the smallest integer greater than or equal to the specified double-precision
            //     floating-point number.
            //
            // Parameters:
            //   a:
            //     A double-precision floating-point number.
            //
            // Returns:
            //     The smallest integer greater than or equal to a. If a is equal to System.Double.NaN,
            //     System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value
            //     is returned.
            double[] d = new double[] { 0.5, 1.1, 9.5, 19.8 };
            double[] answer = new double[] { 1, 2, 10, 20 };

            double res;
            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Ceiling(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Ceiling(... {d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Ceiling(double.NaN);
            Assert.AreEqual(res.ToString(), "NaN", $"Ceiling(... nan) -- FAILED AT: {res}");

            res = Math.Ceiling(double.NegativeInfinity);
            Assert.AreEqual(res.ToString(), "-Infinity", $"Ceiling(... NegativeInfinity) -- FAILED AT: {res}");

            res = Math.Ceiling(double.PositiveInfinity);
            Assert.AreEqual(res.ToString(), "Infinity", $"Ceiling(... PositiveInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Cos()
        {
            // Summary:
            //     Returns the cosine of the specified angle.
            //
            // Parameters:
            //   d:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The cosine of d.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 1.00000000000000000000, 0.86602540378443900000, 0.50000000000000000000, 0.00000000000000006126, -0.50000000000000000000, -0.86602540378443900000, -1.00000000000000000000 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Cos(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Cos(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Cos(double.NaN);
            Assert.AreEqual(res.ToString(), "NaN", "Cos(...double.NaN) -- PASS");
        }

        [TestMethod]
        public static void Test_Cosh()
        {
            //
            // Summary:
            //     Returns the hyperbolic cosine of the specified angle.
            //
            // Parameters:
            //   value:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The hyperbolic cosine of value. If value is equal to System.Double.NegativeInfinity
            //     or System.Double.PositiveInfinity, System.Double.PositiveInfinity is returned.
            //     If value is equal to System.Double.NaN, System.Double.NaN is returned.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 1.00000000000000000000, 1.14023832107643000000, 1.60028685770239000000, 2.50917847865806000000, 4.12183605386995000000, 6.89057236497588000000, 11.59195327552150000000 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Cosh(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Cosh(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Cosh(double.NaN);
            Assert.AreEqual(res.ToString(), "NaN", "Cosh(...double.NaN) -- PASS");

            res = Math.Cosh(double.NegativeInfinity);
            Assert.AreEqual(res.ToString(), "Infinity", "Cosh(... NegativeInfinity) -- PASS");

            res = Math.Cosh(double.PositiveInfinity);
            Assert.AreEqual(res.ToString(), "Infinity", "Cosh(...PositiveInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_IEEERemainder()
        {
            //
            // Summary:
            //     Returns the remainder resulting from the division of a specified number by
            //     another specified number.
            //
            // Parameters:
            //   x:
            //     A dividend.
            //
            //   y:
            //     A divisor.
            //
            // Returns:
            //     A number equal to x - (y Q), where Q is the quotient of x / y rounded to
            //     the nearest integer (if x / y falls halfway between two integers, the even
            //     integer is returned).  If x - (y Q) is zero, the value +0 is returned if
            //     x is positive, or -0 if x is negative.  If y = 0, System.Double.NaN (Not-A-Number)
            //     is returned.
            double[] x = new double[] { 10, 7, 8, 20 };
            double[] y = new double[] { 3, 2, 5, 12 };
            double[] answer = new double[] { 1, -1, -2, -4 };
            double res;
            int quotient = 7 / 2;

            for (int i = 0; i < x.Length; i++)
            {
                res = Math.IEEERemainder(x[i], y[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"IEEERemainder(...{x[i]}/ {y[i]}) -- FAILED AT: {res}");
            }

            res = Math.IEEERemainder(3, 2); // x/y = 1.5, case of when x/y falls halfway between two integers
            Assert.IsFalse((res - 2) > 0.0001d, $"IEEERemainder(...3,2) -- FAILED AT: {res}");

            res = Math.IEEERemainder(4, 2); // x/y = 2, case when x - (y Q) is zero, the value +0 is returned if x is positive
            Assert.AreEqual(res, 0, $"IEEERemainder(...4,2) -- FAILED AT: {res}");

            res = Math.IEEERemainder(-4, 2); // x/y = -2, case when x - (y Q) is zero, the value -0 is returned if x is negative
            Assert.AreEqual(res, double.Parse("-0"), $"IEEERemainder(...-4,2) -- FAILED AT: {res}");

            res = Math.IEEERemainder(3, 0); // case when If y = 0, System.Double.NaN (Not-A-Number) is returned.
            Assert.IsTrue(double.IsNaN(res), $"IEEERemainder(...3,0) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Exp()
        {
            //
            // Summary:
            //     Returns e raised to the specified power.
            //
            // Parameters:
            //   d:
            //     A number specifying a power.
            //
            // Returns:
            //     The number e raised to the power d. If d equals System.Double.NaN or System.Double.PositiveInfinity,
            //     that value is returned. If d equals System.Double.NegativeInfinity, 0 is
            //     returned.
            double[] d = new double[] { 0.00000000000000000000, 0.50000000000000000000, 1.00000000000000000000, 1.50000000000000000000, 2.00000000000000000000, 2.50000000000000000000, 3.00000000000000000000, 3.50000000000000000000, 4.00000000000000000000, 4.50000000000000000000, 5.00000000000000000000, 5.50000000000000000000, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000 };
            double[] answer = new double[] { 1, 1.648721271, 2.718281828, 4.48168907, 7.389056099, 12.18249396, 20.08553692, 33.11545196, 54.59815003, 90.0171313, 148.4131591, 244.6919323, 403.4287935, 665.141633, 1096.633158, 1808.042414 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Exp(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Exp(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Exp(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Exp(...NaN) -- FAILED AT: {res}");

            res = Math.Exp(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Exp(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Exp(double.NegativeInfinity);
            Assert.AreEqual(res, 0, $"Exp(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Floor()
        {
            //
            // Summary:
            //     Returns the largest integer less than or equal to the specified double-precision
            //     floating-point number.
            //
            // Parameters:
            //   d:
            //     A double-precision floating-point number.
            //
            // Returns:
            //     The largest integer less than or equal to d. If d is equal to System.Double.NaN,
            //     System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value
            //     is returned.
            double[] d = new double[] { -2, -2.5, 0.00000000000000000000, 0.50000000000000000000, 1.00000000000000000000, 1.50000000000000000000, 2.00000000000000000000, 2.50000000000000000000, 3.00000000000000000000, 3.50000000000000000000, 4.00000000000000000000, 4.50000000000000000000, 5.00000000000000000000, 5.50000000000000000000, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000 };
            double[] answer = new double[] { -2, -3, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Floor(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Floor(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Floor(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Floor(...NaN) -- FAILED AT: {res}");

            res = Math.Floor(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Floor(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Floor(double.NegativeInfinity);
            Assert.IsTrue(double.IsNegativeInfinity(res), $"Floor(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Log()
        {
            //
            // Summary:
            //     Returns the natural (base e) logarithm of a specified number.
            //
            // Parameters:
            //   d:
            //     A number whose logarithm is to be found.
            //
            // Returns:
            //     Sign of d Returns Positive The natural logarithm of d; that is, ln d, or
            //     log ed Zero System.Double.NegativeInfinity Negative System.Double.NaN If
            //     d is equal to System.Double.NaN, returns System.Double.NaN. If d is equal
            //     to System.Double.PositiveInfinity, returns System.Double.PositiveInfinity.
            double[] d = new double[] { 0.50000000000000000000, 1.00000000000000000000, 1.50000000000000000000, 2.00000000000000000000, 2.50000000000000000000, 3.00000000000000000000, 3.50000000000000000000, 4.00000000000000000000, 4.50000000000000000000, 5.00000000000000000000, 5.50000000000000000000, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000 };
            double[] answer = new double[] { -0.693147181, 0, 0.405465108, 0.693147181, 0.916290732, 1.098612289, 1.252762968, 1.386294361, 1.504077397, 1.609437912, 1.704748092, 1.791759469, 1.871802177, 1.945910149, 2.014903021 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Log(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Log(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Log(0);
            Assert.IsTrue(double.IsNegativeInfinity(res), $"Log(...0) -- FAILED AT: {res}");

            res = Math.Log(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Log(...NaN) -- FAILED AT: {res}");

            res = Math.Log(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Log(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Log(double.NegativeInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Log(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Log10()
        {
            //
            // Summary:
            //     Returns the base 10 logarithm of a specified number.
            //
            // Parameters:
            //   d:
            //     A number whose logarithm is to be found.
            //
            // Returns:
            //     Sign of d Returns Positive The base 10 log of d; that is, log 10d. Zero System.Double.NegativeInfinity
            //     Negative System.Double.NaN If d is equal to System.Double.NaN, this method
            //     returns System.Double.NaN. If d is equal to System.Double.PositiveInfinity,
            //     this method returns System.Double.PositiveInfinity.
            double[] d = new double[] { 0.50000000000000000000, 1.00000000000000000000, 1.50000000000000000000, 2.00000000000000000000, 2.50000000000000000000, 3.00000000000000000000, 3.50000000000000000000, 4.00000000000000000000, 4.50000000000000000000, 5.00000000000000000000, 5.50000000000000000000, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000 };
            double[] answer = new double[] { -0.301029996, 0, 0.176091259, 0.301029996, 0.397940009, 0.477121255, 0.544068044, 0.602059991, 0.653212514, 0.698970004, 0.740362689, 0.77815125, 0.812913357, 0.84509804, 0.875061263 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Log10(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Log10(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Log10(0);
            Assert.IsTrue(double.IsNegativeInfinity(res), "Log10(...0) -- FAILED AT: {res}");

            res = Math.Log10(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Log10(...NaN) -- FAILED AT: {res}");

            res = Math.Log10(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Log10(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Log10(double.NegativeInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Log10(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Max_2()
        {
            //
            // Summary:
            //     Returns the larger of two double-precision floating-point numbers.
            //
            // Parameters:
            //   val1:
            //     The first of two double-precision floating-point numbers to compare.
            //
            //   val2:
            //     The second of two double-precision floating-point numbers to compare.
            //
            // Returns:
            //     Parameter val1 or val2, whichever is larger. If val1 OR both val1
            //     and val2 are equal to System.Double.NaN, System.Double.NaN is returned.
            double[] x = new double[] { 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000, -0.50000000000000000000, -1.00000000000000000000, -1.50000000000000000000, -2.00000000000000000000 };
            double[] y = new double[] { 1, 1.140238321, 1.600286858, 2.509178479, 4.121836054, 6.890572365, 11.59195328, -0.50000000000000000000 };

            double[] answer = new double[] { 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000, 4.12183605386995000000, 6.89057236497588000000, 11.59195328, -0.50000000000000000000 };
            double res;

            for (int i = 0; i < x.Length; i++)
            {
                res = Math.Max(x[i], y[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Max(...{x[i]}, {y[i]}) -- FAILED AT: {res}");
            }

            res = Math.Max(10, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Max(...10,double.NaN) -- FAILED AT: {res}");

            res = Math.Max(double.NaN, 10);
            Assert.IsTrue(double.IsNaN(res), $"Max(...NaN, 10) -- FAILED AT: {res}");

            res = Math.Max(double.NaN, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Max(...NaN,double.NaN) -- FAILED AT:  {res}");
        }

        [TestMethod]
        public static void Test_Min_2()
        {
            //
            // Summary:
            //     Returns the smaller of two double-precision floating-point numbers.
            //
            // Parameters:
            //   val1:
            //     The first of two double-precision floating-point numbers to compare.
            //
            //   val2:
            //     The second of two double-precision floating-point numbers to compare.
            //
            // Returns:
            //     Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1
            //     and val2 are equal to System.Double.NaN, System.Double.NaN is returned.
            double[] x = new double[] { 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000, -0.50000000000000000000, -1.00000000000000000000, -1.50000000000000000000, -2.00000000000000000000 };
            double[] y = new double[] { 1, 1.140238321, 1.600286858, 2.509178479, 4.121836054, 6.890572365, 11.59195328, -0.50000000000000000000 };

            double[] answer = new double[] { 1, 1.140238321, 1.600286858, 2.509178479, -0.50000000000000000000, -1.00000000000000000000, -1.50000000000000000000, -2.00000000000000000000 };
            double res;

            for (int i = 0; i < x.Length; i++)
            {
                res = Math.Min(x[i], y[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Min(...{x[i]}, {y[i]}) -- FAILED AT: {res}");
            }

            res = Math.Min(10, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Min(...10,double.NaN) -- FAILED AT:  {res}");

            res = Math.Min(double.NaN, 10);
            Assert.AreEqual(res, 10, $"Min(...NaN, 10) -- FAILED AT:  {res}");

            res = Math.Min(double.NaN, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Min(...NaN,double.NaN) -- FAILED AT:  {res}");
        }

        [TestMethod]
        public static void Test_Pow_2()
        {
            //
            // Summary:
            //     Returns a specified number raised to the specified power.
            //
            // Parameters:
            //   x:
            //     A double-precision floating-point number to be raised to a power.
            //
            //   y:
            //     A double-precision floating-point number that specifies a power.
            //
            // Returns:
            //     The number x raised to the power y.
            double[] x = new double[] { 5, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000/* -0.50000000000000000000, -1.00000000000000000000, -1.50000000000000000000, -2.00000000000000000000*/ };
            double[] y = new double[] { 0.5, 1, 1.140238321, 1.600286858, 2.509178479 /*4.121836054, 6.890572365, 11.59195328, -0.50000000000000000000*/ };

            double[] answer = new double[] { 2.23606797749979000000, 6.00000000000000000000, 8.45113347506690000000, 22.51123320954050000000, 156.92238129089800000000 /*NaN,double.NaN,double.NaN,double.NaN*/ };
            double res;

            for (int i = 0; i < x.Length; i++)
            {
                res = Math.Pow(x[i], y[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Pow(...{x[i]}, {y[i]}) -- FAILED AT: {res}");
            }

            x = new double[] { -0.50000000000000000000, -1.00000000000000000000, -1.50000000000000000000, -2.00000000000000000000 };
            y = new double[] { 4.121836054, 6.890572365, 11.59195328, -0.50000000000000000000 };

            for (int i = 0; i < x.Length; i++)
            {
                res = Math.Pow(x[i], y[i]);

                Assert.AreEqual(res.ToString(), "NaN", "Pow(..." + x[i] + ", " + y[i] + ") -- FAILED AT: {res}");
            }

            res = Math.Pow(10, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Pow(...10,double.NaN) -- FAILED AT: {res}");

            res = Math.Pow(double.NaN, 10);
            Assert.IsTrue(double.IsNaN(res), $"Pow(...NaN, 10) -- FAILED AT: {res}");

            res = Math.Pow(double.NaN, double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Pow(...NaN,double.NaN) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Round()
        {
            // Summary:
            //     Rounds a double-precision floating-point value to the nearest integer.
            //
            // Parameters:
            //   a:
            //     A double-precision floating-point number to be rounded.
            //
            // Returns:
            //     The integer nearest a. If the fractional component of a is halfway between
            //     two integers, one of which is even and the other odd, then the even number
            //     is returned.
            double[] d = new double[] { -0.5, -1.2, 0.5, 1.2, 1.5, 6.00000000000000000000, 6.50000000000000000000, 7.00000000000000000000, 7.50000000000000000000 };

            double[] answer = new double[] { 0, -1, 0, 1, 2, 6, 6, 7, 8 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Round(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Round(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Round(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Round(...NaN) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Sign()
        {
            //
            // Summary:
            //     Returns a value indicating the sign of a double-precision floating-point
            //     number.
            //
            // Parameters:
            //   value:
            //     A signed number.
            //
            // Returns:
            //     A number indicating the sign of value.  Number Description -1 value is less
            //     than zero. 0 value is equal to zero. 1 value is greater than zero.
            //
            // Exceptions:
            //   System.ArithmeticException:
            //     value is equal to System.Double.NaN.
            //     is returned.
            double[] d = new double[] { -0.5, -1.2, 0, 1.2, 1.5, 6, 6.5, 7, 8.5 };

            double[] answer = new double[] { -1, -1, 0, 1, 1, 1, 1, 1, 1 };
            double res;
            double[] res1 = new double[d.Length];

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Sign(d[i]);// the output is wrong, needs to be corrected 
                res1[i] = res;

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Sign(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Sign(double.NaN);
            Assert.AreEqual(res, 0, $"Sign(...NaN) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Sin()
        {
            // Summary:
            //     Returns the sine of the specified angle.
            //
            // Parameters:
            //   a:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The sine of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
            //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0.00000000000000000000, 0.50000000000000000000, 0.86602540378443900000, 1.00000000000000000000, 0.86602540378443900000, 0.50000000000000000000, 0.00000000000000012251 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Sin(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, "Sin(..." + d[i] + ") -- FAILED AT: {res}");
            }

            res = Math.Sin(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Sin(...NaN) -- FAILED AT: {res}");

            res = Math.Sin(double.PositiveInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Sin(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Sin(double.NegativeInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Sin(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Sinh()
        {
            //
            // Summary:
            //     Returns the hyperbolic sine of the specified angle.
            //
            // Parameters:
            //   value:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The hyperbolic sine of value. If value is equal to System.Double.NegativeInfinity,
            //     System.Double.PositiveInfinity, or System.Double.NaN, this method returns
            //     a System.Double equal to value.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0.00000000000000000000, 0.54785347388804000000, 1.24936705052398000000, 2.30129890230729000000, 3.99869134279982000000, 6.81762330412654000000, 11.54873935725770000000 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Sinh(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Sinh(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Sinh(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Sinh(...NaN) -- FAILED AT: {res}");

            res = Math.Sinh(double.NegativeInfinity);
            Assert.IsTrue(double.IsNegativeInfinity(res), $"Sinh(...NegativeInfinity) -- FAILED AT: {res}");

            res = Math.Sinh(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Sinh(...PositiveInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Sqrt()
        {
            //
            // Summary:
            //     Returns the square root of a specified number.
            //
            // Parameters:
            //   d:
            //     A number.
            //
            // Returns:
            //     Value of d Returns Zero, or positive The positive square root of d. Negative
            //     System.Double.NaN If d is equal to System.Double.NaN or System.Double.PositiveInfinity,
            //     that value is returned.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0.00000000000000000000, 0.72360125455826800000, 1.02332670794649000000, 1.44720250911654000000, 1.61802159379642000000, 1.77245385090552000000 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Sqrt(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Sqrt(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Sqrt(-2);
            Assert.IsTrue(double.IsNaN(res), $"Sqrt(...-ve) -- FAILED AT: {res}");

            res = Math.Sqrt(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Sqrt(...NaN) -- FAILED AT: {res}");

            res = Math.Sqrt(double.NegativeInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Sqrt(...NegativeInfinity) -- FAILED AT: {res}");

            res = Math.Sqrt(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Sqrt(...PositiveInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Tan()
        {
            //
            // Summary:
            //     Returns the tangent of the specified angle.
            //
            // Parameters:
            //   a:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The tangent of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
            //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, /*1.57079632679490000000, */2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0.00000000000000000000, 0.57735026918962600000, 1.73205080756888000000, -1.73205080756888000000, -0.57735026918962600000, -0.00000000000000012251 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Tan(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Tan(...{d[i]}) -- FAILED AT: {res}");
            }

            // pi/2 
            res = Math.Tan(1.57079632679490000000);
            Assert.IsFalse(double.IsNaN(res), $"Tan(...PI/2) -- FAILED AT: {res}");

            res = Math.Tan(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Tan(...NaN) -- FAILED AT: {res}");

            res = Math.Tan(double.PositiveInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Tan(...PositiveInfinity) -- FAILED AT: {res}");

            res = Math.Tan(double.NegativeInfinity);
            Assert.IsTrue(double.IsNaN(res), $"Tan(...NegativeInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Tanh()
        {
            //
            // Summary:
            //     Returns the hyperbolic tangent of the specified angle.
            //
            // Parameters:
            //   value:
            //     An angle, measured in radians.
            //
            // Returns:
            //     The hyperbolic tangent of value. If value is equal to System.Double.NegativeInfinity,
            //     this method returns -1. If value is equal to System.Double.PositiveInfinity,
            //     this method returns 1. If value is equal to System.Double.NaN, this method
            //     returns System.Double.NaN.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0.00000000000000000000, 0.48047277815645200000, 0.78071443535926800000, 0.91715233566727400000, 0.97012382116593100000, 0.98941320735268200000, 0.99627207622075000000 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Tanh(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Tanh(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Tanh(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Tanh(...NaN) -- FAILED AT: {res}");

            res = Math.Tanh(double.NegativeInfinity);
            Assert.AreEqual(res, -1, $"Tanh(...NegativeInfinity) -- FAILED AT: {res}");

            res = Math.Tanh(double.PositiveInfinity);
            Assert.AreEqual(res, 1, $"Tanh(...PositiveInfinity) -- FAILED AT: {res}");
        }

        [TestMethod]
        public static void Test_Truncate()
        {
            //
            // Summary:
            //     Calculates the integral part of a specified double-precision floating-point
            //     number.
            //
            // Parameters:
            //   d:
            //     A number to truncate.
            //
            // Returns:
            //     The integral part of d; that is, the number that remains after any fractional
            //     digits have been discarded.
            double[] d = new double[] { 0.00000000000000000000, 0.52359877559829900000, 1.04719755119660000000, 1.57079632679490000000, 2.09439510239320000000, 2.61799387799149000000, 3.14159265358979000000 };
            double[] answer = new double[] { 0, 0, 1, 1, 2, 2, 3 };
            double res;

            for (int i = 0; i < d.Length; i++)
            {
                res = Math.Truncate(d[i]);

                Assert.IsFalse((answer[i] - res) > 0.0001d || (answer[i] - res) < -0.0001d, $"Truncate(...{d[i]}) -- FAILED AT: {res}");
            }

            res = Math.Truncate(double.NaN);
            Assert.IsTrue(double.IsNaN(res), $"Truncate(...NaN) -- FAILED AT: {res}");

            res = Math.Truncate(double.NegativeInfinity);
            Assert.IsTrue(double.IsNegativeInfinity(res), $"Truncate(...NegativeInfinity) -- FAILED AT: {res}");

            res = Math.Truncate(double.PositiveInfinity);
            Assert.IsTrue(double.IsPositiveInfinity(res), $"Truncate(...PositiveInfinity) -- FAILED AT: {res}");
        }
    }
}
