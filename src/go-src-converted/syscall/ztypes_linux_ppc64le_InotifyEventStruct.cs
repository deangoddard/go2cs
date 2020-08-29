//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InotifyEvent
        {
            // Constructors
            public InotifyEvent(NilType _)
            {
                this.Wd = default;
                this.Mask = default;
                this.Cookie = default;
                this.Len = default;
                this.Name = default;
            }

            public InotifyEvent(int Wd = default, uint Mask = default, uint Cookie = default, uint Len = default, array<byte> Name = default)
            {
                this.Wd = Wd;
                this.Mask = Mask;
                this.Cookie = Cookie;
                this.Len = Len;
                this.Name = Name;
            }

            // Enable comparisons between nil and InotifyEvent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InotifyEvent value, NilType nil) => value.Equals(default(InotifyEvent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InotifyEvent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InotifyEvent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InotifyEvent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InotifyEvent(NilType nil) => default(InotifyEvent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InotifyEvent InotifyEvent_cast(dynamic value)
        {
            return new InotifyEvent(value.Wd, value.Mask, value.Cookie, value.Len, value.Name);
        }
    }
}