//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:58 UTC
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
    public static partial class time_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Timer
        {
            // Constructors
            public Timer(NilType _)
            {
                this.C = default;
                this.r = default;
            }

            public Timer(channel<Time> C = default, runtimeTimer r = default)
            {
                this.C = C;
                this.r = r;
            }

            // Enable comparisons between nil and Timer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Timer value, NilType nil) => value.Equals(default(Timer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Timer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Timer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Timer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Timer(NilType nil) => default(Timer);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Timer Timer_cast(dynamic value)
        {
            return new Timer(value.C, value.r);
        }
    }
}