//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:36 UTC
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SERVICE_DESCRIPTION
        {
            // Constructors
            public SERVICE_DESCRIPTION(NilType _)
            {
                this.Description = default;
            }

            public SERVICE_DESCRIPTION(ref ptr<ushort> Description = default)
            {
                this.Description = Description;
            }

            // Enable comparisons between nil and SERVICE_DESCRIPTION struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SERVICE_DESCRIPTION value, NilType nil) => value.Equals(default(SERVICE_DESCRIPTION));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SERVICE_DESCRIPTION value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SERVICE_DESCRIPTION value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SERVICE_DESCRIPTION value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SERVICE_DESCRIPTION(NilType nil) => default(SERVICE_DESCRIPTION);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SERVICE_DESCRIPTION SERVICE_DESCRIPTION_cast(dynamic value)
        {
            return new SERVICE_DESCRIPTION(ref value.Description);
        }
    }
}}}}}}