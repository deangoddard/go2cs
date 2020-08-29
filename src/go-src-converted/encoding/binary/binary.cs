// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package binary implements simple translation between numbers and byte
// sequences and encoding and decoding of varints.
//
// Numbers are translated by reading and writing fixed-size values.
// A fixed-size value is either a fixed-size arithmetic
// type (bool, int8, uint8, int16, float32, complex64, ...)
// or an array or struct containing only fixed-size values.
//
// The varint functions encode and decode single integer values using
// a variable-length encoding; smaller values require fewer bytes.
// For a specification, see
// https://developers.google.com/protocol-buffers/docs/encoding.
//
// This package favors simplicity over efficiency. Clients that require
// high-performance serialization, especially for large data structures,
// should look at more advanced solutions such as the encoding/gob
// package or protocol buffers.
// package binary -- go2cs converted at 2020 August 29 08:21:52 UTC
// import "encoding/binary" ==> using binary = go.encoding.binary_package
// Original source: C:\Go\src\encoding\binary\binary.go
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using reflect = go.reflect_package;
using static go.builtin;

namespace go {
namespace encoding
{
    public static partial class binary_package
    {
        // A ByteOrder specifies how to convert byte sequences into
        // 16-, 32-, or 64-bit unsigned integers.
        public partial interface ByteOrder
        {
            @string Uint16(slice<byte> _p0);
            @string Uint32(slice<byte> _p0);
            @string Uint64(slice<byte> _p0);
            @string PutUint16(slice<byte> _p0, ushort _p0);
            @string PutUint32(slice<byte> _p0, uint _p0);
            @string PutUint64(slice<byte> _p0, ulong _p0);
            @string String();
        }

        // LittleEndian is the little-endian implementation of ByteOrder.
        public static littleEndian LittleEndian = default;

        // BigEndian is the big-endian implementation of ByteOrder.
        public static bigEndian BigEndian = default;

        private partial struct littleEndian
        {
        }

