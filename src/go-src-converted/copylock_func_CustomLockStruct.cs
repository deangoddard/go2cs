//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace copylock {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CustomLock
        {
            // Constructors
            public CustomLock(NilType _)
            {
            }
            // Enable comparisons between nil and CustomLock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CustomLock value, NilType nil) => value.Equals(default(CustomLock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CustomLock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CustomLock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CustomLock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CustomLock(NilType nil) => default(CustomLock);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CustomLock CustomLock_cast(dynamic value)
        {
            return new CustomLock();
        }
    }
}}}}}}}}}}