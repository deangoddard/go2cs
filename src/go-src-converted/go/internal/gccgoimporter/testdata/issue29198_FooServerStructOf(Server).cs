//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class server_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FooServer
        {
            // Value of the FooServer struct
            private readonly Server m_value;

            public FooServer(Server value) => m_value = value;

            // Enable implicit conversions between Server and FooServer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FooServer(Server value) => new FooServer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Server(FooServer value) => value.m_value;
            
            // Enable comparisons between nil and FooServer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FooServer value, NilType nil) => value.Equals(default(FooServer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FooServer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FooServer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FooServer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FooServer(NilType nil) => default(FooServer);
        }
    }
}}}
