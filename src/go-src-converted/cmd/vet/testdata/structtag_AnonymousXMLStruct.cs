//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using xml = go.encoding.xml_package;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct AnonymousXML
        {
            // Constructors
            public AnonymousXML(NilType _)
            {
            }
            // Enable comparisons between nil and AnonymousXML struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AnonymousXML value, NilType nil) => value.Equals(default(AnonymousXML));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AnonymousXML value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AnonymousXML value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AnonymousXML value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AnonymousXML(NilType nil) => default(AnonymousXML);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static AnonymousXML AnonymousXML_cast(dynamic value)
        {
            return new AnonymousXML();
        }
    }
}}}