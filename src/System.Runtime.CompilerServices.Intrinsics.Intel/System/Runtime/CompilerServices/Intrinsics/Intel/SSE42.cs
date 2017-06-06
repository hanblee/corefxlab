// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// SSE42.cs
//
// A class that implements intrinsic functions to provide access to Intel SSE4.1 instructions.
//
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices.Intrinsics;

namespace System.Runtime.CompilerServices.Intrinsics.Intel
{
    /// <summary>
    /// Provides access to Intel SSE4.2 hardware instructions via intrinsics
    /// </summary>
    /// <para>
    /// SSE42 class provides access to 128-bit SSE4.2 SIMD instructions
    /// </para>

    public static class SSE42
    {
        // int _mm_cmpistra (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrc (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistro (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrs (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrz (__m128i a, __m128i b, const int imm8)
        private static bool CompareImplicitLength(Vector128<sbyte> left, Vector128<sbyte> right, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthVector128Delegate<sbyte> GetCompareImplicitLengthVector128Sbyte(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLength(left, right, flag, mode);
        }

        // int _mm_cmpistra (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrc (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistro (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrs (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrz (__m128i a, __m128i b, const int imm8)
        private static bool CompareImplicitLength(Vector128<byte> left, Vector128<byte> right, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthVector128Delegate<byte> GetCompareImplicitLengthVector128Byte(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLength(left, right, flag, mode);
        }

        // int _mm_cmpistra (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrc (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistro (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrs (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrz (__m128i a, __m128i b, const int imm8)
        private static bool CompareImplicitLength(Vector128<short> left, Vector128<short> right, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthVector128Delegate<short> GetCompareImplicitLengthVector128Short(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLength(left, right, flag, mode);
        }

        // int _mm_cmpistra (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrc (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistro (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrs (__m128i a, __m128i b, const int imm8)
        // int _mm_cmpistrz (__m128i a, __m128i b, const int imm8)
        private static bool CompareImplicitLength(Vector128<ushort> left, Vector128<ushort> right, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthVector128Delegate<ushort> GetCompareImplicitLengthVector128Ushort(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLength(left, right, flag, mode);
        }

        // int _mm_cmpestra (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrc (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestro (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrs (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrz (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static bool CompareExplicitLength(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthVector128Delegate<sbyte> GetCompareExplicitLengthVector128Sbyte(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLength(left, leftLength, right, rightLength, flag, mode);
        }

        // int _mm_cmpestra (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrc (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestro (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrs (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrz (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static bool CompareExplicitLength(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthVector128Delegate<byte> GetCompareExplicitLengthVector128Byte(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLength(left, leftLength, right, rightLength, flag, mode);
        }

        // int _mm_cmpestra (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrc (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestro (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrs (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrz (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static bool CompareExplicitLength(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthVector128Delegate<short> GetCompareExplicitLengthVector128Short(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLength(left, leftLength, right, rightLength, flag, mode);
        }

        // int _mm_cmpestra (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrc (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestro (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrs (__m128i a, int la, __m128i b, int lb, const int imm8)
        // int _mm_cmpestrz (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static bool CompareExplicitLength(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthVector128Delegate<ushort> GetCompareExplicitLengthVector128Ushort(ResultsFlag flag, StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLength(left, leftLength, right, rightLength, flag, mode);
        }


        // int _mm_cmpistri (__m128i a, __m128i b, const int imm8)
        private static byte CompareImplicitLengthIndex(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthIndexVector128Delegate<sbyte> GetCompareImplicitLengthIndexVector128Sbyte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthIndex(left, right, mode);
        }

        // int _mm_cmpistri (__m128i a, __m128i b, const int imm8)
        private static byte CompareImplicitLengthIndex(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthIndexVector128Delegate<byte> GetCompareImplicitLengthIndexVector128Byte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthIndex(left, right, mode);
        }

        // int _mm_cmpistri (__m128i a, __m128i b, const int imm8)
        private static byte CompareImplicitLengthIndex(Vector128<short> left, Vector128<short> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthIndexVector128Delegate<short> GetCompareImplicitLengthIndexVector128Short(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthIndex(left, right, mode);
        }

        // int _mm_cmpistri (__m128i a, __m128i b, const int imm8)
        private static byte CompareImplicitLengthIndex(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthIndexVector128Delegate<ushort> GetCompareImplicitLengthIndexVector128Ushort(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthIndex(left, right, mode);
        }

        // int _mm_cmpestri (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static byte CompareExplicitLengthIndex(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthIndexVector128Delegate<sbyte> GetCompareExplicitLengthIndexVector128Sbyte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthIndex(left, leftLength, right, rightLength, mode);
        }

        // int _mm_cmpestri (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static byte CompareExplicitLengthIndex(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthIndexVector128Delegate<byte> GetCompareExplicitLengthIndexVector128Byte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthIndex(left, leftLength, right, rightLength, mode);
        }

