//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:30 UTC
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
        public partial struct Fsid
        {
            // Constructors
            public Fsid(NilType _)
            {
                this.X__val = default;
            }

            public Fsid(array<int> X__val = default)
            {
                this.X__val = X__val;
            }

            // Enable comparisons between nil and Fsid struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Fsid value, NilType nil) => value.Equals(default(Fsid));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Fsid value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Fsid value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Fsid value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Fsid(NilType nil) => default(Fsid);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Fsid Fsid_cast(dynamic value)
        {
            return new Fsid(value.X__val);
        }
    }
}