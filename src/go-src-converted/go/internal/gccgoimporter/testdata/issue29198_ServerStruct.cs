//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class server_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Server
        {
            // Constructors
            public Server(NilType _)
            {
                this.FooServer = default;
                this.user = default;
                this.ctx = default;
            }

            public Server(ref ptr<FooServer> FooServer = default, @string user = default, context.Context ctx = default)
            {
                this.FooServer = FooServer;
                this.user = user;
                this.ctx = ctx;
            }

            // Enable comparisons between nil and Server struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Server value, NilType nil) => value.Equals(default(Server));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Server value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Server value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Server value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Server(NilType nil) => default(Server);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Server Server_cast(dynamic value)
        {
            return new Server(ref value.FooServer, value.user, value.ctx);
        }
    }
}}}