        // int _mm_cmpestri (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static byte CompareExplicitLengthIndex(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthIndexVector128Delegate<short> GetCompareExplicitLengthIndexVector128Short(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthIndex(left, leftLength, right, rightLength, mode);
        }

        // int _mm_cmpestri (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static byte CompareExplicitLengthIndex(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthIndexVector128Delegate<ushort> GetCompareExplicitLengthIndexVector128Ushort(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthIndex(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthBitMaskVector128SbyteDelegate GetCCompareImplicitLengthBitMaskVector128Sbyte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthBitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthBitMaskVector128ByteDelegate GetCompareImplicitLengthBitMaskVector128Byte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthBitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<byte> CompareImplicitLengthBitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthBitMaskVector128ShortDelegate GetCompareImplicitLengthBitMaskVector128Short(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthBitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<byte> CompareImplicitLengthBitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthBitMaskVector128UshortDelegate GetCompareImplicitLengthBitMaskVector128Ushort(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthBitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthUnitMaskVector128SbyteDelegate GetCCompareImplicitLengthUnitMaskVector128Sbyte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthUnitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode)
        {
            throw new NotImplementedException(); 
        }
        public static CompareImplicitLengthUnitMaskVector128ByteDelegate GetCompareImplicitLengthUnitMaskVector128Byte(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthUnitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthUnitMaskVector128ShortDelegate GetCompareImplicitLengthUnitMaskVector128Short(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthUnitMask(left, right, mode);
        }

        // __m128i _mm_cmpistrm (__m128i a, __m128i b, const int imm8)
        private static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareImplicitLengthUnitMaskVector128UshortDelegate GetCompareImplicitLengthUnitMaskVector128Ushort(StringComparisonMode mode)
        {
            return (left, right) => CompareImplicitLengthUnitMask(left, right, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthBitMaskVector128SbyteDelegate GetCompareExplicitLengthBitMaskVector128Sbyte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthBitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthBitMaskVector128ByteDelegate GetCompareExplicitLengthBitMaskVector128Byte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthBitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<byte> CompareExplicitLengthBitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthBitMaskVector128ShortDelegate GetCompareExplicitLengthBitMaskVector128Short(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthBitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<byte> CompareExplicitLengthBitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthBitMaskVector128UshortDelegate GetCompareExplicitLengthBitMaskVector128Ushort(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthBitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthUnitMaskVector128SbyteDelegate GetCompareExplicitLengthUnitMaskVector128Sbyte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthUnitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthUnitMaskVector128ByteDelegate GetCompareExplicitLengthUnitMaskVector128Byte(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthUnitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthUnitMaskVector128ShortDelegate GetCompareExplicitLengthUnitMaskVector128Short(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthUnitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpestrm (__m128i a, int la, __m128i b, int lb, const int imm8)
        private static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode)
        {
            throw new NotImplementedException();
        }
        public static CompareExplicitLengthUnitMaskVector128UshortDelegate GetCompareExplicitLengthUnitMaskVector128Ushort(StringComparisonMode mode)
        {
            return (left, leftLength, right, rightLength) => CompareExplicitLengthUnitMask(left, leftLength, right, rightLength, mode);
        }

        // __m128i _mm_cmpgt_epi64 (__m128i a, __m128i b)
        public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right) { throw new NotImplementedException(); }

        // unsigned int _mm_crc32_u8 (unsigned int crc, unsigned char v)
        public static uint Crc32(uint crc, byte data) { throw new NotImplementedException(); }
        // unsigned int _mm_crc32_u16 (unsigned int crc, unsigned short v)
        public static uint Crc32(uint crc, ushort data) { throw new NotImplementedException(); }
        // unsigned int _mm_crc32_u32 (unsigned int crc, unsigned int v)
        public static uint Crc32(uint crc, uint data) { throw new NotImplementedException(); }
        // unsigned __int64 _mm_crc32_u64 (unsigned __int64 crc, unsigned __int64 v)
        public static ulong Crc32(ulong crc, ulong data) { throw new NotImplementedException(); }
    }
}