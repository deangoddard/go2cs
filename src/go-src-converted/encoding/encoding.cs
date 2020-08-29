// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package encoding defines interfaces shared by other packages that
// convert data to and from byte-level and textual representations.
// Packages that check for these interfaces include encoding/gob,
// encoding/json, and encoding/xml. As a result, implementing an
// interface once can make a type useful in multiple encodings.
// Standard types that implement these interfaces include time.Time and net.IP.
// The interfaces come in pairs that produce and consume encoded data.
// package encoding -- go2cs converted at 2020 August 29 08:35:12 UTC
// import "encoding" ==> using encoding = go.encoding_package
// Original source: C:\Go\src\encoding\encoding.go

using static go.builtin;

namespace go
{
    public static partial class encoding_package
    {
        // BinaryMarshaler is the interface implemented by an object that can
        // marshal itself into a binary form.
        //
        // MarshalBinary encodes the receiver into a binary form and returns the result.
        public partial interface BinaryMarshaler
        {
            (slice<byte>, error) MarshalBinary();
        }

        // BinaryUnmarshaler is the interface implemented by an object that can
        // unmarshal a binary representation of itself.
        //
        // UnmarshalBinary must be able to decode the form generated by MarshalBinary.
        // UnmarshalBinary must copy the data if it wishes to retain the data
        // after returning.
        public partial interface BinaryUnmarshaler
        {
            error UnmarshalBinary(slice<byte> data);
        }

        // TextMarshaler is the interface implemented by an object that can
        // marshal itself into a textual form.
        //
        // MarshalText encodes the receiver into UTF-8-encoded text and returns the result.
        public partial interface TextMarshaler
        {
            (slice<byte>, error) MarshalText();
        }

        // TextUnmarshaler is the interface implemented by an object that can
        // unmarshal a textual representation of itself.
        //
        // UnmarshalText must be able to decode the form generated by MarshalText.
        // UnmarshalText must copy the text if it wishes to retain the text
        // after returning.
        public partial interface TextUnmarshaler
        {
            error UnmarshalText(slice<byte> text);
        }
    }
}
