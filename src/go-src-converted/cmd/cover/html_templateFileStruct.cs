//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:44:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using browser = go.cmd.@internal.browser_package;
using fmt = go.fmt_package;
using template = go.html.template_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using math = go.math_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct templateFile
        {
            // Constructors
            public templateFile(NilType _)
            {
                this.Name = default;
                this.Body = default;
                this.Coverage = default;
            }

            public templateFile(@string Name = default, template.HTML Body = default, double Coverage = default)
            {
                this.Name = Name;
                this.Body = Body;
                this.Coverage = Coverage;
            }

            // Enable comparisons between nil and templateFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(templateFile value, NilType nil) => value.Equals(default(templateFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(templateFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, templateFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, templateFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator templateFile(NilType nil) => default(templateFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static templateFile templateFile_cast(dynamic value)
        {
            return new templateFile(value.Name, value.Body, value.Coverage);
        }
    }
}