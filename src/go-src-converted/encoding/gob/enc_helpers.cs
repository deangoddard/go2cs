// Code generated by go run encgen.go -output enc_helpers.go; DO NOT EDIT.

// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package gob -- go2cs converted at 2020 October 09 04:59:58 UTC
// import "encoding/gob" ==> using gob = go.encoding.gob_package
// Original source: C:\Go\src\encoding\gob\enc_helpers.go
using reflect = go.reflect_package;
using static go.builtin;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        private static map encArrayHelper = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<reflect.Kind, encHelper>{reflect.Bool:encBoolArray,reflect.Complex64:encComplex64Array,reflect.Complex128:encComplex128Array,reflect.Float32:encFloat32Array,reflect.Float64:encFloat64Array,reflect.Int:encIntArray,reflect.Int16:encInt16Array,reflect.Int32:encInt32Array,reflect.Int64:encInt64Array,reflect.Int8:encInt8Array,reflect.String:encStringArray,reflect.Uint:encUintArray,reflect.Uint16:encUint16Array,reflect.Uint32:encUint32Array,reflect.Uint64:encUint64Array,reflect.Uintptr:encUintptrArray,};

        private static map encSliceHelper = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<reflect.Kind, encHelper>{reflect.Bool:encBoolSlice,reflect.Complex64:encComplex64Slice,reflect.Complex128:encComplex128Slice,reflect.Float32:encFloat32Slice,reflect.Float64:encFloat64Slice,reflect.Int:encIntSlice,reflect.Int16:encInt16Slice,reflect.Int32:encInt32Slice,reflect.Int64:encInt64Slice,reflect.Int8:encInt8Slice,reflect.String:encStringSlice,reflect.Uint:encUintSlice,reflect.Uint16:encUint16Slice,reflect.Uint32:encUint32Slice,reflect.Uint64:encUint64Slice,reflect.Uintptr:encUintptrSlice,};

        private static bool encBoolArray(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encBoolSlice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encBoolSlice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<bool> (slice, ok) = v.Interface()._<slice<bool>>();
            if (!ok)
            { 
                // It is kind bool but not type bool. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != false || state.sendZero)
                {
                    if (x)
                    {
                        state.encodeUint(1L);
                    }
                    else
                    {
                        state.encodeUint(0L);
                    }

                }

            }
            return true;

        }

        private static bool encComplex64Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encComplex64Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encComplex64Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<complex64> (slice, ok) = v.Interface()._<slice<complex64>>();
            if (!ok)
            { 
                // It is kind complex64 but not type complex64. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L + 0iUL || state.sendZero)
                {
                    var rpart = floatBits(float64(real(x)));
                    var ipart = floatBits(float64(imag(x)));
                    state.encodeUint(rpart);
                    state.encodeUint(ipart);
                }

            }
            return true;

        }

        private static bool encComplex128Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encComplex128Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encComplex128Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<System.Numerics.Complex128> (slice, ok) = v.Interface()._<slice<System.Numerics.Complex128>>();
            if (!ok)
            { 
                // It is kind complex128 but not type complex128. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L + 0iUL || state.sendZero)
                {
                    var rpart = floatBits(real(x));
                    var ipart = floatBits(imag(x));
                    state.encodeUint(rpart);
                    state.encodeUint(ipart);
                }

            }
            return true;

        }

        private static bool encFloat32Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encFloat32Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encFloat32Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<float> (slice, ok) = v.Interface()._<slice<float>>();
            if (!ok)
            { 
                // It is kind float32 but not type float32. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    var bits = floatBits(float64(x));
                    state.encodeUint(bits);
                }

            }
            return true;

        }

        private static bool encFloat64Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encFloat64Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encFloat64Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<double> (slice, ok) = v.Interface()._<slice<double>>();
            if (!ok)
            { 
                // It is kind float64 but not type float64. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    var bits = floatBits(x);
                    state.encodeUint(bits);
                }

            }
            return true;

        }

        private static bool encIntArray(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encIntSlice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encIntSlice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<long> (slice, ok) = v.Interface()._<slice<long>>();
            if (!ok)
            { 
                // It is kind int but not type int. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeInt(int64(x));
                }

            }
            return true;

        }

        private static bool encInt16Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encInt16Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encInt16Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<short> (slice, ok) = v.Interface()._<slice<short>>();
            if (!ok)
            { 
                // It is kind int16 but not type int16. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeInt(int64(x));
                }

            }
            return true;

        }

        private static bool encInt32Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encInt32Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encInt32Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<int> (slice, ok) = v.Interface()._<slice<int>>();
            if (!ok)
            { 
                // It is kind int32 but not type int32. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeInt(int64(x));
                }

            }
            return true;

        }

        private static bool encInt64Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encInt64Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encInt64Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<long> (slice, ok) = v.Interface()._<slice<long>>();
            if (!ok)
            { 
                // It is kind int64 but not type int64. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeInt(x);
                }

            }
            return true;

        }

        private static bool encInt8Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encInt8Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encInt8Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<sbyte> (slice, ok) = v.Interface()._<slice<sbyte>>();
            if (!ok)
            { 
                // It is kind int8 but not type int8. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeInt(int64(x));
                }

            }
            return true;

        }

        private static bool encStringArray(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encStringSlice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encStringSlice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<@string> (slice, ok) = v.Interface()._<slice<@string>>();
            if (!ok)
            { 
                // It is kind string but not type string. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != "" || state.sendZero)
                {
                    state.encodeUint(uint64(len(x)));
                    state.b.WriteString(x);
                }

            }
            return true;

        }

        private static bool encUintArray(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encUintSlice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encUintSlice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<ulong> (slice, ok) = v.Interface()._<slice<ulong>>();
            if (!ok)
            { 
                // It is kind uint but not type uint. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeUint(uint64(x));
                }

            }
            return true;

        }

        private static bool encUint16Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encUint16Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encUint16Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<ushort> (slice, ok) = v.Interface()._<slice<ushort>>();
            if (!ok)
            { 
                // It is kind uint16 but not type uint16. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeUint(uint64(x));
                }

            }
            return true;

        }

        private static bool encUint32Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encUint32Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encUint32Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<uint> (slice, ok) = v.Interface()._<slice<uint>>();
            if (!ok)
            { 
                // It is kind uint32 but not type uint32. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeUint(uint64(x));
                }

            }
            return true;

        }

        private static bool encUint64Array(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encUint64Slice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encUint64Slice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<ulong> (slice, ok) = v.Interface()._<slice<ulong>>();
            if (!ok)
            { 
                // It is kind uint64 but not type uint64. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeUint(x);
                }

            }
            return true;

        }

        private static bool encUintptrArray(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;
 
            // Can only slice if it is addressable.
            if (!v.CanAddr())
            {
                return false;
            }

            return encUintptrSlice(_addr_state, v.Slice(0L, v.Len()));

        }

        private static bool encUintptrSlice(ptr<encoderState> _addr_state, reflect.Value v)
        {
            ref encoderState state = ref _addr_state.val;

            slice<System.UIntPtr> (slice, ok) = v.Interface()._<slice<System.UIntPtr>>();
            if (!ok)
            { 
                // It is kind uintptr but not type uintptr. TODO: We can handle this unsafely.
                return false;

            }

            foreach (var (_, x) in slice)
            {
                if (x != 0L || state.sendZero)
                {
                    state.encodeUint(uint64(x));
                }

            }
            return true;

        }
    }
}}
