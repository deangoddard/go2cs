//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:47 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BpfTimeval
        {
            // Constructors
            public BpfTimeval(NilType _)
            {
                this.Sec = default;
                this.Usec = default;
            }

            public BpfTimeval(int Sec = default, int Usec = default)
            {
                this.Sec = Sec;
                this.Usec = Usec;
            }

            // Enable comparisons between nil and BpfTimeval struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfTimeval value, NilType nil) => value.Equals(default(BpfTimeval));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfTimeval value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfTimeval value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfTimeval value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfTimeval(NilType nil) => default(BpfTimeval);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfTimeval BpfTimeval_cast(dynamic value)
        {
            return new BpfTimeval(value.Sec, value.Usec);
        }
    }
}}}}}}