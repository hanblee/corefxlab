using System;

namespace System.Runtime.CompilerServices
{
    public static class ProcessorCapabilities
    {
        public static bool IsSupported(InstructionSet instructionSet) { throw new NotImplementedException(); }
        public static InstructionSet GetSupportedInstructionSet() { throw new NotImplementedException(); }
    }

    public enum InstructionSet
    {
        SSE2,
        AVX2,
    }

    public enum RoundMode : byte
    {
        FRoundToNearestInteger = 0,     // Round to nearest
        FRoundToNegativeInfinity = 1,   // Round down
        FRoundToPositiveInfinity = 2,   // Round up
        FRoundToZero = 3,               // Truncate
        FRoundCurrentDirection = 4,     // Use MXCSR.RC
        FRoundNoException = 8,          // Suppress exceptions
    }

    public enum ComparisonMode : byte
    {
        CompareEqualOrderedNonSignaling,
        CompareLessThanOrderedSignaling,
        CompareLessThanOrEqualOrderedSignaling,
        CompareUnorderedNonSignaling,
        CompareNotEqualUnorderedNonSignaling,
        CompareNotLessThanUnorderedSignaling,
        CompareNotLessThanOrEqualUnorderedSignaling,
        CompareOrderedNonSignaling,
        CompareEqualUnorderedNonSignaling,
        CompareNotGreaterThanOrEqualUnorderedSignaling,
        CompareNotGreaterThanUnorderedSignaling,
        CompareFalseOrderedNonSignaling,
        CompareNotEqualOrderedNonSignaling,
        CompareGreaterThanOrEqualOrderedSignaling,
        CompareGreaterThanOrderedSignaling,
        CompareTrueUnorderedNonSignaling,
        CompareEqualOrderedSignaling,
        CompareLessThanOrderedNonSignaling,
        CompareLessThanOrEqualOrderedNonSignaling,
        CompareUnorderedSignaling,
        CompareNotEqualUnorderedSignaling,
        CompareNotLessThanUnorderedNonSignaling,
        CompareNotLessThanOrEqualUnorderedNonSignaling,
        CompareOrderedSignaling,
        CompareEqualUnorderedSignaling,
        CompareNotGreaterThanOrEqualUnorderedNonSignaling,
        CompareNotGreaterThanUnorderedNonSignaling,
        CompareFalseOrderedSignaling,
        CompareNotEqualOrderedSignaling,
        CompareGreaterThanOrEqualOrderedNonSignaling,
        CompareGreaterThanOrderedNonSignaling,
        CompareTrueUnorderedSignaling,
    }
}