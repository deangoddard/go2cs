//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T5 : IChannel
        {
            // Value of the T5 struct
            private readonly channel<nint> m_value;
            
            public nint Capacity => m_value.Capacity;

            public nint Length => m_value.Length;

            public bool SendIsReady => m_value.SendIsReady;

            public bool ReceiveIsReady => m_value.ReceiveIsReady;

            void Send(object value) => m_value.Send(value);

            object Receive() => m_value.Receive();

            bool Sent(object value) => m_value.Sent(value);

            bool Received(out object value) => m_values.Received(out value);

            void Close() => m_value.Close();

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public T5(channel<nint> value) => m_value = value;

            // Enable implicit conversions between channel<nint> and T5 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T5(channel<nint> value) => new T5(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator channel<nint>(T5 value) => value.m_value;
            
            // Enable comparisons between nil and T5 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T5 value, NilType nil) => value.Equals(default(T5));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T5 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T5 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T5 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T5(NilType nil) => default(T5);
        }
    }
}}}}
