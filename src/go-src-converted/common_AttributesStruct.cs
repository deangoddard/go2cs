//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Attributes
        {
            // Constructors
            public Attributes(NilType _)
            {
                this.AttributeMap = default;
                this.DroppedAttributesCount = default;
            }

            public Attributes(map<@string, Attribute> AttributeMap = default, int DroppedAttributesCount = default)
            {
                this.AttributeMap = AttributeMap;
                this.DroppedAttributesCount = DroppedAttributesCount;
            }

            // Enable comparisons between nil and Attributes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Attributes value, NilType nil) => value.Equals(default(Attributes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Attributes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Attributes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Attributes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Attributes(NilType nil) => default(Attributes);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Attributes Attributes_cast(dynamic value)
        {
            return new Attributes(value.AttributeMap, value.DroppedAttributesCount);
        }
    }
}}}}}}}}