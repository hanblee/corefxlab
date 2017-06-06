// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// SSE2.cs
//
// A class that implements SSE2 hardware intrinsics to provide access to hardware instructions.
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

using System;
using System.Numerics;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Provides access to SSE2 hardware instructions via intrinsics
    /// </summary>
    /// <remarks>
    /// SSE2 class provides access to some, but not all (at present), hardware instructions in 
    /// SSE2 instruction set.
    /// </remarks>
    /// <para>
    /// The list of intrinsics provided is not complete at present. The intent is:
    /// * to have 1:1 mapping with C/C++ intrinsic API
    ///   (an API will have C/C++ equivalent as a comment above it, anb by having 1:1 
    ///   correspondence with C/C++ intrinsics, we leverage their existing documentation.)
    /// * to capture all SSE2 intrinsics that deal with __m128 type
    /// </para>
    /// <para>
    /// The current list does NOT at present capture:
    /// * intrinsics that deal with __m64 types since it does not map well to Vector<T>
    /// * intrinsics that deal with pointer types
    /// </para>
    /// <para>
    /// Some of the SSE2 intrinsics may provide functionality that overlaps with existing Vector<T>
    /// intrinsics (e.g., Add()) but which should provide with additional flexibility to the developer.
    ///  
    /// </para>

    public static class SSE2
    {
        // __m128i _mm_add_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> Add(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi8 (__m128i a, __m128i b)
        public static Vector<byte> Add(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi16 (__m128i a, __m128i b)
        public static Vector<short> Add(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi16 (__m128i a, __m128i b)
        public static Vector<ushort> Add(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi32 (__m128i a, __m128i b)
        public static Vector<int> Add(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi32 (__m128i a, __m128i b)
        public static Vector<uint> Add(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi64 (__m128i a, __m128i b)
        public static Vector<long> Add(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_add_epi64 (__m128i a, __m128i b)
        public static Vector<ulong> Add(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128d _mm_add_pd (__m128d a, __m128d b)
        public static Vector<double> Add(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_adds_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> AddSaturation(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_adds_epu8 (__m128i a, __m128i b)
        public static Vector<byte> AddSaturation(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_adds_epi16 (__m128i a, __m128i b)
        public static Vector<short> AddSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_adds_epu16 (__m128i a, __m128i b)
        public static Vector<ushort> AddSaturation(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<sbyte> And(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<byte> And(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<short> And(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<ushort> And(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<int> And(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<uint> And(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<long> And(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_and_si128 (__m128i a, __m128i b)
        public static Vector<ulong> And(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_and_ps (__m128 a, __m128 b)
        public static Vector<float> And(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_and_pd (__m128d a, __m128d b)
        public static Vector<double> And(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<sbyte> AndNot(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<byte> AndNot(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<short> AndNot(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<ushort> AndNot(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<int> AndNot(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<uint> AndNot(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<long> AndNot(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_andnot_si128 (__m128i a, __m128i b)
        public static Vector<ulong> AndNot(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_andnot_ps (__m128 a, __m128 b)
        public static Vector<float> AndNot(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_andnot_pd (__m128d a, __m128d b)
        public static Vector<double> AndNot(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_avg_epu8 (__m128i a, __m128i b)
        public static Vector<byte> Average(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_avg_epu16 (__m128i a, __m128i b)
        public static Vector<ushort> Average(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> CompareEqual(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b)
        public static Vector<byte> CompareEqual(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b)
        public static Vector<short> CompareEqual(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b)
        public static Vector<ushort> CompareEqual(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b)
        public static Vector<int> CompareEqual(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b)
        public static Vector<uint> CompareEqual(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128 _mm_cmpeq_ps (__m128 a, __m128 b)
        public static Vector<float> CompareEqual(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_cmpeq_pd (__m128d a, __m128d b)
        public static Vector<double> CompareEqual(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_cmpgt_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> CompareGreaterThan(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpgt_epi16 (__m128i a, __m128i b)
        public static Vector<short> CompareGreaterThan(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_cmpgt_epi32 (__m128i a, __m128i b)
        public static Vector<int> CompareGreaterThan(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128 _mm_cmpgt_ps (__m128 a, __m128 b)
        public static Vector<float> CompareGreaterThan(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_cmpgt_pd (__m128d a, __m128d b)
        public static Vector<double> CompareGreaterThan(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_cvtps_epi32 (__m128 a)
        public static Vector<int> ConvertToInt(Vector<float> a) { throw new NotImplementedException(); }
        // __m128i _mm_cvtpd_epi32 (__m128d a)
        public static Vector<int> ConvertToInt(Vector<double> a) { throw new NotImplementedException(); }
        // __m128 _mm_cvtepi32_ps (__m128i a)
        public static Vector<float> ConvertToFloat(Vector<int> a) { throw new NotImplementedException(); }
        // __m128 _mm_cvtpd_ps (__m128d a)
        public static Vector<float> ConvertToFloat(Vector<double> a) { throw new NotImplementedException(); }
        // __m128d _mm_cvtepi32_pd (__m128i a)
        public static Vector<double> ConvertToDouble(Vector<int> a) { throw new NotImplementedException(); }
        // __m128d _mm_cvtps_pd (__m128 a)
        public static Vector<double> ConvertToDouble(Vector<float> a) { throw new NotImplementedException(); }

        // __m128i _mm_cvttps_epi32 (__m128 a)
        public static Vector<int> ConvertToIntWithTruncation(Vector<float> a) { throw new NotImplementedException(); }
        // __m128i _mm_cvttpd_epi32 (__m128d a)
        public static Vector<int> ConvertToIntWithTruncation(Vector<double> a) { throw new NotImplementedException(); }

        // __m128 _mm_div_ps (__m128 a, __m128 b)
        public static Vector<float> Divide(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_div_pd (__m128d a, __m128d b)
        public static Vector<double> Divide(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // int _mm_extract_epi16 (__m128i a, int imm8)
        public static short Extract(Vector<short> a, uint select) { throw new NotImplementedException(); }
        // int _mm_extract_epi16 (__m128i a, int imm8)
        public static ushort Extract(Vector<ushort> a, uint select) { throw new NotImplementedException(); }

        // __m128i _mm_max_epu8 (__m128i a, __m128i b)
        public static Vector<short> Max(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_max_epi16 (__m128i a, __m128i b)
        public static Vector<int> Max(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128 _mm_max_ps (__m128 a, __m128 b)
        public static Vector<ushort> Max(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128d _mm_max_pd (__m128d a, __m128d b)
        public static Vector<uint> Max(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }

        // __m128i _mm_min_epu8 (__m128i a, __m128i b)
        public static Vector<short> Min(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_min_epi16 (__m128i a, __m128i b)
        public static Vector<int> Min(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128 _mm_min_ps (__m128 a, __m128 b)
        public static Vector<ushort> Min(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128d _mm_min_pd (__m128d a, __m128d b)
        public static Vector<uint> Min(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }

        // int _mm_movemask_epi8 (__m128i a)
        public static int MoveMask(Vector<sbyte> a) { throw new NotImplementedException(); }
        // int _mm_movemask_ps (__m128 a)
        public static int MoveMask(Vector<float> a) { throw new NotImplementedException(); }
        // int _mm_movemask_pd (__m128d a)
        public static int MoveMask(Vector<double> a) { throw new NotImplementedException(); }

        // __m128i _mm_mul_epu32 (__m128i a, __m128i b)
        public static Vector<ulong> Multiply(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128 _mm_mul_ps (__m128 a, __m128 b)
        public static Vector<float> Multiply(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_mul_pd (__m128d a, __m128d b)
        public static Vector<double> Multiply(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_mulhi_epi16 (__m128i a, __m128i b)
        public static Vector<short> MultiplyHi(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_mulhi_epu16 (__m128i a, __m128i b)
        public static Vector<ushort> MultiplyHi(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m128i _mm_mullo_epi16 (__m128i a, __m128i b)
        public static Vector<short> MultiplyLow(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<sbyte> Or(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<byte> Or(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<short> Or(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<ushort> Or(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<int> Or(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<uint> Or(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<long> Or(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_or_si128 (__m128i a, __m128i b)
        public static Vector<ulong> Or(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_or_ps (__m128 a, __m128 b)
        public static Vector<float> Or(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_or_pd (__m128d a, __m128d b)
        public static Vector<double> Or(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_packs_epi16 (__m128i a, __m128i b)
        public static Vector<sbyte> PackWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_packs_epi32 (__m128i a, __m128i b)
        public static Vector<short> PackWithSignedSaturation(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }

        // __m128i _mm_packus_epi16 (__m128i a, __m128i b)
        public static Vector<byte> PackWithUnsignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m128 _mm_rcp_ps (__m128 a)
        public static Vector<float> Reciprocal(Vector<float> a) { throw new NotImplementedException(); }

        // __m128i _mm_shuffle_epi32 (__m128i a, int imm8)
        public static Vector<int> Shuffle(Vector<int> a, uint select) { throw new NotImplementedException(); }
        // __m128i _mm_shuffle_epi32 (__m128i a, int imm8)
        public static Vector<uint> Shuffle(Vector<uint> a, uint select) { throw new NotImplementedException(); }
        // __m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int imm8)
        public static Vector<float> Shuffle(Vector<float> a, Vector<float> b, uint select) { throw new NotImplementedException(); }
        // __m128d _mm_shuffle_pd (__m128d a, __m128d b, int imm8)
        public static Vector<double> Shuffle(Vector<double> a, Vector<double> b, uint select) { throw new NotImplementedException(); }

        // __m128i _mm_shufflehi_epi16 (__m128i a, int imm8)
        public static Vector<short> ShuffleHigh(Vector<short> a, uint select) { throw new NotImplementedException(); }
        // __m128i _mm_shufflehi_epi16 (__m128i a, int imm8)
        public static Vector<ushort> ShuffleHigh(Vector<ushort> a, uint select) { throw new NotImplementedException(); }

        // __m128i _mm_shufflelo_epi16 (__m128i a, int imm8)
        public static Vector<short> ShuffleLow(Vector<short> a, uint select) { throw new NotImplementedException(); }
        // __m128i _mm_shufflelo_epi16 (__m128i a, int imm8)
        public static Vector<ushort> ShuffleLow(Vector<ushort> a, uint select) { throw new NotImplementedException(); }

        // __m128i _mm_slli_epi16 (__m128i a, int imm8)
        public static Vector<short> ShiftLeftLogical(Vector<short> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_slli_epi16 (__m128i a, int imm8)
        public static Vector<ushort> ShiftLeftLogical(Vector<ushort> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_slli_epi32 (__m128i a, int imm8)
        public static Vector<int> ShiftLeftLogical(Vector<int> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_slli_epi32 (__m128i a, int imm8)
        public static Vector<uint> ShiftLeftLogical(Vector<uint> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_slli_epi64 (__m128i a, int imm8)
        public static Vector<long> ShiftLeftLogical(Vector<long> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_slli_epi64 (__m128i a, int imm8)
        public static Vector<ulong> ShiftLeftLogical(Vector<ulong> a, byte count) { throw new NotImplementedException(); }

        // __m128i _mm_srai_epi16 (__m128i a, int imm8)
        public static Vector<short> ShiftRightArithmetic(Vector<short> a, byte count) { throw new NotImplementedException(); }
        // __m128i _mm_srai_epi32 (__m128i a, int imm8)
        public static Vector<int> ShiftRightArithmetic(Vector<int> a, byte count) { throw new NotImplementedException(); }

        // __m128 _mm_sqrt_ps (__m128 a)
        public static Vector<float> Sqrt(Vector<float> a) { throw new NotImplementedException(); }
        // __m128d _mm_sqrt_pd (__m128d a)
        public static Vector<double> Sqrt(Vector<double> a) { throw new NotImplementedException(); }

        // __m128i _mm_sub_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> Subtract(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi8 (__m128i a, __m128i b)
        public static Vector<byte> Subtract(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi16 (__m128i a, __m128i b)
        public static Vector<short> Subtract(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi16 (__m128i a, __m128i b)
        public static Vector<ushort> Subtract(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi32 (__m128i a, __m128i b)
        public static Vector<int> Subtract(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi32 (__m128i a, __m128i b)
        public static Vector<uint> Subtract(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi64 (__m128i a, __m128i b)
        public static Vector<long> Subtract(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_sub_epi64 (__m128i a, __m128i b)
        public static Vector<ulong> Subtract(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_sub_ps (__m128 a, __m128 b)
        public static Vector<float> Subtract(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_sub_pd (__m128d a, __m128d b)
        public static Vector<double> Subtract(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }

        // __m128i _mm_subs_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> SubtractWithSignedSaturation(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_subs_epi16 (__m128i a, __m128i b)
        public static Vector<short> SubtractWithSignedSaturation(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }

        // __m128i _mm_subs_epu8 (__m128i a, __m128i b)
        public static Vector<byte> SubtractWithUnsignedSaturation(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_subs_epu16 (__m128i a, __m128i b)
        public static Vector<ushort> SubtractWithUnsignedSaturation(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }

        // __m128i _mm_unpackhi_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> UnpackHigh(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi8 (__m128i a, __m128i b)
        public static Vector<byte> UnpackHigh(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi16 (__m128i a, __m128i b)
        public static Vector<short> UnpackHigh(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi16 (__m128i a, __m128i b)
        public static Vector<ushort> UnpackHigh(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b)
        public static Vector<int> UnpackHigh(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b)
        public static Vector<uint> UnpackHigh(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b)
        public static Vector<long> UnpackHigh(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b)
        public static Vector<ulong> UnpackHigh(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_unpackhi_ps (__m128 a, __m128 b)
        public static Vector<float> UnpackHigh(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_unpackhi_pd (__m128d a, __m128d b)
        public static Vector<double> UnpackHigh(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        
        // __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b)
        public static Vector<sbyte> UnpackLow(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi8 (__m128i a, __m128i b)
        public static Vector<byte> UnpackLow(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b)
        public static Vector<short> UnpackLow(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi16 (__m128i a, __m128i b)
        public static Vector<ushort> UnpackLow(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b)
        public static Vector<int> UnpackLow(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi32 (__m128i a, __m128i b)
        public static Vector<uint> UnpackLow(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b)
        public static Vector<long> UnpackLow(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_unpacklo_epi64 (__m128i a, __m128i b)
        public static Vector<ulong> UnpackLow(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_unpacklo_ps (__m128 a, __m128 b)
        public static Vector<float> UnpackLow(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_unpacklo_pd (__m128d a, __m128d b)
        public static Vector<double> UnpackLow(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
        
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<sbyte> Xor(Vector<sbyte> a, Vector<sbyte> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<byte> Xor(Vector<byte> a, Vector<byte> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<short> Xor(Vector<short> a, Vector<short> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<ushort> Xor(Vector<ushort> a, Vector<ushort> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<int> Xor(Vector<int> a, Vector<int> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<uint> Xor(Vector<uint> a, Vector<uint> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<long> Xor(Vector<long> a, Vector<long> b) { throw new NotImplementedException(); }
        // __m128i _mm_xor_si128 (__m128i a, __m128i b)
        public static Vector<ulong> Xor(Vector<ulong> a, Vector<ulong> b) { throw new NotImplementedException(); }
        // __m128 _mm_xor_ps (__m128 a, __m128 b)
        public static Vector<float> Xor(Vector<float> a, Vector<float> b) { throw new NotImplementedException(); }
        // __m128d _mm_xor_pd (__m128d a, __m128d b)
        public static Vector<double> Xor(Vector<double> a, Vector<double> b) { throw new NotImplementedException(); }
    }
}