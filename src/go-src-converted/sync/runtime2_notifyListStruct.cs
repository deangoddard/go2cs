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
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct notifyList
        {
            // Constructors
            public notifyList(NilType _)
            {
                this.wait = default;
                this.notify = default;
                this.@lock = default;
                this.head = default;
                this.tail = default;
            }

            public notifyList(uint wait = default, uint notify = default, System.UIntPtr @lock = default, unsafe.Pointer head = default, unsafe.Pointer tail = default)
            {
                this.wait = wait;
                this.notify = notify;
                this.@lock = @lock;
                this.head = head;
                this.tail = tail;
            }

            // Enable comparisons between nil and notifyList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(notifyList value, NilType nil) => value.Equals(default(notifyList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(notifyList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, notifyList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, notifyList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator notifyList(NilType nil) => default(notifyList);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static notifyList notifyList_cast(dynamic value)
        {
            return new notifyList(value.wait, value.notify, value.@lock, value.head, value.tail);
        }
    }
}