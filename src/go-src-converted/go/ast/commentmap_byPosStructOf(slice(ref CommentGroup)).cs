//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byPos
        {
            // Value of the byPos struct
            private readonly slice<ref CommentGroup> m_value;

            public byPos(slice<ref CommentGroup> value) => m_value = value;

            // Enable implicit conversions between slice<ref CommentGroup> and byPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPos(slice<ref CommentGroup> value) => new byPos(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ref CommentGroup>(byPos value) => value.m_value;
            
            // Enable comparisons between nil and byPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byPos value, NilType nil) => value.Equals(default(byPos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byPos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byPos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byPos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPos(NilType nil) => default(byPos);
        }
    }
}}