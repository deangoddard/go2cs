//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using token = go.go.token_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class analysis_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SuggestedFix
        {
            // Constructors
            public SuggestedFix(NilType _)
            {
                this.Message = default;
                this.TextEdits = default;
            }

            public SuggestedFix(@string Message = default, slice<TextEdit> TextEdits = default)
            {
                this.Message = Message;
                this.TextEdits = TextEdits;
            }

            // Enable comparisons between nil and SuggestedFix struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SuggestedFix value, NilType nil) => value.Equals(default(SuggestedFix));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SuggestedFix value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SuggestedFix value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SuggestedFix value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SuggestedFix(NilType nil) => default(SuggestedFix);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SuggestedFix SuggestedFix_cast(dynamic value)
        {
            return new SuggestedFix(value.Message, value.TextEdits);
        }
    }
}}}}}