        private static ushort Uint16(this littleEndian _p0, slice<byte> b)
        {
            _ = b[1L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint16(b[0L]) | uint16(b[1L]) << (int)(8L);
        }

        private static void PutUint16(this littleEndian _p0, slice<byte> b, ushort v)
        {
            _ = b[1L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v);
            b[1L] = byte(v >> (int)(8L));
        }

        private static uint Uint32(this littleEndian _p0, slice<byte> b)
        {
            _ = b[3L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint32(b[0L]) | uint32(b[1L]) << (int)(8L) | uint32(b[2L]) << (int)(16L) | uint32(b[3L]) << (int)(24L);
        }

        private static void PutUint32(this littleEndian _p0, slice<byte> b, uint v)
        {
            _ = b[3L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v);
            b[1L] = byte(v >> (int)(8L));
            b[2L] = byte(v >> (int)(16L));
            b[3L] = byte(v >> (int)(24L));
        }

        private static ulong Uint64(this littleEndian _p0, slice<byte> b)
        {
            _ = b[7L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint64(b[0L]) | uint64(b[1L]) << (int)(8L) | uint64(b[2L]) << (int)(16L) | uint64(b[3L]) << (int)(24L) | uint64(b[4L]) << (int)(32L) | uint64(b[5L]) << (int)(40L) | uint64(b[6L]) << (int)(48L) | uint64(b[7L]) << (int)(56L);
        }

        private static void PutUint64(this littleEndian _p0, slice<byte> b, ulong v)
        {
            _ = b[7L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v);
            b[1L] = byte(v >> (int)(8L));
            b[2L] = byte(v >> (int)(16L));
            b[3L] = byte(v >> (int)(24L));
            b[4L] = byte(v >> (int)(32L));
            b[5L] = byte(v >> (int)(40L));
            b[6L] = byte(v >> (int)(48L));
            b[7L] = byte(v >> (int)(56L));
        }

        private static @string String(this littleEndian _p0)
        {
            return "LittleEndian";
        }

        private static @string GoString(this littleEndian _p0)
        {
            return "binary.LittleEndian";
        }

        private partial struct bigEndian
        {
        }

        private static ushort Uint16(this bigEndian _p0, slice<byte> b)
        {
            _ = b[1L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint16(b[1L]) | uint16(b[0L]) << (int)(8L);
        }

        private static void PutUint16(this bigEndian _p0, slice<byte> b, ushort v)
        {
            _ = b[1L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v >> (int)(8L));
            b[1L] = byte(v);
        }

        private static uint Uint32(this bigEndian _p0, slice<byte> b)
        {
            _ = b[3L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint32(b[3L]) | uint32(b[2L]) << (int)(8L) | uint32(b[1L]) << (int)(16L) | uint32(b[0L]) << (int)(24L);
        }

        private static void PutUint32(this bigEndian _p0, slice<byte> b, uint v)
        {
            _ = b[3L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v >> (int)(24L));
            b[1L] = byte(v >> (int)(16L));
            b[2L] = byte(v >> (int)(8L));
            b[3L] = byte(v);
        }

        private static ulong Uint64(this bigEndian _p0, slice<byte> b)
        {
            _ = b[7L]; // bounds check hint to compiler; see golang.org/issue/14808
            return uint64(b[7L]) | uint64(b[6L]) << (int)(8L) | uint64(b[5L]) << (int)(16L) | uint64(b[4L]) << (int)(24L) | uint64(b[3L]) << (int)(32L) | uint64(b[2L]) << (int)(40L) | uint64(b[1L]) << (int)(48L) | uint64(b[0L]) << (int)(56L);
        }

        private static void PutUint64(this bigEndian _p0, slice<byte> b, ulong v)
        {
            _ = b[7L]; // early bounds check to guarantee safety of writes below
            b[0L] = byte(v >> (int)(56L));
            b[1L] = byte(v >> (int)(48L));
            b[2L] = byte(v >> (int)(40L));
            b[3L] = byte(v >> (int)(32L));
            b[4L] = byte(v >> (int)(24L));
            b[5L] = byte(v >> (int)(16L));
            b[6L] = byte(v >> (int)(8L));
            b[7L] = byte(v);
        }

        private static @string String(this bigEndian _p0)
        {
            return "BigEndian";
        }

        private static @string GoString(this bigEndian _p0)
        {
            return "binary.BigEndian";
        }

        // Read reads structured binary data from r into data.
        // Data must be a pointer to a fixed-size value or a slice
        // of fixed-size values.
        // Bytes read from r are decoded using the specified byte order
        // and written to successive fields of the data.
        // When decoding boolean values, a zero byte is decoded as false, and
        // any other non-zero byte is decoded as true.
        // When reading into structs, the field data for fields with
        // blank (_) field names is skipped; i.e., blank field names
        // may be used for padding.
        // When reading into a struct, all non-blank fields must be exported
        // or Read may panic.
        //
        // The error is EOF only if no bytes were read.
        // If an EOF happens after reading some but not all the bytes,
        // Read returns ErrUnexpectedEOF.
        public static error Read(io.Reader r, ByteOrder order, object data)
        { 
            // Fast path for basic types and slices.
            {
                var n = intDataSize(data);

                if (n != 0L)
                {
                    array<byte> b = new array<byte>(8L);
                    slice<byte> bs = default;
                    if (n > len(b))
                    {
                        bs = make_slice<byte>(n);
                    }
                    else
                    {
                        bs = b[..n];
                    }
                    {
                        var (_, err) = io.ReadFull(r, bs);

                        if (err != null)
                        {
                            return error.As(err);
                        }

                    }
                    switch (data.type())
                    {
                        case ref bool data:
                            data.Value = b[0L] != 0L;
                            break;
                        case ref sbyte data:
                            data.Value = int8(b[0L]);
                            break;
                        case ref byte data:
                            data.Value = b[0L];
                            break;
                        case ref short data:
                            data.Value = int16(order.Uint16(bs));
                            break;
                        case ref ushort data:
                            data.Value = order.Uint16(bs);
                            break;
                        case ref int data:
                            data.Value = int32(order.Uint32(bs));
                            break;
                        case ref uint data:
                            data.Value = order.Uint32(bs);
                            break;
                        case ref long data:
                            data.Value = int64(order.Uint64(bs));
                            break;
                        case ref ulong data:
                            data.Value = order.Uint64(bs);
                            break;
                        case slice<bool> data:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in bs)
                                {
                                    i = __i;
                                    x = __x; // Easier to loop over the input for 8-bit values.
                                    data[i] = x != 0L;
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case slice<sbyte> data:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in bs)
                                {
                                    i = __i;
                                    x = __x;
                                    data[i] = int8(x);
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case slice<byte> data:
                            copy(data, bs);
                            break;
                        case slice<short> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = int16(order.Uint16(bs[2L * i..]));
                                }

                                i = i__prev1;
                            }
                            break;
                        case slice<ushort> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = order.Uint16(bs[2L * i..]);
                                }

                                i = i__prev1;
                            }
                            break;
                        case slice<int> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = int32(order.Uint32(bs[4L * i..]));
                                }

                                i = i__prev1;
                            }
                            break;
                        case slice<uint> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = order.Uint32(bs[4L * i..]);
                                }

                                i = i__prev1;
                            }
                            break;
                        case slice<long> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = int64(order.Uint64(bs[8L * i..]));
                                }

