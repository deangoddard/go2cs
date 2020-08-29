//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Iovec
        {
            // Constructors
            public Iovec(NilType _)
            {
                this.Base = default;
                this.Len = default;
            }

            public Iovec(ref ptr<sbyte> Base = default, ulong Len = default)
            {
                this.Base = Base;
                this.Len = Len;
            }

            // Enable comparisons between nil and Iovec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Iovec value, NilType nil) => value.Equals(default(Iovec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Iovec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Iovec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Iovec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Iovec(NilType nil) => default(Iovec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Iovec Iovec_cast(dynamic value)
        {
            return new Iovec(ref value.Base, value.Len);
        }
    }
}