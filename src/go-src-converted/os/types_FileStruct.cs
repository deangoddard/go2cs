//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:07:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct File
        {
            // Constructors
            public File(NilType _)
            {
                this.ptr<file> = default;
            }

            public File(ref ptr<file> ptr<file> = default)
            {
                this.ptr<file> = ptr<file>;
            }

            // Enable comparisons between nil and File struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File value, NilType nil) => value.Equals(default(File));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator File(NilType nil) => default(File);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static File File_cast(dynamic value)
        {
            return new File(ref value.ptr<file>);
        }
    }
}