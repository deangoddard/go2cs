//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:26:42 UTC
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
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InterfaceAnnounceMessage
        {
            // Constructors
            public InterfaceAnnounceMessage(NilType _)
            {
                this.Header = default;
            }

            public InterfaceAnnounceMessage(IfAnnounceMsghdr Header = default)
            {
                this.Header = Header;
            }

            // Enable comparisons between nil and InterfaceAnnounceMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceAnnounceMessage value, NilType nil) => value.Equals(default(InterfaceAnnounceMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceAnnounceMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceAnnounceMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceAnnounceMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceAnnounceMessage(NilType nil) => default(InterfaceAnnounceMessage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceAnnounceMessage InterfaceAnnounceMessage_cast(dynamic value)
        {
            return new InterfaceAnnounceMessage(value.Header);
        }
    }
}