//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:53 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct exceptionrecord
        {
            // Constructors
            public exceptionrecord(NilType _)
            {
                this.exceptioncode = default;
                this.exceptionflags = default;
                this.exceptionrecord = default;
                this.exceptionaddress = default;
                this.numberparameters = default;
                this.exceptioninformation = default;
            }

            public exceptionrecord(uint exceptioncode = default, uint exceptionflags = default, ref ptr<exceptionrecord> exceptionrecord = default, ref ptr<byte> exceptionaddress = default, uint numberparameters = default, array<uint> exceptioninformation = default)
            {
                this.exceptioncode = exceptioncode;
                this.exceptionflags = exceptionflags;
                this.exceptionrecord = exceptionrecord;
                this.exceptionaddress = exceptionaddress;
                this.numberparameters = numberparameters;
                this.exceptioninformation = exceptioninformation;
            }

            // Enable comparisons between nil and exceptionrecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(exceptionrecord value, NilType nil) => value.Equals(default(exceptionrecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(exceptionrecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, exceptionrecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, exceptionrecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator exceptionrecord(NilType nil) => default(exceptionrecord);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static exceptionrecord exceptionrecord_cast(dynamic value)
        {
            return new exceptionrecord(value.exceptioncode, value.exceptionflags, ref value.exceptionrecord, ref value.exceptionaddress, value.numberparameters, value.exceptioninformation);
        }
    }
}