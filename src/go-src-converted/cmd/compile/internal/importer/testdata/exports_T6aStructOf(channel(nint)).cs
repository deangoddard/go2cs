//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:27:22 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct T6a : IChannel
        {
            // Value of the T6a struct
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

            public T6a(channel<nint> value) => m_value = value;

            // Enable implicit conversions between channel<nint> and T6a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6a(channel<nint> value) => new T6a(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator channel<nint>(T6a value) => value.m_value;
            
            // Enable comparisons between nil and T6a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T6a value, NilType nil) => value.Equals(default(T6a));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T6a value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T6a value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T6a value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6a(NilType nil) => default(T6a);
        }
    }
}}}}
