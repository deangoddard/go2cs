//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:35:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using abi = go.@internal.abi_package;
using strconv = go.strconv_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace crypto {
namespace x509
{
    public static partial class macOS_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct OSStatus
        {
            // Constructors
            public OSStatus(NilType _)
            {
                this.call = default;
                this.status = default;
            }

            public OSStatus(@string call = default, int status = default)
            {
                this.call = call;
                this.status = status;
            }

            // Enable comparisons between nil and OSStatus struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OSStatus value, NilType nil) => value.Equals(default(OSStatus));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OSStatus value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OSStatus value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OSStatus value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator OSStatus(NilType nil) => default(OSStatus);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static OSStatus OSStatus_cast(dynamic value)
        {
            return new OSStatus(value.call, value.status);
        }
    }
}}}