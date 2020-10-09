//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(MemberHeader))]
        public partial struct Member
        {
            // MemberHeader structure promotion - sourced from value copy
            private readonly ptr<MemberHeader> m_MemberHeaderRef;

            private ref MemberHeader MemberHeader_val => ref m_MemberHeaderRef.Value;

            public ref @string Name => ref m_MemberHeaderRef.Value.Name;

            public ref ulong Size => ref m_MemberHeaderRef.Value.Size;

            // Constructors
            public Member(NilType _)
            {
                this.m_MemberHeaderRef = new ptr<MemberHeader>(new MemberHeader(nil));
                this.sr = default;
            }

            public Member(MemberHeader MemberHeader = default, ref ptr<io.SectionReader> sr = default)
            {
                this.m_MemberHeaderRef = new ptr<MemberHeader>(MemberHeader);
                this.sr = sr;
            }

            // Enable comparisons between nil and Member struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Member value, NilType nil) => value.Equals(default(Member));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Member value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Member value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Member value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Member(NilType nil) => default(Member);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Member Member_cast(dynamic value)
        {
            return new Member(value.MemberHeader, ref value.sr);
        }
    }
}}