//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ptwo = go.p2_package;
using go;

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(URL))]
        public partial struct EmbedURLPtr
        {
            // URL structure promotion - sourced from pointer
            private readonly ptr<URL> m_URLRef;

            private ref URL URL_ptr => ref m_URLRef.Value;

            // Constructors
            public EmbedURLPtr(NilType _)
            {
                this.m_URLRef = new ptr<URL>(new URL(nil));
            }

            public EmbedURLPtr(ref URL URL = default)
            {
                this.m_URLRef = new ptr<URL>(ref URL);
            }

            // Enable comparisons between nil and EmbedURLPtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EmbedURLPtr value, NilType nil) => value.Equals(default(EmbedURLPtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EmbedURLPtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EmbedURLPtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EmbedURLPtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EmbedURLPtr(NilType nil) => default(EmbedURLPtr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static EmbedURLPtr EmbedURLPtr_cast(dynamic value)
        {
            return new EmbedURLPtr(ref value.URL);
        }
    }
}}}}}}