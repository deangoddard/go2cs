//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct configField
        {
            // Constructors
            public configField(NilType _)
            {
                this.name = default;
                this.urlparam = default;
                this.saved = default;
                this.field = default;
                this.choices = default;
                this.defaultValue = default;
            }

            public configField(@string name = default, @string urlparam = default, bool saved = default, reflect.StructField field = default, slice<@string> choices = default, @string defaultValue = default)
            {
                this.name = name;
                this.urlparam = urlparam;
                this.saved = saved;
                this.field = field;
                this.choices = choices;
                this.defaultValue = defaultValue;
            }

            // Enable comparisons between nil and configField struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(configField value, NilType nil) => value.Equals(default(configField));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(configField value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, configField value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, configField value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator configField(NilType nil) => default(configField);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static configField configField_cast(dynamic value)
        {
            return new configField(value.name, value.urlparam, value.saved, value.field, value.choices, value.defaultValue);
        }
    }
}}}}}}}