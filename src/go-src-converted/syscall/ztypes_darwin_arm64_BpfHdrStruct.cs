//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:04 UTC
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
        public partial struct BpfHdr
        {
            // Constructors
            public BpfHdr(NilType _)
            {
                this.Tstamp = default;
                this.Caplen = default;
                this.Datalen = default;
                this.Hdrlen = default;
                this.Pad_cgo_0 = default;
            }

            public BpfHdr(Timeval32 Tstamp = default, uint Caplen = default, uint Datalen = default, ushort Hdrlen = default, array<byte> Pad_cgo_0 = default)
            {
                this.Tstamp = Tstamp;
                this.Caplen = Caplen;
                this.Datalen = Datalen;
                this.Hdrlen = Hdrlen;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and BpfHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfHdr value, NilType nil) => value.Equals(default(BpfHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfHdr(NilType nil) => default(BpfHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfHdr BpfHdr_cast(dynamic value)
        {
            return new BpfHdr(value.Tstamp, value.Caplen, value.Datalen, value.Hdrlen, value.Pad_cgo_0);
        }
    }
}