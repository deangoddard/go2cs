//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:35 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class analysis_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct RelatedInformation
        {
            // Constructors
            public RelatedInformation(NilType _)
            {
                this.Pos = default;
                this.End = default;
                this.Message = default;
            }

            public RelatedInformation(token.Pos Pos = default, token.Pos End = default, @string Message = default)
            {
                this.Pos = Pos;
                this.End = End;
                this.Message = Message;
            }

            // Enable comparisons between nil and RelatedInformation struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RelatedInformation value, NilType nil) => value.Equals(default(RelatedInformation));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RelatedInformation value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RelatedInformation value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RelatedInformation value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RelatedInformation(NilType nil) => default(RelatedInformation);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static RelatedInformation RelatedInformation_cast(dynamic value)
        {
            return new RelatedInformation(value.Pos, value.End, value.Message);
        }
    }
}}}}}}}