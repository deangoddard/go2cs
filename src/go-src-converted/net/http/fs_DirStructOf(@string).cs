//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dir
        {
            // Value of the Dir struct
            private readonly @string m_value;

            public Dir(@string value) => m_value = value;

            // Enable implicit conversions between @string and Dir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dir(@string value) => new Dir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(Dir value) => value.m_value;
            
            // Enable comparisons between nil and Dir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dir value, NilType nil) => value.Equals(default(Dir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dir(NilType nil) => default(Dir);
        }
    }
}}
