//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using time = go.time_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ccChecker
        {
            // Constructors
            public ccChecker(NilType _)
            {
                this.cci = default;
                this.want = default;
            }

            public ccChecker(driver.ColumnConverter cci = default, long want = default)
            {
                this.cci = cci;
                this.want = want;
            }

            // Enable comparisons between nil and ccChecker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ccChecker value, NilType nil) => value.Equals(default(ccChecker));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ccChecker value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ccChecker value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ccChecker value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ccChecker(NilType nil) => default(ccChecker);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ccChecker ccChecker_cast(dynamic value)
        {
            return new ccChecker(value.cci, value.want);
        }
    }
}}