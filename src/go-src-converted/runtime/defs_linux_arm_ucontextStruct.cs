//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:48 UTC
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
        private partial struct ucontext
        {
            // Constructors
            public ucontext(NilType _)
            {
                this.uc_flags = default;
                this.uc_link = default;
                this.uc_stack = default;
                this.uc_mcontext = default;
                this.uc_sigmask = default;
                this.__unused = default;
                this.uc_regspace = default;
            }

            public ucontext(uint uc_flags = default, ref ptr<ucontext> uc_link = default, stackt uc_stack = default, sigcontext uc_mcontext = default, uint uc_sigmask = default, array<int> __unused = default, array<uint> uc_regspace = default)
            {
                this.uc_flags = uc_flags;
                this.uc_link = uc_link;
                this.uc_stack = uc_stack;
                this.uc_mcontext = uc_mcontext;
                this.uc_sigmask = uc_sigmask;
                this.__unused = __unused;
                this.uc_regspace = uc_regspace;
            }

            // Enable comparisons between nil and ucontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ucontext value, NilType nil) => value.Equals(default(ucontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ucontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ucontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ucontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ucontext(NilType nil) => default(ucontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ucontext ucontext_cast(dynamic value)
        {
            return new ucontext(value.uc_flags, ref value.uc_link, value.uc_stack, value.uc_mcontext, value.uc_sigmask, value.__unused, value.uc_regspace);
        }
    }
}