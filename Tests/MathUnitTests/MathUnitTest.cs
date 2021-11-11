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
            Assert.Equal((sbyte)-1, Math.Clamp((sbyte)-1, (sbyte)-1, (sbyte)1));
            Assert.Equal((sbyte)0, Math.Clamp((sbyte)0, (sbyte)-1, (sbyte)1));
            Assert.Equal((sbyte)1, Math.Clamp((sbyte)1, (sbyte)-1, (sbyte)1));
            Assert.Equal((sbyte)1, Math.Clamp((sbyte)1, (sbyte)-1, (sbyte)1));
            Assert.Equal((sbyte)-1, Math.Clamp((sbyte)-2, (sbyte)-1, (sbyte)1));
            Assert.Equal((sbyte)1, Math.Clamp((sbyte)2, (sbyte)-1, (sbyte)1));
        }

        [TestMethod]
        public static void Clamp_Byte()
        {
            Assert.Equal((byte)1, Math.Clamp((byte)1, (byte)1, (byte)3));
            Assert.Equal((byte)2, Math.Clamp((byte)2, (byte)1, (byte)3));
            Assert.Equal((byte)3, Math.Clamp((byte)3, (byte)1, (byte)3));
            Assert.Equal((byte)1, Math.Clamp((byte)1, (byte)1, (byte)1));
            Assert.Equal((byte)1, Math.Clamp((byte)0, (byte)1, (byte)3));
            Assert.Equal((byte)3, Math.Clamp((byte)4, (byte)1, (byte)3));
        }

        [TestMethod]
        public static void Clamp_Short()
        {
            Assert.Equal((short)-1, Math.Clamp((short)-1, (short)-1, (short)1), "Fail 01");
            Assert.Equal((short)0, Math.Clamp((short)0, (short)-1, (short)1), "Fail 02");
            Assert.Equal((short)1, Math.Clamp((short)1, (short)-1, (short)1), "Fail 03");
            Assert.Equal((short)1, Math.Clamp((short)1, (short)-1, (short)1), "Fail 04");
            Assert.Equal((short)-1, Math.Clamp((short)-2, (short)-1, (short)1), "Fail 05");
            Assert.Equal((short)1, Math.Clamp((short)2, (short)-1, (short)1), "Fail 06");
        }

        [TestMethod]
        public static void Clamp_UShort()
        {
            Assert.Equal((ushort)1, Math.Clamp((ushort)1, (ushort)1, (ushort)3));
            Assert.Equal((ushort)2, Math.Clamp((ushort)2, (ushort)1, (ushort)3));
            Assert.Equal((ushort)3, Math.Clamp((ushort)3, (ushort)1, (ushort)3));
            Assert.Equal((ushort)1, Math.Clamp((ushort)1, (ushort)1, (ushort)1));
            Assert.Equal((ushort)1, Math.Clamp((ushort)0, (ushort)1, (ushort)3));
            Assert.Equal((ushort)3, Math.Clamp((ushort)4, (ushort)1, (ushort)3));
        }

        [TestMethod]
        public static void Clamp_Int()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable S1905 
            Assert.Equal((int)-1, Math.Clamp((int)-1, (int)-1, (int)1));
            Assert.Equal((int)0, Math.Clamp((int)0, (int)-1, (int)1));
            Assert.Equal((int)1, Math.Clamp((int)1, (int)-1, (int)1));
            Assert.Equal((int)1, Math.Clamp((int)1, (int)-1, (int)1));
            Assert.Equal((int)-1, Math.Clamp((int)-2, (int)-1, (int)1));
            Assert.Equal((int)1, Math.Clamp((int)2, (int)-1, (int)1));
#pragma warning restore S1905 
        }

        [TestMethod]
        public static void Clamp_UInt()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.Equal((uint)1, Math.Clamp((uint)1, (uint)1, (uint)3));
            Assert.Equal((uint)2, Math.Clamp((uint)2, (uint)1, (uint)3));
            Assert.Equal((uint)3, Math.Clamp((uint)3, (uint)1, (uint)3));
            Assert.Equal((uint)1, Math.Clamp((uint)1, (uint)1, (uint)1));
            Assert.Equal((uint)1, Math.Clamp((uint)0, (uint)1, (uint)3));
            Assert.Equal((uint)3, Math.Clamp((uint)4, (uint)1, (uint)3));
#pragma warning restore IDE0004
        }

        [TestMethod]
        public static void Clamp_Long()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.Equal((long)-1, Math.Clamp((long)-1, (long)-1, (long)1));
            Assert.Equal((long)0, Math.Clamp((long)0, (long)-1, (long)1));
            Assert.Equal((long)1, Math.Clamp((long)1, (long)-1, (long)1));
            Assert.Equal((long)1, Math.Clamp((long)1, (long)-1, (long)1));
            Assert.Equal((long)-1, Math.Clamp((long)-2, (long)-1, (long)1));
            Assert.Equal((long)1, Math.Clamp((long)2, (long)-1, (long)1));
