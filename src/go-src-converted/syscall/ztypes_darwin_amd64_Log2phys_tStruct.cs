//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:03 UTC
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
        public partial struct Log2phys_t
        {
            // Constructors
            public Log2phys_t(NilType _)
            {
                this.Flags = default;
                this.Contigbytes = default;
                this.Devoffset = default;
            }

            public Log2phys_t(uint Flags = default, long Contigbytes = default, long Devoffset = default)
            {
                this.Flags = Flags;
                this.Contigbytes = Contigbytes;
                this.Devoffset = Devoffset;
            }

            // Enable comparisons between nil and Log2phys_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Log2phys_t value, NilType nil) => value.Equals(default(Log2phys_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Log2phys_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Log2phys_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Log2phys_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Log2phys_t(NilType nil) => default(Log2phys_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Log2phys_t Log2phys_t_cast(dynamic value)
        {
            return new Log2phys_t(value.Flags, value.Contigbytes, value.Devoffset);
        }
    }
}