                                i = i__prev1;
                            }
                            break;
                        case slice<ulong> data:
                            {
                                var i__prev1 = i;

                                foreach (var (__i) in data)
                                {
                                    i = __i;
                                    data[i] = order.Uint64(bs[8L * i..]);
                                }

                                i = i__prev1;
                            }
                            break;
                    }
                    return error.As(null);
                } 

                // Fallback to reflect-based decoding.

            } 

            // Fallback to reflect-based decoding.
            var v = reflect.ValueOf(data);
            long size = -1L;

            if (v.Kind() == reflect.Ptr) 
                v = v.Elem();
                size = dataSize(v);
            else if (v.Kind() == reflect.Slice) 
                size = dataSize(v);
                        if (size < 0L)
            {
                return error.As(errors.New("binary.Read: invalid type " + reflect.TypeOf(data).String()));
            }
            decoder d = ref new decoder(order:order,buf:make([]byte,size));
            {
                (_, err) = io.ReadFull(r, d.buf);

                if (err != null)
                {
                    return error.As(err);
                }

            }
            d.value(v);
            return error.As(null);
        }

        // Write writes the binary representation of data into w.
        // Data must be a fixed-size value or a slice of fixed-size
        // values, or a pointer to such data.
        // Boolean values encode as one byte: 1 for true, and 0 for false.
        // Bytes written to w are encoded using the specified byte order
        // and read from successive fields of the data.
        // When writing structs, zero values are written for fields
        // with blank (_) field names.
        public static error Write(io.Writer w, ByteOrder order, object data)
        { 
            // Fast path for basic types and slices.
            {
                var n = intDataSize(data);

                if (n != 0L)
                {
                    array<byte> b = new array<byte>(8L);
                    slice<byte> bs = default;
                    if (n > len(b))
                    {
                        bs = make_slice<byte>(n);
                    }
                    else
                    {
                        bs = b[..n];
                    }
                    switch (data.type())
                    {
                        case ref bool v:
                            if (v.Value)
                            {
                                b[0L] = 1L;
                            }
                            else
                            {
                                b[0L] = 0L;
                            }
                            break;
                        case bool v:
                            if (v)
                            {
                                b[0L] = 1L;
                            }
                            else
                            {
                                b[0L] = 0L;
                            }
                            break;
                        case slice<bool> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    if (x)
                                    {
                                        bs[i] = 1L;
                                    }
                                    else
                                    {
                                        bs[i] = 0L;
                                    }
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref sbyte v:
                            b[0L] = byte(v.Value);
                            break;
                        case sbyte v:
                            b[0L] = byte(v);
                            break;
                        case slice<sbyte> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    bs[i] = byte(x);
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref byte v:
                            b[0L] = v.Value;
                            break;
                        case byte v:
                            b[0L] = v;
                            break;
                        case slice<byte> v:
                            bs = v;
                            break;
                        case ref short v:
                            order.PutUint16(bs, uint16(v.Value));
                            break;
                        case short v:
                            order.PutUint16(bs, uint16(v));
                            break;
                        case slice<short> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint16(bs[2L * i..], uint16(x));
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref ushort v:
                            order.PutUint16(bs, v.Value);
                            break;
                        case ushort v:
                            order.PutUint16(bs, v);
                            break;
                        case slice<ushort> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint16(bs[2L * i..], x);
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref int v:
                            order.PutUint32(bs, uint32(v.Value));
                            break;
                        case int v:
                            order.PutUint32(bs, uint32(v));
                            break;
                        case slice<int> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint32(bs[4L * i..], uint32(x));
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref uint v:
                            order.PutUint32(bs, v.Value);
                            break;
                        case uint v:
                            order.PutUint32(bs, v);
                            break;
                        case slice<uint> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint32(bs[4L * i..], x);
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref long v:
                            order.PutUint64(bs, uint64(v.Value));
                            break;
                        case long v:
                            order.PutUint64(bs, uint64(v));
                            break;
                        case slice<long> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint64(bs[8L * i..], uint64(x));
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                        case ref ulong v:
                            order.PutUint64(bs, v.Value);
                            break;
                        case ulong v:
                            order.PutUint64(bs, v);
                            break;
                        case slice<ulong> v:
                            {
                                var i__prev1 = i;
                                var x__prev1 = x;

                                foreach (var (__i, __x) in v)
                                {
                                    i = __i;
                                    x = __x;
                                    order.PutUint64(bs[8L * i..], x);
                                }

                                i = i__prev1;
                                x = x__prev1;
                            }
                            break;
                    }
                    var (_, err) = w.Write(bs);
                    return error.As(err);
                } 

                // Fallback to reflect-based encoding.

            } 

            // Fallback to reflect-based encoding.
            var v = reflect.Indirect(reflect.ValueOf(data));
            var size = dataSize(v);
            if (size < 0L)
            {
                return error.As(errors.New("binary.Write: invalid type " + reflect.TypeOf(data).String()));
            }
            var buf = make_slice<byte>(size);
            encoder e = ref new encoder(order:order,buf:buf);
            e.value(v);
            (_, err) = w.Write(buf);
            return error.As(err);
        }

        // Size returns how many bytes Write would generate to encode the value v, which
        // must be a fixed-size value or a slice of fixed-size values, or a pointer to such data.
        // If v is neither of these, Size returns -1.
        public static long Size(object v)
        {
            return dataSize(reflect.Indirect(reflect.ValueOf(v)));
        }

        // dataSize returns the number of bytes the actual data represented by v occupies in memory.
        // For compound structures, it sums the sizes of the elements. Thus, for instance, for a slice
        // it returns the length of the slice times the element size and does not count the memory
        // occupied by the header. If the type of v is not acceptable, dataSize returns -1.
        private static long dataSize(reflect.Value v)
        {
            if (v.Kind() == reflect.Slice)
            {
                {
                    var s = sizeof(v.Type().Elem());

                    if (s >= 0L)
                    {
                        return s * v.Len();
                    }

                }
                return -1L;
            }
            return sizeof(v.Type());
        }

        // sizeof returns the size >= 0 of variables for the given type or -1 if the type is not acceptable.
        private static long @sizeof(reflect.Type t)
        {

            if (t.Kind() == reflect.Array) 
                {
                    var s__prev1 = s;

                    var s = sizeof(t.Elem());

                    if (s >= 0L)
                    {
                        return s * t.Len();
                    }

                    s = s__prev1;

                }
            else if (t.Kind() == reflect.Struct) 
                long sum = 0L;
                for (long i = 0L;
                var n = t.NumField(); i < n; i++)
                {
                    s = sizeof(t.Field(i).Type);
                    if (s < 0L)
                    {
                        return -1L;
                    }
                    sum += s;
                }

                return sum;
            else if (t.Kind() == reflect.Bool || t.Kind() == reflect.Uint8 || t.Kind() == reflect.Uint16 || t.Kind() == reflect.Uint32 || t.Kind() == reflect.Uint64 || t.Kind() == reflect.Int8 || t.Kind() == reflect.Int16 || t.Kind() == reflect.Int32 || t.Kind() == reflect.Int64 || t.Kind() == reflect.Float32 || t.Kind() == reflect.Float64 || t.Kind() == reflect.Complex64 || t.Kind() == reflect.Complex128) 
                return int(t.Size());
                        return -1L;
        }

        private partial struct coder
        {
            public ByteOrder order;
            public slice<byte> buf;
        }

        private partial struct decoder // : coder
        {
        }
        private partial struct encoder // : coder
        {
        }

        private static bool @bool(this ref decoder d)
        {
            var x = d.buf[0L];
            d.buf = d.buf[1L..];
            return x != 0L;
        }

        private static void @bool(this ref encoder e, bool x)
        {
            if (x)
            {
                e.buf[0L] = 1L;
            }
            else
            {
                e.buf[0L] = 0L;
            }
            e.buf = e.buf[1L..];
        }

        private static byte uint8(this ref decoder d)
        {
            var x = d.buf[0L];
            d.buf = d.buf[1L..];
            return x;
        }

        private static void uint8(this ref encoder e, byte x)
        {
            e.buf[0L] = x;
            e.buf = e.buf[1L..];
        }

        private static ushort uint16(this ref decoder d)
        {
            var x = d.order.Uint16(d.buf[0L..2L]);
            d.buf = d.buf[2L..];
            return x;
        }

        private static void uint16(this ref encoder e, ushort x)
        {
            e.order.PutUint16(e.buf[0L..2L], x);
            e.buf = e.buf[2L..];
        }

        private static uint uint32(this ref decoder d)
        {
            var x = d.order.Uint32(d.buf[0L..4L]);
            d.buf = d.buf[4L..];
            return x;
        }

        private static void uint32(this ref encoder e, uint x)
        {
            e.order.PutUint32(e.buf[0L..4L], x);
            e.buf = e.buf[4L..];
        }

        private static ulong uint64(this ref decoder d)
        {
            var x = d.order.Uint64(d.buf[0L..8L]);
            d.buf = d.buf[8L..];
            return x;
        }

        private static void uint64(this ref encoder e, ulong x)
        {
            e.order.PutUint64(e.buf[0L..8L], x);
            e.buf = e.buf[8L..];
        }

        private static sbyte int8(this ref decoder d)
        {
            return int8(d.uint8());
        }

        private static void int8(this ref encoder e, sbyte x)
        {
            e.uint8(uint8(x));

        }

        private static short int16(this ref decoder d)
        {
            return int16(d.uint16());
        }

        private static void int16(this ref encoder e, short x)
        {
            e.uint16(uint16(x));

        }

        private static int int32(this ref decoder d)
        {
            return int32(d.uint32());
        }

        private static void int32(this ref encoder e, int x)
        {
            e.uint32(uint32(x));

        }

        private static long int64(this ref decoder d)
        {
            return int64(d.uint64());
        }

        private static void int64(this ref encoder e, long x)
        {
            e.uint64(uint64(x));

        }

        private static void value(this ref decoder d, reflect.Value v)
        {

            if (v.Kind() == reflect.Array) 
                var l = v.Len();
                {
                    long i__prev1 = i;

                    for (long i = 0L; i < l; i++)
                    {
                        d.value(v.Index(i));
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Struct) 
                var t = v.Type();
                l = v.NumField();
                {
                    long i__prev1 = i;

                    for (i = 0L; i < l; i++)
                    { 
                        // Note: Calling v.CanSet() below is an optimization.
                        // It would be sufficient to check the field name,
                        // but creating the StructField info for each field is
                        // costly (run "go test -bench=ReadStruct" and compare
                        // results when making changes to this code).
                        {
                            var v = v.Field(i);

                            if (v.CanSet() || t.Field(i).Name != "_")
                            {
                                d.value(v);
                            }
                            else
                            {
                                d.skip(v);
                            }

                        }
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Slice) 
                l = v.Len();
                {
                    long i__prev1 = i;

                    for (i = 0L; i < l; i++)
                    {
                        d.value(v.Index(i));
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Bool) 
                v.SetBool(d.@bool());
            else if (v.Kind() == reflect.Int8) 
                v.SetInt(int64(d.int8()));
            else if (v.Kind() == reflect.Int16) 
                v.SetInt(int64(d.int16()));
            else if (v.Kind() == reflect.Int32) 
                v.SetInt(int64(d.int32()));
            else if (v.Kind() == reflect.Int64) 
                v.SetInt(d.int64());
            else if (v.Kind() == reflect.Uint8) 
                v.SetUint(uint64(d.uint8()));
            else if (v.Kind() == reflect.Uint16) 
                v.SetUint(uint64(d.uint16()));
            else if (v.Kind() == reflect.Uint32) 
                v.SetUint(uint64(d.uint32()));
            else if (v.Kind() == reflect.Uint64) 
                v.SetUint(d.uint64());
            else if (v.Kind() == reflect.Float32) 
                v.SetFloat(float64(math.Float32frombits(d.uint32())));
            else if (v.Kind() == reflect.Float64) 
                v.SetFloat(math.Float64frombits(d.uint64()));
            else if (v.Kind() == reflect.Complex64) 
                v.SetComplex(complex(float64(math.Float32frombits(d.uint32())), float64(math.Float32frombits(d.uint32()))));
            else if (v.Kind() == reflect.Complex128) 
                v.SetComplex(complex(math.Float64frombits(d.uint64()), math.Float64frombits(d.uint64())));
                    }

        private static void value(this ref encoder e, reflect.Value v)
        {

            if (v.Kind() == reflect.Array) 
                var l = v.Len();
                {
                    long i__prev1 = i;

                    for (long i = 0L; i < l; i++)
                    {
                        e.value(v.Index(i));
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Struct) 
                var t = v.Type();
                l = v.NumField();
                {
                    long i__prev1 = i;

                    for (i = 0L; i < l; i++)
                    { 
                        // see comment for corresponding code in decoder.value()
                        {
                            var v = v.Field(i);

                            if (v.CanSet() || t.Field(i).Name != "_")
                            {
                                e.value(v);
                            }
                            else
                            {
                                e.skip(v);
                            }

                        }
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Slice) 
                l = v.Len();
                {
                    long i__prev1 = i;

                    for (i = 0L; i < l; i++)
                    {
                        e.value(v.Index(i));
                    }


                    i = i__prev1;
                }
            else if (v.Kind() == reflect.Bool) 
                e.@bool(v.Bool());
            else if (v.Kind() == reflect.Int || v.Kind() == reflect.Int8 || v.Kind() == reflect.Int16 || v.Kind() == reflect.Int32 || v.Kind() == reflect.Int64) 

                if (v.Type().Kind() == reflect.Int8) 
                    e.int8(int8(v.Int()));
                else if (v.Type().Kind() == reflect.Int16) 
                    e.int16(int16(v.Int()));
                else if (v.Type().Kind() == reflect.Int32) 
                    e.int32(int32(v.Int()));
                else if (v.Type().Kind() == reflect.Int64) 
                    e.int64(v.Int());
                            else if (v.Kind() == reflect.Uint || v.Kind() == reflect.Uint8 || v.Kind() == reflect.Uint16 || v.Kind() == reflect.Uint32 || v.Kind() == reflect.Uint64 || v.Kind() == reflect.Uintptr) 

                if (v.Type().Kind() == reflect.Uint8) 
                    e.uint8(uint8(v.Uint()));
                else if (v.Type().Kind() == reflect.Uint16) 
                    e.uint16(uint16(v.Uint()));
                else if (v.Type().Kind() == reflect.Uint32) 
                    e.uint32(uint32(v.Uint()));
                else if (v.Type().Kind() == reflect.Uint64) 
                    e.uint64(v.Uint());
                            else if (v.Kind() == reflect.Float32 || v.Kind() == reflect.Float64) 

                if (v.Type().Kind() == reflect.Float32) 
                    e.uint32(math.Float32bits(float32(v.Float())));
                else if (v.Type().Kind() == reflect.Float64) 
                    e.uint64(math.Float64bits(v.Float()));
                            else if (v.Kind() == reflect.Complex64 || v.Kind() == reflect.Complex128) 

                if (v.Type().Kind() == reflect.Complex64) 
                    var x = v.Complex();
                    e.uint32(math.Float32bits(float32(real(x))));
                    e.uint32(math.Float32bits(float32(imag(x))));
                else if (v.Type().Kind() == reflect.Complex128) 
                    x = v.Complex();
                    e.uint64(math.Float64bits(real(x)));
                    e.uint64(math.Float64bits(imag(x)));
                                    }

        private static void skip(this ref decoder d, reflect.Value v)
        {
            d.buf = d.buf[dataSize(v)..];
        }

        private static void skip(this ref encoder e, reflect.Value v)
        {
            var n = dataSize(v);
            foreach (var (i) in e.buf[0L..n])
            {
                e.buf[i] = 0L;
            }
            e.buf = e.buf[n..];
        }

        // intDataSize returns the size of the data required to represent the data when encoded.
        // It returns zero if the type cannot be implemented by the fast path in Read or Write.
        private static long intDataSize(object data)
        {
            switch (data.type())
            {
                case bool data:
                    return 1L;
                    break;
                case sbyte data:
                    return 1L;
                    break;
                case byte data:
                    return 1L;
                    break;
                case ref bool data:
                    return 1L;
                    break;
                case ref sbyte data:
                    return 1L;
                    break;
                case ref byte data:
                    return 1L;
                    break;
                case slice<sbyte> data:
                    return len(data);
                    break;
                case slice<byte> data:
                    return len(data);
                    break;
                case short data:
                    return 2L;
                    break;
                case ushort data:
                    return 2L;
                    break;
                case ref short data:
                    return 2L;
                    break;
                case ref ushort data:
                    return 2L;
                    break;
                case slice<short> data:
                    return 2L * len(data);
                    break;
                case slice<ushort> data:
                    return 2L * len(data);
                    break;
                case int data:
                    return 4L;
                    break;
                case uint data:
                    return 4L;
                    break;
                case ref int data:
                    return 4L;
                    break;
                case ref uint data:
                    return 4L;
                    break;
                case slice<int> data:
                    return 4L * len(data);
                    break;
                case slice<uint> data:
                    return 4L * len(data);
                    break;
                case long data:
                    return 8L;
                    break;
                case ulong data:
                    return 8L;
                    break;
                case ref long data:
                    return 8L;
                    break;
                case ref ulong data:
                    return 8L;
                    break;
                case slice<long> data:
                    return 8L * len(data);
                    break;
                case slice<ulong> data:
                    return 8L * len(data);
                    break;
            }
            return 0L;
        }
    }
}}
