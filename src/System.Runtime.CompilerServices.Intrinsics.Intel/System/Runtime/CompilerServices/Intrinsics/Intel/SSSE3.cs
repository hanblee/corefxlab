// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// SSSE3.cs
//
// A class that implements intrinsic functions to provide access to Intel SSSE3 instructions.
//
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

using System;
using System.Runtime.CompilerServices.Intrinsics;

namespace System.Runtime.CompilerServices.Intrinsics.Intel
{
    /// <summary>
    /// Provides access to Intel SSSE3 hardware instructions via intrinsics
    /// </summary>
    /// <para>
    /// SSSE3 class provides access to 128-bit SSSE3 SIMD instructions
    /// </para>

    public static class SSSE3
    {
        // __m128i _mm_abs_epi8 (__m128i a)
        public static Vector128<byte> Abs(Vector128<sbyte> value) { throw new NotImplementedException(); }
        // __m128i _mm_abs_epi16 (__m128i a)
        public static Vector128<ushort> Abs(Vector128<short> value) { throw new NotImplementedException(); }
        // __m128i _mm_abs_epi32 (__m128i a)
        public static Vector128<uint> Abs(Vector128<int> value) { throw new NotImplementedException(); }

        // __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)
        private static Vector128<sbyte> AlignRight(Vector128<sbyte> left, Vector128<sbyte> right, byte mask) { throw new NotImplementedException(); }
        public static AlignRightVector128Delegate GetAlignRightVector128Sbyte(byte mask)
        {
            return (left, right) => AlignRight(left, right, mask);
        }

        // __m128i _mm_hadd_epi16 (__m128i a, __m128i b)
        public static Vector128<short> HorizontalAdd(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }
        // __m128i _mm_hadd_epi32 (__m128i a, __m128i b)
        public static Vector128<int> HorizontalAdd(Vector128<int> left, Vector128<int> right) { throw new NotImplementedException(); }

        // __m128i _mm_hadds_epi16 (__m128i a, __m128i b)
        public static Vector128<short> HorizontalAddSaturation(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }

        // __m128i _mm_hsub_epi16 (__m128i a, __m128i b)
        public static Vector128<short> HorizontalSubtract(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }
        // __m128i _mm_hsub_epi32 (__m128i a, __m128i b)
        public static Vector128<int> HorizontalSubtract(Vector128<int> left, Vector128<int> right) { throw new NotImplementedException(); }

        // __m128i _mm_hsubs_epi16 (__m128i a, __m128i b)
        public static Vector128<short> HorizontalSubtractSaturation(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }

        // __m128i _mm_maddubs_epi16 (__m128i a, __m128i b)
        public static Vector128<short> MultiplyAddAdjacent(Vector128<byte> left, Vector128<sbyte> right) { throw new NotImplementedException(); }

        // __m128i _mm_mulhrs_epi16 (__m128i a, __m128i b)
        public static Vector128<short> MultiplyHighRoundScale(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }

        // __m128i _mm_shuffle_epi8 (__m128i a, __m128i b)
        public static Vector128<sbyte> Shuffle(Vector128<sbyte> value, Vector128<byte> mask) { throw new NotImplementedException(); }

        // __m128i _mm_sign_epi8 (__m128i a, __m128i b)
        public static Vector128<sbyte> Sign(Vector128<sbyte> left, Vector128<sbyte> right) { throw new NotImplementedException(); }
        // __m128i _mm_sign_epi16 (__m128i a, __m128i b)
        public static Vector128<short> Sign(Vector128<short> left, Vector128<short> right) { throw new NotImplementedException(); }
        // __m128i _mm_sign_epi32 (__m128i a, __m128i b)
        public static Vector128<int> Sign(Vector128<int> left, Vector128<int> right) { throw new NotImplementedException(); }
    }
}