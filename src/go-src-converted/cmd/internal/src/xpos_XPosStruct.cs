//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class src_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct XPos
        {
            // Constructors
            public XPos(NilType _)
            {
                this.index = default;
                this.lico = default;
            }

            public XPos(int index = default, lico lico = default)
            {
                this.index = index;
                this.lico = lico;
            }

            // Enable comparisons between nil and XPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XPos value, NilType nil) => value.Equals(default(XPos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XPos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XPos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XPos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XPos(NilType nil) => default(XPos);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XPos XPos_cast(dynamic value)
        {
            return new XPos(value.index, value.lico);
        }
    }
}}}