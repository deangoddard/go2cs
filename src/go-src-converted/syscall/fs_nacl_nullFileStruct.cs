//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nullFile
        {
            // Constructors
            public nullFile(NilType _)
            {
            }
            // Enable comparisons between nil and nullFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nullFile value, NilType nil) => value.Equals(default(nullFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nullFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nullFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nullFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nullFile(NilType nil) => default(nullFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nullFile nullFile_cast(dynamic value)
        {
            return new nullFile();
        }
    }
}