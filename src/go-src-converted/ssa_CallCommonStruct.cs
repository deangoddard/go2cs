//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CallCommon
        {
            // Constructors
            public CallCommon(NilType _)
            {
                this.Value = default;
                this.Method = default;
                this.Args = default;
                this.pos = default;
            }

            public CallCommon(Value Value = default, ref ptr<types.Func> Method = default, slice<Value> Args = default, token.Pos pos = default)
            {
                this.Value = Value;
                this.Method = Method;
                this.Args = Args;
                this.pos = pos;
            }

            // Enable comparisons between nil and CallCommon struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CallCommon value, NilType nil) => value.Equals(default(CallCommon));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CallCommon value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CallCommon value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CallCommon value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CallCommon(NilType nil) => default(CallCommon);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CallCommon CallCommon_cast(dynamic value)
        {
            return new CallCommon(value.Value, ref value.Method, value.Args, value.pos);
        }
    }
}}}}}