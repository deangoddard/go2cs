//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using math = go.math_package;
using os = go.os_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools
{
    public static partial class cover_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Boundary
        {
            // Constructors
            public Boundary(NilType _)
            {
                this.Offset = default;
                this.Start = default;
                this.Count = default;
                this.Norm = default;
                this.Index = default;
            }

            public Boundary(nint Offset = default, bool Start = default, nint Count = default, double Norm = default, nint Index = default)
            {
                this.Offset = Offset;
                this.Start = Start;
                this.Count = Count;
                this.Norm = Norm;
                this.Index = Index;
            }

            // Enable comparisons between nil and Boundary struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Boundary value, NilType nil) => value.Equals(default(Boundary));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Boundary value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Boundary value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Boundary value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Boundary(NilType nil) => default(Boundary);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Boundary Boundary_cast(dynamic value)
        {
            return new Boundary(value.Offset, value.Start, value.Count, value.Norm, value.Index);
        }
    }
}}}}}}