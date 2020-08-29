//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using mime = go.mime_package;
using quotedprintable = go.mime.quotedprintable_package;
using textproto = go.net.textproto_package;
using go;

namespace go {
namespace mime
{
    public static partial class multipart_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Part
        {
            // Constructors
            public Part(NilType _)
            {
                this.Header = default;
                this.mr = default;
                this.disposition = default;
                this.dispositionParams = default;
                this.r = default;
                this.n = default;
                this.total = default;
                this.err = default;
                this.readErr = default;
            }

            public Part(textproto.MIMEHeader Header = default, ref ptr<Reader> mr = default, @string disposition = default, map<@string, @string> dispositionParams = default, io.Reader r = default, long n = default, long total = default, error err = default, error readErr = default)
            {
                this.Header = Header;
                this.mr = mr;
                this.disposition = disposition;
                this.dispositionParams = dispositionParams;
                this.r = r;
                this.n = n;
                this.total = total;
                this.err = err;
                this.readErr = readErr;
            }

            // Enable comparisons between nil and Part struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Part value, NilType nil) => value.Equals(default(Part));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Part value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Part value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Part value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Part(NilType nil) => default(Part);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Part Part_cast(dynamic value)
        {
            return new Part(value.Header, ref value.mr, value.disposition, value.dispositionParams, value.r, value.n, value.total, value.err, value.readErr);
        }
    }
}}