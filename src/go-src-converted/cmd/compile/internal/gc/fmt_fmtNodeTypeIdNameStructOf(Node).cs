//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:27:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fmtNodeTypeIdName
        {
            // Value of the fmtNodeTypeIdName struct
            private readonly Node m_value;

            public fmtNodeTypeIdName(Node value) => m_value = value;

            // Enable implicit conversions between Node and fmtNodeTypeIdName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeTypeIdName(Node value) => new fmtNodeTypeIdName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(fmtNodeTypeIdName value) => value.m_value;
            
            // Enable comparisons between nil and fmtNodeTypeIdName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtNodeTypeIdName value, NilType nil) => value.Equals(default(fmtNodeTypeIdName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtNodeTypeIdName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtNodeTypeIdName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtNodeTypeIdName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeTypeIdName(NilType nil) => default(fmtNodeTypeIdName);
        }
    }
}}}}
