//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct excportablecontext
        {
            // Constructors
            public excportablecontext(NilType _)
            {
                this.pc = default;
                this.sp = default;
                this.fp = default;
            }

            public excportablecontext(uint pc = default, uint sp = default, uint fp = default)
            {
                this.pc = pc;
                this.sp = sp;
                this.fp = fp;
            }

            // Enable comparisons between nil and excportablecontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(excportablecontext value, NilType nil) => value.Equals(default(excportablecontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(excportablecontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, excportablecontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, excportablecontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator excportablecontext(NilType nil) => default(excportablecontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static excportablecontext excportablecontext_cast(dynamic value)
        {
            return new excportablecontext(value.pc, value.sp, value.fp);
        }
    }
}