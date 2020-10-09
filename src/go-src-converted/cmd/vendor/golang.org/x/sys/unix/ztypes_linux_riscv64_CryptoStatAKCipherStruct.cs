//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:41 UTC
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
        public partial struct CryptoStatAKCipher
        {
            // Constructors
            public CryptoStatAKCipher(NilType _)
            {
                this.Type = default;
                this.Encrypt_cnt = default;
                this.Encrypt_tlen = default;
                this.Decrypt_cnt = default;
                this.Decrypt_tlen = default;
                this.Verify_cnt = default;
                this.Sign_cnt = default;
                this.Err_cnt = default;
            }

            public CryptoStatAKCipher(array<byte> Type = default, ulong Encrypt_cnt = default, ulong Encrypt_tlen = default, ulong Decrypt_cnt = default, ulong Decrypt_tlen = default, ulong Verify_cnt = default, ulong Sign_cnt = default, ulong Err_cnt = default)
            {
                this.Type = Type;
                this.Encrypt_cnt = Encrypt_cnt;
                this.Encrypt_tlen = Encrypt_tlen;
                this.Decrypt_cnt = Decrypt_cnt;
                this.Decrypt_tlen = Decrypt_tlen;
                this.Verify_cnt = Verify_cnt;
                this.Sign_cnt = Sign_cnt;
                this.Err_cnt = Err_cnt;
            }

            // Enable comparisons between nil and CryptoStatAKCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoStatAKCipher value, NilType nil) => value.Equals(default(CryptoStatAKCipher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoStatAKCipher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoStatAKCipher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoStatAKCipher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoStatAKCipher(NilType nil) => default(CryptoStatAKCipher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoStatAKCipher CryptoStatAKCipher_cast(dynamic value)
        {
            return new CryptoStatAKCipher(value.Type, value.Encrypt_cnt, value.Encrypt_tlen, value.Decrypt_cnt, value.Decrypt_tlen, value.Verify_cnt, value.Sign_cnt, value.Err_cnt);
        }
    }
}}}}}}