#pragma warning restore IDE0004 
        }

        [TestMethod]
        public static void Clamp_ULong()
        {
            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004 
            Assert.Equal((ulong)1, Math.Clamp((ulong)1, (ulong)1, (ulong)3), "Fail 01");
            Assert.Equal((ulong)2, Math.Clamp((ulong)2, (ulong)1, (ulong)3), "Fail 02");
            Assert.Equal((ulong)3, Math.Clamp((ulong)3, (ulong)1, (ulong)3), "Fail 03");
            Assert.Equal((ulong)1, Math.Clamp((ulong)1, (ulong)1, (ulong)1), "Fail 04");
            Assert.Equal((ulong)1, Math.Clamp((ulong)0, (ulong)1, (ulong)3), "Fail 05");
            Assert.Equal((ulong)3, Math.Clamp((ulong)4, (ulong)1, (ulong)3), "Fail 06");
#pragma warning restore IDE0004 
        }

        [TestMethod]
        public static void Clamp_Double()
        {
            Assert.Equal(double.NegativeInfinity, Math.Clamp(double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity), "Fail 01");
            Assert.Equal(1, Math.Clamp(1, double.NegativeInfinity, double.PositiveInfinity), "Fail 02");
            Assert.Equal(double.PositiveInfinity, Math.Clamp(double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity), "Fail 03");
            Assert.Equal(double.PositiveInfinity, Math.Clamp(1, double.PositiveInfinity, double.PositiveInfinity), "Fail 04");
            Assert.Equal(double.NegativeInfinity, Math.Clamp(1, double.NegativeInfinity, double.NegativeInfinity), "Fail 05");
            Assert.True(double.IsNaN(Math.Clamp(double.NaN, double.NaN, double.NaN)), "Fail 06");
            Assert.True(double.IsNaN(Math.Clamp(double.NaN, double.NaN, 1)), "Fail 07");
            Assert.True(double.IsNaN(Math.Clamp(double.NaN, 1, double.NaN)), "Fail 08");
            Assert.True(double.IsNaN(Math.Clamp(double.NaN, 1, 1)), "Fail 09");
            Assert.Equal(1, Math.Clamp(1, double.NaN, double.NaN), "Fail 10");
            Assert.Equal(1, Math.Clamp(1, double.NaN, 1), "Fail 11");
            Assert.Equal(1, Math.Clamp(1, 1, double.NaN), "Fail 12");
        }

        [TestMethod]
        public static void Clamp_Float()
        {
            Assert.Equal(float.NegativeInfinity, Math.Clamp(float.NegativeInfinity, float.NegativeInfinity, float.PositiveInfinity), "Fail 01");
            Assert.Equal(1, Math.Clamp(1, float.NegativeInfinity, float.PositiveInfinity), "Fail 02");
            Assert.Equal(float.PositiveInfinity, Math.Clamp(float.PositiveInfinity, float.NegativeInfinity, float.PositiveInfinity), "Fail 03");
            Assert.Equal(float.PositiveInfinity, Math.Clamp(1, float.PositiveInfinity, float.PositiveInfinity), "Fail 04");
            Assert.Equal(float.NegativeInfinity, Math.Clamp(1, float.NegativeInfinity, float.NegativeInfinity), "Fail 05");
            Assert.True(float.IsNaN(Math.Clamp(float.NaN, float.NaN, float.NaN)), "Fail 06");
            Assert.True(float.IsNaN(Math.Clamp(float.NaN, float.NaN, 1)), "Fail 07");
            Assert.True(float.IsNaN(Math.Clamp(float.NaN, 1, float.NaN)), "Fail 08");
            Assert.True(float.IsNaN(Math.Clamp(float.NaN, 1, 1)), "Fail 09");
            Assert.Equal(1, Math.Clamp(1, float.NaN, float.NaN), "Fail 10");
            Assert.Equal(1, Math.Clamp(1, float.NaN, 1), "Fail 11");
            Assert.Equal(1, Math.Clamp(1, 1, float.NaN), "Fail 12");
        }

        [TestMethod]
        public static void Clamp_MinGreaterThanMax_ThrowsArgumentException()
        {
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((sbyte)1, (sbyte)2, (sbyte)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((byte)1, (byte)2, (byte)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((short)1, (short)2, (short)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((ushort)1, (ushort)2, (ushort)1));

            // keeping cast on purpose to be able to test the method
#pragma warning disable IDE0004
#pragma warning disable S1905
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((int)1, (int)2, (int)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((uint)1, (uint)2, (uint)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((long)1, (long)2, (long)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((ulong)1, (ulong)2, (ulong)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((float)1, (float)2, (float)1));
            Assert.Throws(typeof(ArgumentException), () => Math.Clamp((double)1, (double)2, (double)1));
#pragma warning restore S1905 
#pragma warning restore IDE0004 
        }
    }
}
