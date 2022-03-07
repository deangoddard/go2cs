//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CryptoStatKPP
        {
            // Constructors
            public CryptoStatKPP(NilType _)
            {
                this.Type = default;
                this.Setsecret_cnt = default;
                this.Generate_public_key_cnt = default;
                this.Compute_shared_secret_cnt = default;
                this.Err_cnt = default;
            }

            public CryptoStatKPP(array<sbyte> Type = default, ulong Setsecret_cnt = default, ulong Generate_public_key_cnt = default, ulong Compute_shared_secret_cnt = default, ulong Err_cnt = default)
            {
                this.Type = Type;
                this.Setsecret_cnt = Setsecret_cnt;
                this.Generate_public_key_cnt = Generate_public_key_cnt;
                this.Compute_shared_secret_cnt = Compute_shared_secret_cnt;
                this.Err_cnt = Err_cnt;
            }

            // Enable comparisons between nil and CryptoStatKPP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoStatKPP value, NilType nil) => value.Equals(default(CryptoStatKPP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoStatKPP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoStatKPP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoStatKPP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoStatKPP(NilType nil) => default(CryptoStatKPP);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoStatKPP CryptoStatKPP_cast(dynamic value)
        {
            return new CryptoStatKPP(value.Type, value.Setsecret_cnt, value.Generate_public_key_cnt, value.Compute_shared_secret_cnt, value.Err_cnt);
        }
    }
}}}}}}