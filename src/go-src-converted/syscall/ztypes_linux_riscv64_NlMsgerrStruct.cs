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
        public partial struct NlMsgerr
        {
            // Constructors
            public NlMsgerr(NilType _)
            {
                this.Error = default;
                this.Msg = default;
            }

            public NlMsgerr(int Error = default, NlMsghdr Msg = default)
            {
                this.Error = Error;
                this.Msg = Msg;
            }

            // Enable comparisons between nil and NlMsgerr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NlMsgerr value, NilType nil) => value.Equals(default(NlMsgerr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NlMsgerr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NlMsgerr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NlMsgerr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NlMsgerr(NilType nil) => default(NlMsgerr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NlMsgerr NlMsgerr_cast(dynamic value)
        {
            return new NlMsgerr(value.Error, value.Msg);
        }
    }
}