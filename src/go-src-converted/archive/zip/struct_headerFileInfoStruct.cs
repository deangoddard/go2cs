//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fs = go.io.fs_package;
using path = go.path_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct headerFileInfo
        {
            // Constructors
            public headerFileInfo(NilType _)
            {
                this.fh = default;
            }

            public headerFileInfo(ref ptr<FileHeader> fh = default)
            {
                this.fh = fh;
            }

            // Enable comparisons between nil and headerFileInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(headerFileInfo value, NilType nil) => value.Equals(default(headerFileInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(headerFileInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, headerFileInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, headerFileInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator headerFileInfo(NilType nil) => default(headerFileInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static headerFileInfo headerFileInfo_cast(dynamic value)
        {
            return new headerFileInfo(ref value.fh);
        }
    }
}}