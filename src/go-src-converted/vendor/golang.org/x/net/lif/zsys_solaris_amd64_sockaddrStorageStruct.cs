//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sockaddrStorage
        {
            // Constructors
            public sockaddrStorage(NilType _)
            {
                this.Family = default;
                this.X_ss_pad1 = default;
                this.X_ss_align = default;
                this.X_ss_pad2 = default;
            }

            public sockaddrStorage(ushort Family = default, array<sbyte> X_ss_pad1 = default, double X_ss_align = default, array<sbyte> X_ss_pad2 = default)
            {
                this.Family = Family;
                this.X_ss_pad1 = X_ss_pad1;
                this.X_ss_align = X_ss_align;
                this.X_ss_pad2 = X_ss_pad2;
            }

            // Enable comparisons between nil and sockaddrStorage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sockaddrStorage value, NilType nil) => value.Equals(default(sockaddrStorage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sockaddrStorage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sockaddrStorage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sockaddrStorage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sockaddrStorage(NilType nil) => default(sockaddrStorage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sockaddrStorage sockaddrStorage_cast(dynamic value)
        {
            return new sockaddrStorage(value.Family, value.X_ss_pad1, value.X_ss_align, value.X_ss_pad2);
        }
    }
}}}}}