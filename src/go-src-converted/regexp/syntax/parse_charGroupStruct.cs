//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace regexp
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct charGroup
        {
            // Constructors
            public charGroup(NilType _)
            {
                this.sign = default;
                this.@class = default;
            }

            public charGroup(nint sign = default, slice<int> @class = default)
            {
                this.sign = sign;
                this.@class = @class;
            }

            // Enable comparisons between nil and charGroup struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(charGroup value, NilType nil) => value.Equals(default(charGroup));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(charGroup value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, charGroup value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, charGroup value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator charGroup(NilType nil) => default(charGroup);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static charGroup charGroup_cast(dynamic value)
        {
            return new charGroup(value.sign, value.@class);
        }
    }
}}