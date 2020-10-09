//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using go;

#nullable enable

namespace go {
namespace crypto {
namespace ed25519 {
namespace @internal
{
    public static partial class edwards25519_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProjectiveGroupElement
        {
            // Constructors
            public ProjectiveGroupElement(NilType _)
            {
                this.X = default;
                this.Y = default;
                this.Z = default;
            }

            public ProjectiveGroupElement(FieldElement X = default, FieldElement Y = default, FieldElement Z = default)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            // Enable comparisons between nil and ProjectiveGroupElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProjectiveGroupElement value, NilType nil) => value.Equals(default(ProjectiveGroupElement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProjectiveGroupElement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProjectiveGroupElement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProjectiveGroupElement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProjectiveGroupElement(NilType nil) => default(ProjectiveGroupElement);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ProjectiveGroupElement ProjectiveGroupElement_cast(dynamic value)
        {
            return new ProjectiveGroupElement(value.X, value.Y, value.Z);
        }
    }
}}}}