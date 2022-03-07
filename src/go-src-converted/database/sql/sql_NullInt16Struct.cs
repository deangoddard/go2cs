//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NullInt16
        {
            // Constructors
            public NullInt16(NilType _)
            {
                this.Int16 = default;
                this.Valid = default;
            }

            public NullInt16(short Int16 = default, bool Valid = default)
            {
                this.Int16 = Int16;
                this.Valid = Valid;
            }

            // Enable comparisons between nil and NullInt16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NullInt16 value, NilType nil) => value.Equals(default(NullInt16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NullInt16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NullInt16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NullInt16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NullInt16(NilType nil) => default(NullInt16);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NullInt16 NullInt16_cast(dynamic value)
        {
            return new NullInt16(value.Int16, value.Valid);
        }
    }
}}