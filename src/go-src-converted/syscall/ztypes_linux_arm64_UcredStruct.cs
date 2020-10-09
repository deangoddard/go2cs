//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:27 UTC
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
        public partial struct Ucred
        {
            // Constructors
            public Ucred(NilType _)
            {
                this.Pid = default;
                this.Uid = default;
                this.Gid = default;
            }

            public Ucred(int Pid = default, uint Uid = default, uint Gid = default)
            {
                this.Pid = Pid;
                this.Uid = Uid;
                this.Gid = Gid;
            }

            // Enable comparisons between nil and Ucred struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Ucred value, NilType nil) => value.Equals(default(Ucred));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Ucred value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Ucred value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Ucred value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Ucred(NilType nil) => default(Ucred);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Ucred Ucred_cast(dynamic value)
        {
            return new Ucred(value.Pid, value.Uid, value.Gid);
        }
    }
}