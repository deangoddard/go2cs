//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ImmAlt
        {
            // Constructors
            public ImmAlt(NilType _)
            {
                this.Val = default;
                this.Rot = default;
            }

            public ImmAlt(byte Val = default, byte Rot = default)
            {
                this.Val = Val;
                this.Rot = Rot;
            }

            // Enable comparisons between nil and ImmAlt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImmAlt value, NilType nil) => value.Equals(default(ImmAlt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImmAlt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImmAlt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImmAlt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImmAlt(NilType nil) => default(ImmAlt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ImmAlt ImmAlt_cast(dynamic value)
        {
            return new ImmAlt(value.Val, value.Rot);
        }
    }
}}}}}}}