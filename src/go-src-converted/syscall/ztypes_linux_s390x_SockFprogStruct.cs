//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockFprog
        {
            // Constructors
            public SockFprog(NilType _)
            {
                this.Len = default;
                this._ = default;
                this.Filter = default;
            }

            public SockFprog(ushort Len = default, array<byte> _ = default, ref ptr<SockFilter> Filter = default)
            {
                this.Len = Len;
                this._ = _;
                this.Filter = Filter;
            }

            // Enable comparisons between nil and SockFprog struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockFprog value, NilType nil) => value.Equals(default(SockFprog));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockFprog value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockFprog value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockFprog value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockFprog(NilType nil) => default(SockFprog);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockFprog SockFprog_cast(dynamic value)
        {
            return new SockFprog(value.Len, value._, ref value.Filter);
        }
    }
}