//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sockaddr_un
        {
            // Constructors
            public sockaddr_un(NilType _)
            {
                this.family = default;
                this.path = default;
            }

            public sockaddr_un(ushort family = default, array<byte> path = default)
            {
                this.family = family;
                this.path = path;
            }

            // Enable comparisons between nil and sockaddr_un struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sockaddr_un value, NilType nil) => value.Equals(default(sockaddr_un));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sockaddr_un value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sockaddr_un value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sockaddr_un value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sockaddr_un(NilType nil) => default(sockaddr_un);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sockaddr_un sockaddr_un_cast(dynamic value)
        {
            return new sockaddr_un(value.family, value.path);
        }
    }
}