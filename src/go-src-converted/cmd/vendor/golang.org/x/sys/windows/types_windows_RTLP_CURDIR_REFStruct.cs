//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RTLP_CURDIR_REF
        {
            // Constructors
            public RTLP_CURDIR_REF(NilType _)
            {
                this.RefCount = default;
                this.Handle = default;
            }

            public RTLP_CURDIR_REF(int RefCount = default, Handle Handle = default)
            {
                this.RefCount = RefCount;
                this.Handle = Handle;
            }

            // Enable comparisons between nil and RTLP_CURDIR_REF struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RTLP_CURDIR_REF value, NilType nil) => value.Equals(default(RTLP_CURDIR_REF));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RTLP_CURDIR_REF value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RTLP_CURDIR_REF value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RTLP_CURDIR_REF value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RTLP_CURDIR_REF(NilType nil) => default(RTLP_CURDIR_REF);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RTLP_CURDIR_REF RTLP_CURDIR_REF_cast(dynamic value)
        {
            return new RTLP_CURDIR_REF(value.RefCount, value.Handle);
        }
    }
}}}}}}