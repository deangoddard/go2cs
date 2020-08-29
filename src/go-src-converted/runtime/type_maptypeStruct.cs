//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct maptype
        {
            // Constructors
            public maptype(NilType _)
            {
                this.typ = default;
                this.key = default;
                this.elem = default;
                this.bucket = default;
                this.hmap = default;
                this.keysize = default;
                this.indirectkey = default;
                this.valuesize = default;
                this.indirectvalue = default;
                this.bucketsize = default;
                this.reflexivekey = default;
                this.needkeyupdate = default;
            }

            public maptype(_type typ = default, ref ptr<_type> key = default, ref ptr<_type> elem = default, ref ptr<_type> bucket = default, ref ptr<_type> hmap = default, byte keysize = default, bool indirectkey = default, byte valuesize = default, bool indirectvalue = default, ushort bucketsize = default, bool reflexivekey = default, bool needkeyupdate = default)
            {
                this.typ = typ;
                this.key = key;
                this.elem = elem;
                this.bucket = bucket;
                this.hmap = hmap;
                this.keysize = keysize;
                this.indirectkey = indirectkey;
                this.valuesize = valuesize;
                this.indirectvalue = indirectvalue;
                this.bucketsize = bucketsize;
                this.reflexivekey = reflexivekey;
                this.needkeyupdate = needkeyupdate;
            }

            // Enable comparisons between nil and maptype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(maptype value, NilType nil) => value.Equals(default(maptype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(maptype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, maptype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, maptype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator maptype(NilType nil) => default(maptype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static maptype maptype_cast(dynamic value)
        {
            return new maptype(value.typ, ref value.key, ref value.elem, ref value.bucket, ref value.hmap, value.keysize, value.indirectkey, value.valuesize, value.indirectvalue, value.bucketsize, value.reflexivekey, value.needkeyupdate);
        }
    }
}