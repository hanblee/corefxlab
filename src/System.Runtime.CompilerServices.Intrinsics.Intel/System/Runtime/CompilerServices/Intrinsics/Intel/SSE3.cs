// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// SSE3.cs
//
// A class that implements intrinsic functions to provide access to Intel SSE3 instructions.
//
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

using System;
using System.Runtime.CompilerServices.Intrinsics;

namespace System.Runtime.CompilerServices.Intrinsics.Intel
{
    /// <summary>
    /// Provides access to Intel SSE3 hardware instructions via intrinsics
    /// </summary>
    /// <para>
    /// SSE3 class provides access to 128-bit SSE3 SIMD instructions
    /// </para>

    public static class SSE3
    {
        // __m128 _mm_addsub_ps (__m128 a, __m128 b)
        public static Vector128<float> AddSubtract(Vector128<float> left, Vector128<float> right) { throw new NotImplementedException(); }
        // __m128d _mm_addsub_pd (__m128d a, __m128d b)
        public static Vector128<double> AddSubtract(Vector128<double> left, Vector128<double> right) { throw new NotImplementedException(); }

        // __m128 _mm_hadd_ps (__m128 a, __m128 b)
        public static Vector128<float> HorizontalAdd(Vector128<float> left, Vector128<float> right) { throw new NotImplementedException(); }
        // __m128d _mm_hadd_pd (__m128d a, __m128d b)
        public static Vector128<double> HorizontalAdd(Vector128<double> left, Vector128<double> right) { throw new NotImplementedException(); }

        // __m128 _mm_hsub_ps (__m128 a, __m128 b)
        public static Vector128<float> HorizontalSubtract(Vector128<float> left, Vector128<float> right) { throw new NotImplementedException(); }
        // __m128d _mm_hsub_pd (__m128d a, __m128d b)
        public static Vector128<double> HorizontalSubtract(Vector128<double> left, Vector128<double> right) { throw new NotImplementedException(); }

        // __m128d _mm_loaddup_pd (double const* mem_addr)
        public static unsafe Vector128<double> LoadAndDuplicate(double* mem) { throw new NotImplementedException(); }

        // __m128i _mm_lddqu_si128 (__m128i const* mem_addr)
        public static unsafe Vector128<sbyte> LoadDqu(sbyte* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<byte> LoadDqu(byte* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<short> LoadDqu(short* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<ushort> LoadDqu(ushort* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<int> LoadDqu(int* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<uint> LoadDqu(uint* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<long> LoadDqu(long* mem) { throw new NotImplementedException(); }
        public static unsafe Vector128<ulong> LoadDqu(ulong* mem) { throw new NotImplementedException(); }

        // __m128d _mm_movedup_pd (__m128d a)
        public static Vector128<double> MoveAndDuplicate(Vector128<double> source) { throw new NotImplementedException(); }

        // __m128 _mm_movehdup_ps (__m128 a)
        public static Vector128<float> MoveHighAndDuplicate(Vector128<float> source) { throw new NotImplementedException(); }

        // __m128 _mm_moveldup_ps (__m128 a)
        public static Vector128<float> MoveLowAndDuplicate(Vector128<float> source) { throw new NotImplementedException(); }

    }
}