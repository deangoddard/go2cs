//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:12:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Paragraph
        {
            // Constructors
            public Paragraph(NilType _)
            {
            }
            // Enable comparisons between nil and Paragraph struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Paragraph value, NilType nil) => value.Equals(default(Paragraph));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Paragraph value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Paragraph value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Paragraph value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Paragraph(NilType nil) => default(Paragraph);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Paragraph Paragraph_cast(dynamic value)
        {
            return new Paragraph();
        }
    }
}}}}}}