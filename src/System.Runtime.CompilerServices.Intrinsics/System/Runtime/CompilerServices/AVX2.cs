// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// AVX2.cs
//
// A class that implements post-SSE2 and up to AVX2 intrinsics to provide access to
// hardware instructions.
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

using System;
using System.Numerics;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Provides access to hardware instructions via intrinsics
    /// </summary>
    /// <remarks>
    /// AVX2 class provides access to some, but not all (at present), hardware instructions in the following
    /// post-SSE2 instruction sets: SSE4.2, POPCNT, LZCNT, FMA, AVX, and AVX2.
    /// </remarks>
    /// <para>
    /// The list of intrinsics provided is not complete at present. The intent is:
    /// * to have 1:1 mapping with C/C++ intrinsic API
    ///   (an API will have C/C++ equivalent as a comment above it, and by having 1:1 
    ///   correspondence with C/C++ intrinsics, we leverage their existing documentation)
    /// * to capture all post-SSE2 intrinsics that deal with __m256 type
    /// * to capture post-SSE2 intrinsics that deal with non-packed basic types
    /// </para>
    /// <para>
    /// The current list does NOT at present capture:
    /// * intrinsics that deal with __m128 types since it does not map well to Vector<T>
    ///   (e.g., __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8))
    /// * intrinsics that deal with pointer types
    /// </para>
    /// <para>
    /// Some of the AVX2 intrinsics may provide functionality that overlaps with existing Vector<T>
    /// intrinsics (e.g., Add()) but which should provide with additional flexibility to the developer.
    /// </para>
    /// <para>
    /// NOTE: AVX2 instruction set may not guarantee that other processor capabilities are present.
    /// The JIT can internally check processor capability using CPUID to see if an instruction is
    /// not supported and generate non-accelerated code for that intrinsic (this should be  rare).
    /// Another option is to expose CPUID flags directly to the developer so that finer level
    /// processor capabilities can be queried.
    /// </para>

    public static class AVX2
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // AVX/AVX2 intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // __m256i _mm256_abs_epi8 (__m256i a)
        public static Vector<byte> Abs(Vector<sbyte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_abs_epi16 (__m256i a)
        public static Vector<ushort> Abs(Vector<short> a) { throw new NotImplementedException(); }
        // __m256i _mm256_abs_epi32 (__m256i a)
        public static Vector<uint> Abs(Vector<int> a) { throw new NotImplementedException(); }

        // __m256i _mm256_add_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Add(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi8 (__m256i a, __m256i b)
        public static Vector<byte> Add(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi16 (__m256i a, __m256i b)
        public static Vector<short> Add(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi16 (__m256i a, __m256i b)
        public static Vector<ushort> Add(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi32 (__m256i a, __m256i b)
        public static Vector<int> Add(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi32 (__m256i a, __m256i b)
        public static Vector<uint> Add(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi64 (__m256i a, __m256i b)
        public static Vector<long> Add(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_add_epi64 (__m256i a, __m256i b)
        public static Vector<ulong> Add(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_add_ps (__m256 a, __m256 b)
        public static Vector<float> Add(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_add_pd (__m256d a, __m256d b)
        public static Vector<double> Add(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_adds_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> AddWithSignedSaturation(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_adds_epi16 (__m256i a, __m256i b)
        public static Vector<short> AddWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_adds_epu8 (__m256i a, __m256i b)
        public static Vector<byte> AddWithUnsignedSaturation(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_adds_epu16 (__m256i a, __m256i b)
        public static Vector<ushort> AddWithUnsignedSaturation(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m256 _mm256_addsub_ps (__m256 a, __m256 b)
        public static Vector<float> AddSub(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_addsub_pd (__m256d a, __m256d b)
        public static Vector<double> AddSub(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)
        public static Vector<sbyte> AlignRight(Vector<sbyte> a, Vector<sbyte> b, int count) { throw new NotImplementedException(); }

        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<sbyte> And(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<byte> And(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<short> And(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<ushort> And(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<int> And(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<uint> And(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<long> And(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_and_si256 (__m256i a, __m256i b)
        public static Vector<ulong> And(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_and_ps (__m256 a, __m256 b)
        public static Vector<float> And(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_and_pd (__m256d a, __m256d b)
        public static Vector<double> And(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<sbyte> AndNot(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<byte> AndNot(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<short> AndNot(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<ushort> AndNot(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<int> AndNot(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<uint> AndNot(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<long> AndNot(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
        public static Vector<ulong> AndNot(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_andnot_ps (__m256 a, __m256 b)
        public static Vector<float> AndNot(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_andnot_pd (__m256d a, __m256d b)
        public static Vector<double> AndNot(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_avg_epu8 (__m256i a, __m256i b)
        public static Vector<byte> Average(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_avg_epu16 (__m256i a, __m256i b)
        public static Vector<ushort> Average(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8)
        public static Vector<short> Blend(Vector<short> a, Vector<short> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8)
        public static Vector<ushort> Blend(Vector<ushort> a, Vector<ushort> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)
        public static Vector<int> Blend(Vector<int> a, Vector<int> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)
        public static Vector<uint> Blend(Vector<uint> a, Vector<uint> b, byte select) { throw new NotImplementedException(); }
        // __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8)
        public static Vector<float> Blend(Vector<float> a, Vector<float> b, byte select) { throw new NotImplementedException(); }
        // __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8)
        public static Vector<double> Blend(Vector<double> a, Vector<double> b, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask)
        public static Vector<sbyte> BlendVariable(Vector<sbyte> a, Vector<sbyte> b, Vector<byte> mask) { throw new NotImplementedException(); }
        // __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask)
        public static Vector<byte> BlendVariable(Vector<byte> a, Vector<byte> b, Vector<byte> mask) { throw new NotImplementedException(); }
        // __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask)
        public static Vector<float> BlendVariable(Vector<float> a, Vector<float> b, Vector<uint> mask) { throw new NotImplementedException(); }
        // __m256d _mm256_blendv_pd (__m256d a, __m256d b, __m256d mask)
        public static Vector<double> BlendVariable(Vector<double> a, Vector<double> b, Vector<ulong> mask) { throw new NotImplementedException(); }

        // __m256 _mm256_ceil_ps (__m256 a)
        public static Vector<float> Ceiling(Vector<float> a) { throw new NotImplementedException(); }
        // __m256d _mm256_ceil_pd (__m256d a)
        public static Vector<double> Ceiling(Vector<double> a) { throw new NotImplementedException(); }

        // __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8)
        public static Vector<float> Compare(Vector<float> a, Vector<float> b, ComparisonMode mode) { throw new NotImplementedException(); }
        // __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8)
        public static Vector<double> Compare(Vector<double> a, Vector<double> b, ComparisonMode mode) { throw new NotImplementedException(); }

        // __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> CompareEqual(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b)
        public static Vector<byte> CompareEqual(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b)
        public static Vector<short> CompareEqual(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b)
        public static Vector<ushort> CompareEqual(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b)
        public static Vector<int> CompareEqual(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b)
        public static Vector<uint> CompareEqual(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b)
        public static Vector<long> CompareEqual(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b)
        public static Vector<ulong> CompareEqual(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        
        // __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> CompareGreaterThan(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpgt_epi16 (__m256i a, __m256i b)
        public static Vector<short> CompareGreaterThan(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b)
        public static Vector<int> CompareGreaterThan(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b)
        public static Vector<long> CompareGreaterThan(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }

        // __m256i _mm256_cvtepi8_epi16 (__m128i a)
        public static Vector<short> ConvertToShort(Vector<sbyte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu8_epi16 (__m128i a)
        public static Vector<short> ConvertToShort(Vector<byte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepi8_epi32 (__m128i a)
        public static Vector<int> ConvertToInt(Vector<sbyte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu8_epi32 (__m128i a)
        public static Vector<int> ConvertToInt(Vector<byte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepi16_epi32 (__m128i a)
        public static Vector<int> ConvertToInt(Vector<short> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu16_epi32 (__m128i a)
        public static Vector<int> ConvertToInt(Vector<ushort> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtps_epi32 (__m256 a)
        public static Vector<int> ConvertToInt(Vector<float> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepi8_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<sbyte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu8_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<byte> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepi16_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<short> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu16_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<ushort> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepi32_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<int> a) { throw new NotImplementedException(); }
        // __m256i _mm256_cvtepu32_epi64 (__m128i a)
        public static Vector<long> ConvertToLong(Vector<uint> a) { throw new NotImplementedException(); }
        // __m256 _mm256_cvtepi32_ps (__m256i a)
        public static Vector<float> ConvertToFloat(Vector<int> a) { throw new NotImplementedException(); }
        // __m256d _mm256_cvtepi32_pd (__m128i a)
        public static Vector<double> ConvertToDouble(Vector<int> a) { throw new NotImplementedException(); }
        // __m256d _mm256_cvtps_pd (__m128 a)
        public static Vector<double> ConvertToDouble(Vector<float> a) { throw new NotImplementedException(); }

        // __m256i _mm256_cvttps_epi32 (__m256 a)
        public static Vector<int> ConvertToIntWithTruncation(Vector<float> a) { throw new NotImplementedException(); }

        // __m256 _mm256_div_ps (__m256 a, __m256 b)
        public static Vector<float> Divide(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_div_pd (__m256d a, __m256d b)
        public static Vector<double> Divide(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8)
        public static Vector<float> DotProduct(Vector<float> a, Vector<float> b, byte select) { throw new NotImplementedException(); }

        // __m256 _mm256_movehdup_ps (__m256 a)
        public static Vector<float> DuplicateEvenIndexed(Vector<float> a) { throw new NotImplementedException(); }
        // __m256d _mm256_movedup_pd (__m256d a)
        public static Vector<double> DuplicateEvenIndexed(Vector<double> a) { throw new NotImplementedException(); }

        // __m256 _mm256_movehdup_ps (__m256 a)
        public static Vector<float> DuplicateOddIndexed(Vector<float> a) { throw new NotImplementedException(); }

        // __int8 _mm256_extract_epi8 (__m256i a, const int index)
        public static sbyte Extract(Vector<sbyte> a, byte select) { throw new NotImplementedException(); }
        // __int8 _mm256_extract_epi8 (__m256i a, const int index)
        public static byte Extract(Vector<byte> a, byte select) { throw new NotImplementedException(); }
        // __int16 _mm256_extract_epi16 (__m256i a, const int index)
        public static short Extract(Vector<short> a, byte select) { throw new NotImplementedException(); }
        // __int16 _mm256_extract_epi16 (__m256i a, const int index)
        public static ushort Extract(Vector<ushort> a, byte select) { throw new NotImplementedException(); }
        // __int32 _mm256_extract_epi32 (__m256i a, const int index)
        public static int Extract(Vector<int> a, byte select) { throw new NotImplementedException(); }
        // __int32 _mm256_extract_epi32 (__m256i a, const int index)
        public static uint Extract(Vector<uint> a, byte select) { throw new NotImplementedException(); }
        // __int64 _mm256_extract_epi64 (__m256i a, const int index)
        public static long Extract(Vector<long> a, byte select) { throw new NotImplementedException(); }
        // __int64 _mm256_extract_epi64 (__m256i a, const int index)
        public static ulong Extract(Vector<ulong> a, byte select) { throw new NotImplementedException(); }

        // __m256 _mm256_floor_ps (__m256 a)
        public static Vector<float> Floor(Vector<float> a) { throw new NotImplementedException(); }
        // __m256d _mm256_floor_pd (__m256d a)
        public static Vector<double> Floor(Vector<double> a) { throw new NotImplementedException(); }

        // __m256i _mm256_hadd_epi16 (__m256i a, __m256i b)
        public static Vector<short> HorizontalAdd(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_hadd_epi32 (__m256i a, __m256i b)
        public static Vector<int> HorizontalAdd(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256 _mm256_hadd_ps (__m256 a, __m256 b)
        public static Vector<float> HorizontalAdd(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_hadd_pd (__m256d a, __m256d b)
        public static Vector<double> HorizontalAdd(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_hadds_epi16 (__m256i a, __m256i b)
        public static Vector<short> HorizontalAddWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_hsub_epi16 (__m256i a, __m256i b)
        public static Vector<short> HorizontalSubtract(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_hsub_epi32 (__m256i a, __m256i b)
        public static Vector<int> HorizontalSubtract(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256 _mm256_hsub_ps (__m256 a, __m256 b)
        public static Vector<float> HorizontalSubtract(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_hsub_pd (__m256d a, __m256d b)
        public static Vector<double> HorizontalSubtract(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_hsubs_epi16 (__m256i a, __m256i b)
        public static Vector<short> HorizontalSubtractWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_insert_epi8 (__m256i a, __int8 i, const int index)
        public static Vector<sbyte> Insert(Vector<sbyte> a, sbyte data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi8 (__m256i a, __int8 i, const int index)
        public static Vector<byte> Insert(Vector<byte> a, byte data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi16 (__m256i a, __int16 i, const int index)
        public static Vector<short> Insert(Vector<short> a, short data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi16 (__m256i a, __int16 i, const int index)
        public static Vector<ushort> Insert(Vector<ushort> a, ushort data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi32 (__m256i a, __int32 i, const int index)
        public static Vector<int> Insert(Vector<int> a, int data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi32 (__m256i a, __int32 i, const int index)
        public static Vector<uint> Insert(Vector<uint> a, uint data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi64 (__m256i a, __int64 i, const int index)
        public static Vector<long> Insert(Vector<long> a, long data, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_insert_epi64 (__m256i a, __int64 i, const int index)
        public static Vector<ulong> Insert(Vector<ulong> a, ulong data, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_madd_epi16 (__m256i a, __m256i b)
        public static Vector<int> MultiplyAddAdjacent(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_maddubs_epi16 (__m256i a, __m256i b)
        public static Vector<short> MultiplyAddAdjacent(Vector<byte> a, Vector<sbyte> b) { throw new NotImplementedException(); }

        // __m256i _mm256_max_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Max(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_max_epu8 (__m256i a, __m256i b)
        public static Vector<short> Max(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_max_epi16 (__m256i a, __m256i b)
        public static Vector<int> Max(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_max_epu16 (__m256i a, __m256i b)
        public static Vector<float> Max(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256i _mm256_max_epi32 (__m256i a, __m256i b)
        public static Vector<double> Max(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        // __m256i _mm256_max_epu32 (__m256i a, __m256i b)
        public static Vector<byte> Max(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256 _mm256_max_ps (__m256 a, __m256 b)
        public static Vector<ushort> Max(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256d _mm256_max_pd (__m256d a, __m256d b)
        public static Vector<uint> Max(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        
        // __m256i _mm256_min_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Min(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_min_epu8 (__m256i a, __m256i b)
        public static Vector<short> Min(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_min_epi16 (__m256i a, __m256i b)
        public static Vector<int> Min(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_min_epu16 (__m256i a, __m256i b)
        public static Vector<float> Min(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256i _mm256_min_epi32 (__m256i a, __m256i b)
        public static Vector<double> Min(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        // __m256i _mm256_min_epu32 (__m256i a, __m256i b)
        public static Vector<byte> Min(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256 _mm256_min_ps (__m256 a, __m256 b)
        public static Vector<ushort> Min(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256d _mm256_min_pd (__m256d a, __m256d b)
        public static Vector<uint> Min(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        
        // int _mm256_movemask_epi8 (__m256i a)
        public static int MoveMask(Vector<sbyte> a) { throw new NotImplementedException(); }
        // int _mm256_movemask_epi8 (__m256i a)
        public static int MoveMask(Vector<byte> a) { throw new NotImplementedException(); }
        // int _mm256_movemask_ps (__m256 a)
        public static int MoveMask(Vector<float> a) { throw new NotImplementedException(); }
        // int _mm256_movemask_pd (__m256d a)
        public static int MoveMask(Vector<double> a) { throw new NotImplementedException(); }

        // __m256i _mm256_mpsadbw_epu8 (__m256i a, __m256i b, const int imm8)
        public static Vector<ushort> MultipleSumAbsoluteDifference(Vector<byte> a, Vector<byte> b, byte select) { throw new NotImplementedException(); }
        
        // __m256i _mm256_mul_epi32 (__m256i a, __m256i b)
        public static Vector<long> Multiply(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_mul_epu32 (__m256i a, __m256i b)
        public static Vector<ulong> Multiply(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256 _mm256_mul_ps (__m256 a, __m256 b)
        public static Vector<float> Multiply(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_mul_pd (__m256d a, __m256d b)
        public static Vector<double> Multiply(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_mulhi_epi16 (__m256i a, __m256i b)
        public static Vector<short> MultiplyHigh(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_mulhi_epu16 (__m256i a, __m256i b)
        public static Vector<ushort> MultiplyHigh(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b)
        public static Vector<short> MultiplyHighRoundScale(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_mullo_epi16 (__m256i a, __m256i b)
        public static Vector<short> MultiplyLow(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_mullo_epu16 (__m256i a, __m256i b)
        public static Vector<int> MultiplyLow(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }

        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<sbyte> Or(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<byte> Or(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<short> Or(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<ushort> Or(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<int> Or(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<uint> Or(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<long> Or(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_or_si256 (__m256i a, __m256i b)
        public static Vector<ulong> Or(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_or_ps (__m256 a, __m256 b)
        public static Vector<float> Or(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_or_pd (__m256d a, __m256d b)
        public static Vector<double> Or(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_packs_epi16 (__m256i a, __m256i b)
        public static Vector<sbyte> PackWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_packs_epi32 (__m256i a, __m256i b)
        public static Vector<short> PackWithSignedSaturation(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }

        // __m256i _mm256_packus_epi16 (__m256i a, __m256i b)
        public static Vector<byte> PackWithUnsignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_packus_epi32 (__m256i a, __m256i b)
        public static Vector<ushort> PackWithUnsignedSaturation(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }

        // __m256 _mm256_permute_ps (__m256 a, int imm8)
        public static Vector<float> Permute(Vector<float> a, byte select) { throw new NotImplementedException(); }
        // __m256d _mm256_permute_pd (__m256d a, int imm8)
        public static Vector<double> Permute(Vector<double> a, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<sbyte> Permute2x128(Vector<sbyte> a, Vector<sbyte> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<byte> Permute2x128(Vector<byte> a, Vector<byte> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<short> Permute2x128(Vector<short> a, Vector<short> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<ushort> Permute2x128(Vector<ushort> a, Vector<ushort> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<int> Permute2x128(Vector<int> a, Vector<int> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<uint> Permute2x128(Vector<uint> a, Vector<uint> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<long> Permute2x128(Vector<long> a, Vector<long> b, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8)
        public static Vector<ulong> Permute2x128(Vector<ulong> a, Vector<ulong> b, byte select) { throw new NotImplementedException(); }
        // __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8)
        public static Vector<float> Permute2x128(Vector<float> a, Vector<float> b, byte select) { throw new NotImplementedException(); }
        // __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8)
        public static Vector<double> Permute2x128(Vector<double> a, Vector<double> b, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)
        public static Vector<long> Permute4x64(Vector<long> a, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)
        public static Vector<ulong> Permute4x64(Vector<ulong> a, byte select) { throw new NotImplementedException(); }
        // __m256d _mm256_permute4x64_pd (__m256d a, const int imm8)
        public static Vector<double> Permute4x64(Vector<double> a, byte select) { throw new NotImplementedException(); }
        
        // __m256 _mm256_permutevar_ps (__m256 a, __m256i b)
        public static Vector<float> PermuteVar(Vector<float> a, Vector<uint> mask) { throw new NotImplementedException(); }
        // __m256d _mm256_permutevar_pd (__m256d a, __m256i b)
        public static Vector<double> PermuteVar(Vector<double> a, Vector<ulong> mask) { throw new NotImplementedException(); }

        // __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)
        public static Vector<int> PermuteVar8x32(Vector<int> a, Vector<uint> mask) { throw new NotImplementedException(); }
        // __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)
        public static Vector<uint> PermuteVar8x32(Vector<uint> a, Vector<uint> mask) { throw new NotImplementedException(); }
        // __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)
        public static Vector<float> PermuteVar8x32(Vector<float> a, Vector<uint> mask) { throw new NotImplementedException(); }
        
        // __m256 _mm256_rcp_ps (__m256 a)
        public static Vector<float> Reciprocal(Vector<float> a) { throw new NotImplementedException(); }

        // __m256 _mm256_round_ps (__m256 a, int rounding)
        public static Vector<float> Round(Vector<float> a, RoundMode mode) { throw new NotImplementedException(); }
        // __m256d _mm256_round_pd (__m256d a, int rounding)
        public static Vector<double> Round(Vector<double> a, RoundMode mode) { throw new NotImplementedException(); }

        // __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Shuffle(Vector<sbyte> a, Vector<byte> mask) { throw new NotImplementedException(); }
        // __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b)
        public static Vector<byte> Shuffle(Vector<byte> a, Vector<byte> mask) { throw new NotImplementedException(); }
        // __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8)
        public static Vector<int> Shuffle(Vector<int> a, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8)
        public static Vector<uint> Shuffle(Vector<uint> a, byte select) { throw new NotImplementedException(); }
        // __m256 _mm256_shuffle_ps (__m256 a, __m256 b, const int imm8)
        public static Vector<float> Shuffle(Vector<float> a, Vector<float> b, byte select) { throw new NotImplementedException(); }
        // __m256d _mm256_shuffle_pd (__m256d a, __m256d b, const int imm8)
        public static Vector<double> Shuffle(Vector<double> a, Vector<double> b, byte select) { throw new NotImplementedException(); }
 
        // __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)
        public static Vector<short> ShuffleHigh(Vector<short> a, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8)
        public static Vector<ushort> ShuffleHigh(Vector<ushort> a, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)
        public static Vector<short> ShuffleLow(Vector<short> a, byte select) { throw new NotImplementedException(); }
        // __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8)
        public static Vector<ushort> ShuffleLow(Vector<ushort> a, byte select) { throw new NotImplementedException(); }

        // __m256i _mm256_sign_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Sign(Vector<sbyte> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sign_epi16 (__m256i a, __m256i b)
        public static Vector<short> Sign(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sign_epi32 (__m256i a, __m256i b)
        public static Vector<int> Sign(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
    
        // __m256i _mm256_slli_epi16 (__m256i a, int imm8)
        public static Vector<short> ShiftLeftLogical(Vector<short> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_slli_epi16 (__m256i a, int imm8)
        public static Vector<ushort> ShiftLeftLogical(Vector<ushort> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_slli_epi32 (__m256i a, int imm8)
        public static Vector<int> ShiftLeftLogical(Vector<int> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_slli_epi32 (__m256i a, int imm8)
        public static Vector<uint> ShiftLeftLogical(Vector<uint> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_slli_epi64 (__m256i a, int imm8)
        public static Vector<long> ShiftLeftLogical(Vector<long> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_slli_epi64 (__m256i a, int imm8)
        public static Vector<ulong> ShiftLeftLogical(Vector<ulong> a, byte count) { throw new NotImplementedException(); }
        
        // __m256i _mm256_sllv_epi32 (__m256i a, __m256i count)
        public static Vector<int> ShiftLeftLogicalVariable(Vector<int> a, Vector<uint> count) { throw new NotImplementedException(); }
        // __m256i _mm256_sllv_epi32 (__m256i a, __m256i count)
        public static Vector<uint> ShiftLeftLogicalVariable(Vector<uint> a, Vector<uint> count) { throw new NotImplementedException(); }
        // __m256i _mm256_sllv_epi64 (__m256i a, __m256i count)
        public static Vector<long> ShiftLeftLogicalVariable(Vector<long> a, Vector<ulong> count) { throw new NotImplementedException(); }
        // __m256i _mm256_sllv_epi64 (__m256i a, __m256i count)
        public static Vector<ulong> ShiftLeftLogicalVariable(Vector<ulong> a, Vector<ulong> count) { throw new NotImplementedException(); }
        
        // __m256i _mm256_srai_epi16 (__m256i a, int imm8)
        public static Vector<short> ShiftRightArithmetic(Vector<short> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srai_epi32 (__m256i a, int imm8)
        public static Vector<int> ShiftRightArithmetic(Vector<int> a, byte count) { throw new NotImplementedException(); }
        
        // __m256i _mm256_srav_epi32 (__m256i a, __m256i count)
        public static Vector<int> ShiftRightArithmeticVariable(Vector<int> a, Vector<uint> count) { throw new NotImplementedException(); }

        // __m256i _mm256_srli_epi16 (__m256i a, int imm8)
        public static Vector<short> ShiftRightLogical(Vector<short> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srli_epi16 (__m256i a, int imm8)
        public static Vector<ushort> ShiftRightLogical(Vector<ushort> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srli_epi32 (__m256i a, int imm8)
        public static Vector<int> ShiftRightLogical(Vector<int> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srli_epi32 (__m256i a, int imm8)
        public static Vector<uint> ShiftRightLogical(Vector<uint> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srli_epi64 (__m256i a, int imm8)
        public static Vector<long> ShiftRightLogical(Vector<long> a, byte count) { throw new NotImplementedException(); }
        // __m256i _mm256_srli_epi64 (__m256i a, int imm8)
        public static Vector<ulong> ShiftRightLogical(Vector<ulong> a, byte count) { throw new NotImplementedException(); }
        
        // __m256i _mm256_srlv_epi32 (__m256i a, __m256i count)
        public static Vector<int> ShiftRightLogicalVariable(Vector<int> a, Vector<uint> count) { throw new NotImplementedException(); }
        // __m256i _mm256_srlv_epi32 (__m256i a, __m256i count)
        public static Vector<uint> ShiftRightLogicalVariable(Vector<uint> a, Vector<uint> count) { throw new NotImplementedException(); }
        // __m256i _mm256_srlv_epi64 (__m256i a, __m256i count)
        public static Vector<long> ShiftRightLogicalVariable(Vector<long> a, Vector<ulong> count) { throw new NotImplementedException(); }
        // __m256i _mm256_srlv_epi64 (__m256i a, __m256i count)
        public static Vector<ulong> ShiftRightLogicalVariable(Vector<ulong> a, Vector<ulong> count) { throw new NotImplementedException(); }

        // __m256 _mm256_sqrt_ps (__m256 a)
        public static Vector<float> Sqrt(Vector<float> a) { throw new NotImplementedException(); }
        // __m256d _mm256_sqrt_pd (__m256d a)
        public static Vector<double> Sqrt(Vector<double> a) { throw new NotImplementedException(); }

        // __m256i _mm256_sub_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> Subtract(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi8 (__m256i a, __m256i b)
        public static Vector<byte> Subtract(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi16 (__m256i a, __m256i b)
        public static Vector<short> Subtract(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi16 (__m256i a, __m256i b)
        public static Vector<ushort> Subtract(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi32 (__m256i a, __m256i b)
        public static Vector<int> Subtract(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi32 (__m256i a, __m256i b)
        public static Vector<uint> Subtract(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi64 (__m256i a, __m256i b)
        public static Vector<long> Subtract(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_sub_epi64 (__m256i a, __m256i b)
        public static Vector<ulong> Subtract(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_sub_ps (__m256 a, __m256 b)
        public static Vector<float> Subtract(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_sub_pd (__m256d a, __m256d b)
        public static Vector<double> Subtract(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m256i _mm256_subs_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> SubtractWithSignedSaturation(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_subs_epi16 (__m256i a, __m256i b)
        public static Vector<short> SubtractWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m256i _mm256_subs_epu8 (__m256i a, __m256i b)
        public static Vector<byte> SubtractWithUnsignedSaturation(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_subs_epu16 (__m256i a, __m256i b)
        public static Vector<ushort> SubtractWithUnsignedSaturation(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m256i _mm256_sad_epu8 (__m256i a, __m256i b)
        public static Vector<ulong> SumAbsoluteDifference(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }

        // __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> UnpackHigh(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b)
        public static Vector<byte> UnpackHigh(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b)
        public static Vector<short> UnpackHigh(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b)
        public static Vector<ushort> UnpackHigh(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b)
        public static Vector<int> UnpackHigh(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b)
        public static Vector<uint> UnpackHigh(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b)
        public static Vector<long> UnpackHigh(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b)
        public static Vector<ulong> UnpackHigh(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_unpackhi_ps (__m256 a, __m256 b)
        public static Vector<float> UnpackHigh(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_unpackhi_pd (__m256d a, __m256d b)
        public static Vector<double> UnpackHigh(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        
        // __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b)
        public static Vector<sbyte> UnpackLow(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b)
        public static Vector<byte> UnpackLow(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b)
        public static Vector<short> UnpackLow(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b)
        public static Vector<ushort> UnpackLow(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b)
        public static Vector<int> UnpackLow(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b)
        public static Vector<uint> UnpackLow(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b)
        public static Vector<long> UnpackLow(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b)
        public static Vector<ulong> UnpackLow(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_unpacklo_ps (__m256 a, __m256 b)
        public static Vector<float> UnpackLow(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_unpacklo_pd (__m256d a, __m256d b)
        public static Vector<double> UnpackLow(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<sbyte> Xor(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<byte> Xor(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<short> Xor(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<ushort> Xor(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<int> Xor(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<uint> Xor(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<long> Xor(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m256i _mm256_xor_si256 (__m256i a, __m256i b)
        public static Vector<ulong> Xor(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m256 _mm256_xor_ps (__m256 a, __m256 b)
        public static Vector<float> Xor(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m256d _mm256_xor_pd (__m256d a, __m256d b)
        public static Vector<double> Xor(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // void _mm256_zeroall (void)
        public static void ZeroAll() { throw new NotImplementedException(); }
        // void _mm256_zeroupper (void)
        public static void ZeroUpper() { throw new NotImplementedException(); }

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // FMA intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // __m256 _mm256_fmadd_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplyAdd(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fmadd_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplyAdd(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // __m256 _mm256_fmaddsub_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplyAddSubtract(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fmaddsub_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplyAddSubtract(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // __m256 _mm256_fmsub_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplySubtract(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fmsub_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplySubtract(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // __m256 _mm256_fmsubadd_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplySubtractAdd(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fmsubadd_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplySubtractAdd(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // __m256 _mm256_fnmadd_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplyAddNegated(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fnmadd_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplyAddNegated(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // __m256 _mm256_fnmsub_ps (__m256 a, __m256 b, __m256 c)
        public static Vector<float> MultiplySubtractNegated(Vector<float> a, Vector<float> b, Vector<float> c) { throw new NotImplementedException(); }
        // __m256d _mm256_fnmsub_pd (__m256d a, __m256d b, __m256d c)
        public static Vector<double> MultiplySubtractNegated(Vector<double> a, Vector<double> b, Vector<double> c) { throw new NotImplementedException(); }

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // SSE4.2 intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // unsigned int _mm_crc32_u8 (unsigned int crc, unsigned char v)
        public static uint Crc32(uint crc, byte data) { throw new NotImplementedException(); }
        // unsigned int _mm_crc32_u16 (unsigned int crc, unsigned short v)
        public static uint Crc32(uint crc, ushort data) { throw new NotImplementedException(); }
        // unsigned int _mm_crc32_u32 (unsigned int crc, unsigned int v)
        public static uint Crc32(uint crc, uint data) { throw new NotImplementedException(); }
        // unsigned __int64 _mm_crc32_u64 (unsigned __int64 crc, unsigned __int64 v)
        public static ulong Crc32(ulong crc, ulong data) { throw new NotImplementedException(); }

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // LZCNT intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // unsigned int _lzcnt_u32 (unsigned int a)
        public static uint LeadingZeroCount(uint a) { throw new NotImplementedException(); }
        // unsigned __int64 _lzcnt_u64 (unsigned __int64 a)
        public static ulong LeadingZeroCount(ulong a) { throw new NotImplementedException(); }

        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // POPCNT intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // int _mm_popcnt_u32 (unsigned int a)
        public static int PopCount(uint a) { throw new NotImplementedException(); }
        // __int64 _mm_popcnt_u64 (unsigned __int64 a)
        public static long PopCount(ulong a) { throw new NotImplementedException(); }
        
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // BMI1 intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // int _mm_tzcnt_32 (unsigned int a)
        public static int TrailingZeroCount(uint a) { throw new NotImplementedException(); }
        // __int64 _mm_tzcnt_64 (unsigned __int64 a)
        public static long TrailingZeroCount(ulong a) { throw new NotImplementedException(); }
    }
}