//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class tlog_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RecordProof
        {
            // Value of the RecordProof struct
            private readonly slice<Hash> m_value;

            public RecordProof(slice<Hash> value) => m_value = value;

            // Enable implicit conversions between slice<Hash> and RecordProof struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecordProof(slice<Hash> value) => new RecordProof(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Hash>(RecordProof value) => value.m_value;
            
            // Enable comparisons between nil and RecordProof struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RecordProof value, NilType nil) => value.Equals(default(RecordProof));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RecordProof value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RecordProof value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RecordProof value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RecordProof(NilType nil) => default(RecordProof);
        }
    }
}}}}}
