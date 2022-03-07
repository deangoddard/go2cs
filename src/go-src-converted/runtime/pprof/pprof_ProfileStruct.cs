//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using tabwriter = go.text.tabwriter_package;
using time = go.time_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Profile
        {
            // Constructors
            public Profile(NilType _)
            {
                this.name = default;
                this.mu = default;
                this.count = default;
                this.write = default;
            }

            public Profile(@string name = default, sync.Mutex mu = default, Func<nint> count = default, Func<io.Writer, nint, error> write = default)
            {
                this.name = name;
                this.mu = mu;
                this.count = count;
                this.write = write;
            }

            // Enable comparisons between nil and Profile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Profile value, NilType nil) => value.Equals(default(Profile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Profile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Profile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Profile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Profile(NilType nil) => default(Profile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Profile Profile_cast(dynamic value)
        {
            return new Profile(value.name, value.mu, value.count, value.write);
        }
    }
}}