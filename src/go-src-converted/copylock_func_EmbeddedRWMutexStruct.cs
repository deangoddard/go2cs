//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace copylock {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(sync.RWMutex))]
        public partial struct EmbeddedRWMutex
        {
            // RWMutex structure promotion - sourced from value copy
            private readonly ptr<RWMutex> m_RWMutexRef;

            private ref RWMutex RWMutex_val => ref m_RWMutexRef.Value;

            public ref Mutex w => ref m_RWMutexRef.Value.w;

            public ref uint writerSem => ref m_RWMutexRef.Value.writerSem;

            public ref uint readerSem => ref m_RWMutexRef.Value.readerSem;

            public ref int readerCount => ref m_RWMutexRef.Value.readerCount;

            public ref int readerWait => ref m_RWMutexRef.Value.readerWait;

            // Constructors
            public EmbeddedRWMutex(NilType _)
            {
                this.m_RWMutexRef = new ptr<sync.RWMutex>(new sync.RWMutex(nil));
            }

            public EmbeddedRWMutex(sync.RWMutex RWMutex = default)
            {
                this.m_RWMutexRef = new ptr<sync.RWMutex>(RWMutex);
            }

            // Enable comparisons between nil and EmbeddedRWMutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EmbeddedRWMutex value, NilType nil) => value.Equals(default(EmbeddedRWMutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EmbeddedRWMutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EmbeddedRWMutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EmbeddedRWMutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EmbeddedRWMutex(NilType nil) => default(EmbeddedRWMutex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static EmbeddedRWMutex EmbeddedRWMutex_cast(dynamic value)
        {
            return new EmbeddedRWMutex(value.RWMutex);
        }
    }
}}}}}}}}}}