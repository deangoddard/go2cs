//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:41:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fmtNodeDbg
        {
            // Value of the fmtNodeDbg struct
            private readonly Node m_value;

            public fmtNodeDbg(Node value) => m_value = value;

            // Enable implicit conversions between Node and fmtNodeDbg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeDbg(Node value) => new fmtNodeDbg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(fmtNodeDbg value) => value.m_value;
            
            // Enable comparisons between nil and fmtNodeDbg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtNodeDbg value, NilType nil) => value.Equals(default(fmtNodeDbg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtNodeDbg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtNodeDbg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtNodeDbg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeDbg(NilType nil) => default(fmtNodeDbg);
        }
    }
}}}}
