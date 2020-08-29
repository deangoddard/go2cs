//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using asn1 = go.encoding.asn1_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct VerifyOptions
        {
            // Constructors
            public VerifyOptions(NilType _)
            {
                this.DNSName = default;
                this.Intermediates = default;
                this.Roots = default;
                this.CurrentTime = default;
                this.KeyUsages = default;
                this.MaxConstraintComparisions = default;
            }

            public VerifyOptions(@string DNSName = default, ref ptr<CertPool> Intermediates = default, ref ptr<CertPool> Roots = default, time.Time CurrentTime = default, slice<ExtKeyUsage> KeyUsages = default, long MaxConstraintComparisions = default)
            {
                this.DNSName = DNSName;
                this.Intermediates = Intermediates;
                this.Roots = Roots;
                this.CurrentTime = CurrentTime;
                this.KeyUsages = KeyUsages;
                this.MaxConstraintComparisions = MaxConstraintComparisions;
            }

            // Enable comparisons between nil and VerifyOptions struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(VerifyOptions value, NilType nil) => value.Equals(default(VerifyOptions));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(VerifyOptions value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, VerifyOptions value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, VerifyOptions value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator VerifyOptions(NilType nil) => default(VerifyOptions);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static VerifyOptions VerifyOptions_cast(dynamic value)
        {
            return new VerifyOptions(value.DNSName, ref value.Intermediates, ref value.Roots, value.CurrentTime, value.KeyUsages, value.MaxConstraintComparisions);
        }
    }
}}