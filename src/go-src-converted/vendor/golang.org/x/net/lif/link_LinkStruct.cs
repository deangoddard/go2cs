//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Link
        {
            // Constructors
            public Link(NilType _)
            {
                this.Name = default;
                this.Index = default;
                this.Type = default;
                this.Flags = default;
                this.MTU = default;
                this.Addr = default;
            }

            public Link(@string Name = default, nint Index = default, nint Type = default, nint Flags = default, nint MTU = default, slice<byte> Addr = default)
            {
                this.Name = Name;
                this.Index = Index;
                this.Type = Type;
                this.Flags = Flags;
                this.MTU = MTU;
                this.Addr = Addr;
            }

            // Enable comparisons between nil and Link struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Link value, NilType nil) => value.Equals(default(Link));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Link value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Link value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Link value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Link(NilType nil) => default(Link);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Link Link_cast(dynamic value)
        {
            return new Link(value.Name, value.Index, value.Type, value.Flags, value.MTU, value.Addr);
        }
    }
}}}}}