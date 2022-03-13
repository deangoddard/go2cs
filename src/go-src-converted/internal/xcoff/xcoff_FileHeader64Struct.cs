//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:09 UTC
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
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct FileHeader64
        {
            // Constructors
            public FileHeader64(NilType _)
            {
                this.Fmagic = default;
                this.Fnscns = default;
                this.Ftimedat = default;
                this.Fsymptr = default;
                this.Fopthdr = default;
                this.Fflags = default;
                this.Fnsyms = default;
            }

            public FileHeader64(ushort Fmagic = default, ushort Fnscns = default, int Ftimedat = default, ulong Fsymptr = default, ushort Fopthdr = default, ushort Fflags = default, int Fnsyms = default)
            {
                this.Fmagic = Fmagic;
                this.Fnscns = Fnscns;
                this.Ftimedat = Ftimedat;
                this.Fsymptr = Fsymptr;
                this.Fopthdr = Fopthdr;
                this.Fflags = Fflags;
                this.Fnsyms = Fnsyms;
            }

            // Enable comparisons between nil and FileHeader64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FileHeader64 value, NilType nil) => value.Equals(default(FileHeader64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FileHeader64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FileHeader64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FileHeader64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FileHeader64(NilType nil) => default(FileHeader64);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static FileHeader64 FileHeader64_cast(dynamic value)
        {
            return new FileHeader64(value.Fmagic, value.Fnscns, value.Ftimedat, value.Fsymptr, value.Fopthdr, value.Fflags, value.Fnsyms);
        }
    }
}}