//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Node
        {
            // Constructors
            public Node(NilType _)
            {
                this.Identifier = default;
                this.LibraryInfo = default;
                this.ServiceInfo = default;
                this.Attributes = default;
            }

            public Node(ref ptr<ProcessIdentifier> Identifier = default, ref ptr<LibraryInfo> LibraryInfo = default, ref ptr<ServiceInfo> ServiceInfo = default, map<@string, @string> Attributes = default)
            {
                this.Identifier = Identifier;
                this.LibraryInfo = LibraryInfo;
                this.ServiceInfo = ServiceInfo;
                this.Attributes = Attributes;
            }

            // Enable comparisons between nil and Node struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Node value, NilType nil) => value.Equals(default(Node));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Node value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Node value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Node value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(NilType nil) => default(Node);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Node Node_cast(dynamic value)
        {
            return new Node(ref value.Identifier, ref value.LibraryInfo, ref value.ServiceInfo, value.Attributes);
        }
    }
}}}}}}}}