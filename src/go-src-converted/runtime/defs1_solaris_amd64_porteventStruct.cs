//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct portevent
        {
            // Constructors
            public portevent(NilType _)
            {
                this.portev_events = default;
                this.portev_source = default;
                this.portev_pad = default;
                this.portev_object = default;
                this.portev_user = default;
            }

            public portevent(int portev_events = default, ushort portev_source = default, ushort portev_pad = default, ulong portev_object = default, ref ptr<byte> portev_user = default)
            {
                this.portev_events = portev_events;
                this.portev_source = portev_source;
                this.portev_pad = portev_pad;
                this.portev_object = portev_object;
                this.portev_user = portev_user;
            }

            // Enable comparisons between nil and portevent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(portevent value, NilType nil) => value.Equals(default(portevent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(portevent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, portevent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, portevent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator portevent(NilType nil) => default(portevent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static portevent portevent_cast(dynamic value)
        {
            return new portevent(value.portev_events, value.portev_source, value.portev_pad, value.portev_object, ref value.portev_user);
        }
    }
}