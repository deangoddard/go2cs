//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Qid
        {
            // Constructors
            public Qid(NilType _)
            {
                this.Path = default;
                this.Vers = default;
                this.Type = default;
            }

            public Qid(ulong Path = default, uint Vers = default, byte Type = default)
            {
                this.Path = Path;
                this.Vers = Vers;
                this.Type = Type;
            }

            // Enable comparisons between nil and Qid struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Qid value, NilType nil) => value.Equals(default(Qid));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Qid value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Qid value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Qid value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Qid(NilType nil) => default(Qid);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Qid Qid_cast(dynamic value)
        {
            return new Qid(value.Path, value.Vers, value.Type);
        }
    }
}