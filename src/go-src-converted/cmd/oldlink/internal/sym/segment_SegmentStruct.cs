//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:51:12 UTC
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
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Segment
        {
            // Constructors
            public Segment(NilType _)
            {
                this.Rwx = default;
                this.Vaddr = default;
                this.Length = default;
                this.Fileoff = default;
                this.Filelen = default;
                this.Sections = default;
            }

            public Segment(byte Rwx = default, ulong Vaddr = default, ulong Length = default, ulong Fileoff = default, ulong Filelen = default, slice<ptr<Section>> Sections = default)
            {
                this.Rwx = Rwx;
                this.Vaddr = Vaddr;
                this.Length = Length;
                this.Fileoff = Fileoff;
                this.Filelen = Filelen;
                this.Sections = Sections;
            }

            // Enable comparisons between nil and Segment struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Segment value, NilType nil) => value.Equals(default(Segment));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Segment value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Segment value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Segment value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Segment(NilType nil) => default(Segment);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Segment Segment_cast(dynamic value)
        {
            return new Segment(value.Rwx, value.Vaddr, value.Length, value.Fileoff, value.Filelen, value.Sections);
        }
    }
}}}}