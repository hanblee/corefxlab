
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// Other.cs
//
// A class that implements intrinsic functions to provide access to other Intel instructions.
//
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+

using System;
using System.Runtime.CompilerServices.Intrinsics;

namespace System.Runtime.CompilerServices.Intrinsics.Intel
{
    public static class LZCNT
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // LZCNT intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // unsigned int _lzcnt_u32 (unsigned int a)
        public static uint LeadingZeroCount(uint value) { throw new NotImplementedException(); }
        // unsigned __int64 _lzcnt_u64 (unsigned __int64 a)
        public static ulong LeadingZeroCount(ulong value) { throw new NotImplementedException(); }
    }

    public static class POPCNT
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // POPCNT intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // int _mm_popcnt_u32 (unsigned int a)
        public static int PopCount(uint value) { throw new NotImplementedException(); }
        // __int64 _mm_popcnt_u64 (unsigned __int64 a)
        public static long PopCount(ulong value) { throw new NotImplementedException(); }
    }

    public static class BMI1
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // BMI1 intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // unsigned int _andn_u32 (unsigned int a, unsigned int b)
        public static uint AndNot(uint left, uint right) { throw new NotImplementedException(); }
        // unsigned __int64 _andn_u64 (unsigned __int64 a, unsigned __int64 b)
        public static ulong AndNot(ulong left, ulong right) { throw new NotImplementedException(); }

        // unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len)
        public static uint BitFieldExtract(uint value, uint start, uint length) { throw new NotImplementedException(); }
        // unsigned __int64 _bextr_u64 (unsigned __int64 a, unsigned int start, unsigned int len)
        public static ulong BitFieldExtract(ulong value, ulong start, ulong length) { throw new NotImplementedException(); }
        // unsigned int _bextr2_u32 (unsigned int a, unsigned int control)
        public static uint BitFieldExtract(uint value, uint control) { throw new NotImplementedException(); }
        // unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control)
        public static ulong BitFieldExtract(ulong value, ulong control) { throw new NotImplementedException(); }
        
        // unsigned int _blsi_u32 (unsigned int a)
        public static uint ExtractLowestSetBit(uint value) { throw new NotImplementedException(); }
        // unsigned __int64 _blsi_u64 (unsigned __int64 a)
        public static ulong ExtractLowestSetBit(ulong value) { throw new NotImplementedException(); }

        // unsigned int _blsmsk_u32 (unsigned int a)
        public static uint GetMaskUptoLowestSetBit(uint value) { throw new NotImplementedException(); }
        // unsigned __int64 _blsmsk_u64 (unsigned __int64 a)
        public static ulong GetMaskUptoLowestSetBit(ulong value) { throw new NotImplementedException(); }
        
        // unsigned int _blsr_u32 (unsigned int a)
        public static uint ResetLowestSetBit(uint value) { throw new NotImplementedException(); }
        // unsigned __int64 _blsr_u64 (unsigned __int64 a)
        public static ulong ResetLowestSetBit(ulong value) { throw new NotImplementedException(); }

        // int _mm_tzcnt_32 (unsigned int a)
        public static uint TrailingZeroCount(uint value) { throw new NotImplementedException(); }
        // __int64 _mm_tzcnt_64 (unsigned __int64 a)
        public static ulong TrailingZeroCount(ulong value) { throw new NotImplementedException(); }
    }

    public static class BMI2
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // BMI2 intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // unsigned int _bzhi_u32 (unsigned int a, unsigned int index)
        public static uint ZeroHighBits(uint value, uint index) { throw new NotImplementedException(); }
        // unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index)
        public static ulong ZeroHighBits(ulong value, ulong index) { throw new NotImplementedException(); }

        // unsigned int _mulx_u32 (unsigned int a, unsigned int b, unsigned int* hi)
        public static unsafe uint MultiplyNoFlags(uint left, uint right, uint* high) { throw new NotImplementedException(); }
        // unsigned __int64 _mulx_u64 (unsigned __int64 a, unsigned __int64 b, unsigned __int64* hi)
        public static unsafe ulong MultiplyNoFlags(ulong left, ulong right, ulong* high) { throw new NotImplementedException(); }

        // unsigned int _pdep_u32 (unsigned int a, unsigned int mask)
        public static uint ParallelBitDeposit(uint value, uint mask) { throw new NotImplementedException(); }
        // unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask)
        public static ulong ParallelBitDeposit(ulong value, ulong mask) { throw new NotImplementedException(); }

        // unsigned int _pext_u32 (unsigned int a, unsigned int mask)
        public static uint ParallelBitExtract(uint value, uint mask) { throw new NotImplementedException(); }
        // unsigned __int64 _pext_u64 (unsigned __int64 a, unsigned __int64 mask)
        public static ulong ParallelBitExtract(ulong value, ulong mask) { throw new NotImplementedException(); }        
    }

    public static class PCLMULQDQ
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // PCLMULQDQ intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8)
        private static Vector128<long> CarryLessMultiply(Vector128<long> left, Vector128<long> right, byte control) { throw new NotImplementedException(); }
        public static CarryLessMultiplyVector128Delegate<long> GetCarryLessMultiplyVector128Long(byte control)
        {
            return (left, right) => CarryLessMultiply(left, right, control);
        }
        // __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8)
        private static Vector128<ulong> CarryLessMultiply(Vector128<ulong> left, Vector128<ulong> right, byte control) { throw new NotImplementedException(); }
        public static CarryLessMultiplyVector128Delegate<ulong> GetCarryLessMultiplyVector128Ulong(byte control)
        {
            return (left, right) => CarryLessMultiply(left, right, control);
        }
    }

    public static class AES 
    {
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        // AES intrinsics
        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        // __m128i _mm_aesdec_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<sbyte> Decrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw new NotImplementedException(); }
        // __m128i _mm_aesdec_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw new NotImplementedException(); }

        // __m128i _mm_aesdeclast_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<sbyte> DecryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw new NotImplementedException(); }
        // __m128i _mm_aesdeclast_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw new NotImplementedException(); }

        // __m128i _mm_aesenc_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<sbyte> Encrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw new NotImplementedException(); }
        // __m128i _mm_aesenc_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw new NotImplementedException(); }

        // __m128i _mm_aesenclast_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<sbyte> EncryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw new NotImplementedException(); }
        // __m128i _mm_aesenclast_si128 (__m128i a, __m128i RoundKey)
        public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw new NotImplementedException(); }

        // __m128i _mm_aesimc_si128 (__m128i a)
        public static Vector128<sbyte> InvisibleMixColumn(Vector128<sbyte> value) { throw new NotImplementedException(); }
        // __m128i _mm_aesimc_si128 (__m128i a)
        public static Vector128<byte> InvisibleMixColumn(Vector128<byte> value) { throw new NotImplementedException(); }

        // __m128i _mm_aeskeygenassist_si128 (__m128i a, const int imm8)
        private static Vector128<sbyte> KeygenAssist(Vector128<sbyte> value, byte control) { throw new NotImplementedException(); }
        public static KeygenAssistVector128Delegate<sbyte> GetKeyGenAssistVector128Byte(byte control)
        {
            return (value) => KeygenAssist(value, control);
        }
        // __m128i _mm_aeskeygenassist_si128 (__m128i a, const int imm8)
        private static Vector128<byte> KeygenAssist(Vector128<byte> value, byte control) { throw new NotImplementedException(); }
        public static KeygenAssistVector128Delegate<byte> GetKeyGenAssistVector128Sbyte(byte control)
        {
            return (value) => KeygenAssist(value, control);
        }
    }
}
