//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:27:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Form
        {
            // Value of the Form struct
            private readonly nuint m_value;
            
            public Form(nuint value) => m_value = value;

            // Enable implicit conversions between nuint and Form struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Form(nuint value) => new Form(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nuint(Form value) => value.m_value;
            
            // Enable comparisons between nil and Form struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Form value, NilType nil) => value.Equals(default(Form));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Form value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Form value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Form value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Form(NilType nil) => default(Form);
        }
    }
}}}}
