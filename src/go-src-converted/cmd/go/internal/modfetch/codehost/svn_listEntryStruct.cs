//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:32:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using zip = go.archive.zip_package;
using xml = go.encoding.xml_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace modfetch
{
    public static partial class codehost_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct listEntry
        {
            // Constructors
            public listEntry(NilType _)
            {
                this.Kind = default;
                this.Name = default;
                this.Size = default;
            }

            public listEntry(@string Kind = default, @string Name = default, long Size = default)
            {
                this.Kind = Kind;
                this.Name = Name;
                this.Size = Size;
            }

            // Enable comparisons between nil and listEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(listEntry value, NilType nil) => value.Equals(default(listEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(listEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, listEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, listEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator listEntry(NilType nil) => default(listEntry);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static listEntry listEntry_cast(dynamic value)
        {
            return new listEntry(value.Kind, value.Name, value.Size);
        }
    }
}}}}}