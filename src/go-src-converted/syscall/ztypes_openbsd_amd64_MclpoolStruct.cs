//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:51 UTC
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
        public partial struct Mclpool
        {
            // Constructors
            public Mclpool(NilType _)
            {
                this.Grown = default;
                this.Alive = default;
                this.Hwm = default;
                this.Cwm = default;
                this.Lwm = default;
            }

            public Mclpool(int Grown = default, ushort Alive = default, ushort Hwm = default, ushort Cwm = default, ushort Lwm = default)
            {
                this.Grown = Grown;
                this.Alive = Alive;
                this.Hwm = Hwm;
                this.Cwm = Cwm;
                this.Lwm = Lwm;
            }

            // Enable comparisons between nil and Mclpool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mclpool value, NilType nil) => value.Equals(default(Mclpool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mclpool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mclpool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mclpool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mclpool(NilType nil) => default(Mclpool);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Mclpool Mclpool_cast(dynamic value)
        {
            return new Mclpool(value.Grown, value.Alive, value.Hwm, value.Cwm, value.Lwm);
        }
    }
}