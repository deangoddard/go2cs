//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using race = go.@internal.race_package;
using runtime = go.runtime_package;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(poolLocalInternal))]
        private partial struct poolLocal
        {
            // poolLocalInternal structure promotion - sourced from value copy
            private readonly ptr<poolLocalInternal> m_poolLocalInternalRef;

            private ref poolLocalInternal poolLocalInternal_val => ref m_poolLocalInternalRef.Value;

            public ref slice<object> shared => ref m_poolLocalInternalRef.Value.shared;

            // Constructors
            public poolLocal(NilType _)
            {
                this.m_poolLocalInternalRef = new ptr<poolLocalInternal>(new poolLocalInternal(nil));
                this.pad = default;
            }

            public poolLocal(poolLocalInternal poolLocalInternal = default, array<byte> pad = default)
            {
                this.m_poolLocalInternalRef = new ptr<poolLocalInternal>(poolLocalInternal);
                this.pad = pad;
            }

            // Enable comparisons between nil and poolLocal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(poolLocal value, NilType nil) => value.Equals(default(poolLocal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(poolLocal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, poolLocal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, poolLocal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator poolLocal(NilType nil) => default(poolLocal);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static poolLocal poolLocal_cast(dynamic value)
        {
            return new poolLocal(value.poolLocalInternal, value.pad);
        }
    }
}