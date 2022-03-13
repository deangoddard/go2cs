//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using http = go.net.http_package;
using regexp = go.regexp_package;
using time = go.time_package;
using internaldriver = go.github.com.google.pprof.@internal.driver_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct internalSymbolizer
        {
            // Symbolizer.Symbolize function promotion
            private delegate error SymbolizeByVal(T value, @string mode, MappingSources srcs, ptr<profile.Profile> prof);
            private delegate error SymbolizeByRef(ref T value, @string mode, MappingSources srcs, ptr<profile.Profile> prof);

            private static readonly SymbolizeByVal s_SymbolizeByVal;
            private static readonly SymbolizeByRef s_SymbolizeByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Symbolize(@string mode, MappingSources srcs, ptr<profile.Profile> prof) => s_SymbolizeByRef?.Invoke(ref this, mode, srcs, prof) ?? s_SymbolizeByVal?.Invoke(this, mode, srcs, prof) ?? Symbolizer?.Symbolize(mode, srcs, prof) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static internalSymbolizer()
            {
                Type targetType = typeof(internalSymbolizer);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Symbolize");

                if (extensionMethod is not null)
                {
                    s_SymbolizeByRef = extensionMethod.CreateStaticDelegate(typeof(SymbolizeByRef)) as SymbolizeByRef;

                    if (s_SymbolizeByRef is null)
                        s_SymbolizeByVal = extensionMethod.CreateStaticDelegate(typeof(SymbolizeByVal)) as SymbolizeByVal;
                }
            }

            // Constructors
            public internalSymbolizer(NilType _)
            {
                this.Symbolizer = default;
            }

            public internalSymbolizer(Symbolizer Symbolizer = default)
            {
                this.Symbolizer = Symbolizer;
            }

            // Enable comparisons between nil and internalSymbolizer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(internalSymbolizer value, NilType nil) => value.Equals(default(internalSymbolizer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(internalSymbolizer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, internalSymbolizer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, internalSymbolizer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator internalSymbolizer(NilType nil) => default(internalSymbolizer);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static internalSymbolizer internalSymbolizer_cast(dynamic value)
        {
            return new internalSymbolizer(value.Symbolizer);
        }
    }
}}}}}}