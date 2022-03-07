//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:26:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(poolDequeue))]
        private partial struct poolChainElt
        {
            // poolDequeue structure promotion - sourced from value copy
            private readonly ptr<poolDequeue> m_poolDequeueRef;

            private ref poolDequeue poolDequeue_val => ref m_poolDequeueRef.Value;

            public ref ulong headTail => ref m_poolDequeueRef.Value.headTail;

            public ref slice<eface> vals => ref m_poolDequeueRef.Value.vals;

            // Constructors
            public poolChainElt(NilType _)
            {
                this.m_poolDequeueRef = new ptr<poolDequeue>(new poolDequeue(nil));
                this.next = default;
                this.prev = default;
            }

            public poolChainElt(poolDequeue poolDequeue = default, ref ptr<poolChainElt> next = default, ref ptr<poolChainElt> prev = default)
            {
                this.m_poolDequeueRef = new ptr<poolDequeue>(poolDequeue);
                this.next = next;
                this.prev = prev;
            }

            // Enable comparisons between nil and poolChainElt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(poolChainElt value, NilType nil) => value.Equals(default(poolChainElt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(poolChainElt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, poolChainElt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, poolChainElt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator poolChainElt(NilType nil) => default(poolChainElt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static poolChainElt poolChainElt_cast(dynamic value)
        {
            return new poolChainElt(value.poolDequeue, ref value.next, ref value.prev);
        }
    }
}