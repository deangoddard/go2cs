//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:50 UTC
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
        public partial struct Utimbuf
        {
            // Constructors
            public Utimbuf(NilType _)
            {
                this.Actime = default;
                this.Modtime = default;
            }

            public Utimbuf(int Actime = default, int Modtime = default)
            {
                this.Actime = Actime;
                this.Modtime = Modtime;
            }

            // Enable comparisons between nil and Utimbuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Utimbuf value, NilType nil) => value.Equals(default(Utimbuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Utimbuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Utimbuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Utimbuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Utimbuf(NilType nil) => default(Utimbuf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Utimbuf Utimbuf_cast(dynamic value)
        {
            return new Utimbuf(value.Actime, value.Modtime);
        }
    }
}