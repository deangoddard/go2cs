// Copyright 2010 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.
//

/*
Package multipart implements MIME multipart parsing, as defined in RFC
2046.

The implementation is sufficient for HTTP (RFC 2388) and the multipart
bodies generated by popular browsers.
*/
// package multipart -- go2cs converted at 2022 March 06 22:21:13 UTC
// import "mime/multipart" ==> using multipart = go.mime.multipart_package
// Original source: C:\Program Files\Go\src\mime\multipart\multipart.go
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using mime = go.mime_package;
using quotedprintable = go.mime.quotedprintable_package;
using textproto = go.net.textproto_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;

namespace go.mime;

public static partial class multipart_package {

private static var emptyParams = make_map<@string, @string>();

// This constant needs to be at least 76 for this package to work correctly.
// This is because \r\n--separator_of_len_70- would fill the buffer and it
// wouldn't be safe to consume a single byte from it.
private static readonly nint peekBufferSize = 4096;

// A Part represents a single part in a multipart body.


// A Part represents a single part in a multipart body.
public partial struct Part {
    public textproto.MIMEHeader Header;
    public ptr<Reader> mr;
    public @string disposition;
    public map<@string, @string> dispositionParams; // r is either a reader directly reading from mr, or it's a
// wrapper around such a reader, decoding the
// Content-Transfer-Encoding
    public io.Reader r;
    public nint n; // known data bytes waiting in mr.bufReader
    public long total; // total data bytes read already
    public error err; // error to return when n == 0
    public error readErr; // read error observed from mr.bufReader
}

// FormName returns the name parameter if p has a Content-Disposition
// of type "form-data".  Otherwise it returns the empty string.
private static @string FormName(this ptr<Part> _addr_p) {
    ref Part p = ref _addr_p.val;
 
    // See https://tools.ietf.org/html/rfc2183 section 2 for EBNF
    // of Content-Disposition value format.
    if (p.dispositionParams == null) {
        p.parseContentDisposition();
    }
    if (p.disposition != "form-data") {
        return "";
    }
    return p.dispositionParams["name"];

}

// FileName returns the filename parameter of the Part's Content-Disposition
// header. If not empty, the filename is passed through filepath.Base (which is
// platform dependent) before being returned.
private static @string FileName(this ptr<Part> _addr_p) {
    ref Part p = ref _addr_p.val;

    if (p.dispositionParams == null) {
        p.parseContentDisposition();
    }
    var filename = p.dispositionParams["filename"];
    if (filename == "") {
        return "";
    }
    return filepath.Base(filename);

}

private static void parseContentDisposition(this ptr<Part> _addr_p) {
    ref Part p = ref _addr_p.val;

    var v = p.Header.Get("Content-Disposition");
    error err = default!;
    p.disposition, p.dispositionParams, err = mime.ParseMediaType(v);
    if (err != null) {
        p.dispositionParams = emptyParams;
    }
}

// NewReader creates a new multipart Reader reading from r using the
// given MIME boundary.
//
// The boundary is usually obtained from the "boundary" parameter of
// the message's "Content-Type" header. Use mime.ParseMediaType to
// parse such headers.
public static ptr<Reader> NewReader(io.Reader r, @string boundary) {
    slice<byte> b = (slice<byte>)"\r\n--" + boundary + "--";
    return addr(new Reader(bufReader:bufio.NewReaderSize(&stickyErrorReader{r:r},peekBufferSize),nl:b[:2],nlDashBoundary:b[:len(b)-2],dashBoundaryDash:b[2:],dashBoundary:b[2:len(b)-2],));
}

// stickyErrorReader is an io.Reader which never calls Read on its
// underlying Reader once an error has been seen. (the io.Reader
// interface's contract promises nothing about the return values of
// Read calls after an error, yet this package does do multiple Reads
// after error)
private partial struct stickyErrorReader {
    public io.Reader r;
    public error err;
}

private static (nint, error) Read(this ptr<stickyErrorReader> _addr_r, slice<byte> p) {
    nint n = default;
    error _ = default!;
    ref stickyErrorReader r = ref _addr_r.val;

    if (r.err != null) {
        return (0, error.As(r.err)!);
    }
    n, r.err = r.r.Read(p);
    return (n, error.As(r.err)!);

}

private static (ptr<Part>, error) newPart(ptr<Reader> _addr_mr, bool rawPart) {
    ptr<Part> _p0 = default!;
    error _p0 = default!;
    ref Reader mr = ref _addr_mr.val;

    ptr<Part> bp = addr(new Part(Header:make(map[string][]string),mr:mr,));
    {
        var err = bp.populateHeaders();

        if (err != null) {
            return (_addr_null!, error.As(err)!);
        }
    }

    bp.r = new partReader(bp); 

    // rawPart is used to switch between Part.NextPart and Part.NextRawPart.
    if (!rawPart) {
        const @string cte = "Content-Transfer-Encoding";

        if (strings.EqualFold(bp.Header.Get(cte), "quoted-printable")) {
            bp.Header.Del(cte);
            bp.r = quotedprintable.NewReader(bp.r);
        }
    }
    return (_addr_bp!, error.As(null!)!);

}

private static error populateHeaders(this ptr<Part> _addr_bp) {
    ref Part bp = ref _addr_bp.val;

    var r = textproto.NewReader(bp.mr.bufReader);
    var (header, err) = r.ReadMIMEHeader();
    if (err == null) {
        bp.Header = header;
    }
    return error.As(err)!;

}

// Read reads the body of a part, after its headers and before the
// next part (if any) begins.
private static (nint, error) Read(this ptr<Part> _addr_p, slice<byte> d) {
    nint n = default;
    error err = default!;
    ref Part p = ref _addr_p.val;

    return p.r.Read(d);
}

// partReader implements io.Reader by reading raw bytes directly from the
// wrapped *Part, without doing any Transfer-Encoding decoding.
private partial struct partReader {
    public ptr<Part> p;
}

private static (nint, error) Read(this partReader pr, slice<byte> d) {
    nint _p0 = default;
    error _p0 = default!;

    var p = pr.p;
    var br = p.mr.bufReader; 

    // Read into buffer until we identify some data to return,
    // or we find a reason to stop (boundary or read error).
    while (p.n == 0 && p.err == null) {
        var (peek, _) = br.Peek(br.Buffered());
        p.n, p.err = scanUntilBoundary(peek, p.mr.dashBoundary, p.mr.nlDashBoundary, p.total, p.readErr);
        if (p.n == 0 && p.err == null) { 
            // Force buffered I/O to read more into buffer.
            _, p.readErr = br.Peek(len(peek) + 1);
            if (p.readErr == io.EOF) {
                p.readErr = io.ErrUnexpectedEOF;
            }

        }
    } 

    // Read out from "data to return" part of buffer.
    if (p.n == 0) {
        return (0, error.As(p.err)!);
    }
    var n = len(d);
    if (n > p.n) {
        n = p.n;
    }
    n, _ = br.Read(d[..(int)n]);
    p.total += int64(n);
    p.n -= n;
    if (p.n == 0) {
        return (n, error.As(p.err)!);
    }
    return (n, error.As(null!)!);

}

// scanUntilBoundary scans buf to identify how much of it can be safely
// returned as part of the Part body.
// dashBoundary is "--boundary".
// nlDashBoundary is "\r\n--boundary" or "\n--boundary", depending on what mode we are in.
// The comments below (and the name) assume "\n--boundary", but either is accepted.
// total is the number of bytes read out so far. If total == 0, then a leading "--boundary" is recognized.
// readErr is the read error, if any, that followed reading the bytes in buf.
// scanUntilBoundary returns the number of data bytes from buf that can be
// returned as part of the Part body and also the error to return (if any)
// once those data bytes are done.
private static (nint, error) scanUntilBoundary(slice<byte> buf, slice<byte> dashBoundary, slice<byte> nlDashBoundary, long total, error readErr) {
    nint _p0 = default;
    error _p0 = default!;

    if (total == 0) { 
        // At beginning of body, allow dashBoundary.
        if (bytes.HasPrefix(buf, dashBoundary)) {
            switch (matchAfterPrefix(buf, dashBoundary, readErr)) {
                case -1: 
                    return (len(dashBoundary), error.As(null!)!);
                    break;
                case 0: 
                    return (0, error.As(null!)!);
                    break;
                case +1: 
                    return (0, error.As(io.EOF)!);
                    break;
            }

        }
        if (bytes.HasPrefix(dashBoundary, buf)) {
            return (0, error.As(readErr)!);
        }
    }
    {
        var i__prev1 = i;

        var i = bytes.Index(buf, nlDashBoundary);

        if (i >= 0) {
            switch (matchAfterPrefix(buf[(int)i..], nlDashBoundary, readErr)) {
                case -1: 
                    return (i + len(nlDashBoundary), error.As(null!)!);
                    break;
                case 0: 
                    return (i, error.As(null!)!);
                    break;
                case +1: 
                    return (i, error.As(io.EOF)!);
                    break;
            }

        }
        i = i__prev1;

    }

    if (bytes.HasPrefix(nlDashBoundary, buf)) {
        return (0, error.As(readErr)!);
    }
    i = bytes.LastIndexByte(buf, nlDashBoundary[0]);
    if (i >= 0 && bytes.HasPrefix(nlDashBoundary, buf[(int)i..])) {
        return (i, error.As(null!)!);
    }
    return (len(buf), error.As(readErr)!);

}

// matchAfterPrefix checks whether buf should be considered to match the boundary.
// The prefix is "--boundary" or "\r\n--boundary" or "\n--boundary",
// and the caller has verified already that bytes.HasPrefix(buf, prefix) is true.
//
// matchAfterPrefix returns +1 if the buffer does match the boundary,
// meaning the prefix is followed by a dash, space, tab, cr, nl, or end of input.
// It returns -1 if the buffer definitely does NOT match the boundary,
// meaning the prefix is followed by some other character.
// For example, "--foobar" does not match "--foo".
// It returns 0 more input needs to be read to make the decision,
// meaning that len(buf) == len(prefix) and readErr == nil.
private static nint matchAfterPrefix(slice<byte> buf, slice<byte> prefix, error readErr) {
    if (len(buf) == len(prefix)) {
        if (readErr != null) {
            return +1;
        }
        return 0;

    }
    var c = buf[len(prefix)];
    if (c == ' ' || c == '\t' || c == '\r' || c == '\n' || c == '-') {
        return +1;
    }
    return -1;

}

private static error Close(this ptr<Part> _addr_p) {
    ref Part p = ref _addr_p.val;

    io.Copy(io.Discard, p);
    return error.As(null!)!;
}

// Reader is an iterator over parts in a MIME multipart body.
// Reader's underlying parser consumes its input as needed. Seeking
// isn't supported.
public partial struct Reader {
    public ptr<bufio.Reader> bufReader;
    public ptr<Part> currentPart;
    public nint partsRead;
    public slice<byte> nl; // "\r\n" or "\n" (set after seeing first boundary line)
    public slice<byte> nlDashBoundary; // nl + "--boundary"
    public slice<byte> dashBoundaryDash; // "--boundary--"
    public slice<byte> dashBoundary; // "--boundary"
}

// NextPart returns the next part in the multipart or an error.
// When there are no more parts, the error io.EOF is returned.
//
// As a special case, if the "Content-Transfer-Encoding" header
// has a value of "quoted-printable", that header is instead
// hidden and the body is transparently decoded during Read calls.
private static (ptr<Part>, error) NextPart(this ptr<Reader> _addr_r) {
    ptr<Part> _p0 = default!;
    error _p0 = default!;
    ref Reader r = ref _addr_r.val;

    return _addr_r.nextPart(false)!;
}

// NextRawPart returns the next part in the multipart or an error.
// When there are no more parts, the error io.EOF is returned.
//
// Unlike NextPart, it does not have special handling for
// "Content-Transfer-Encoding: quoted-printable".
private static (ptr<Part>, error) NextRawPart(this ptr<Reader> _addr_r) {
    ptr<Part> _p0 = default!;
    error _p0 = default!;
    ref Reader r = ref _addr_r.val;

    return _addr_r.nextPart(true)!;
}

private static (ptr<Part>, error) nextPart(this ptr<Reader> _addr_r, bool rawPart) {
    ptr<Part> _p0 = default!;
    error _p0 = default!;
    ref Reader r = ref _addr_r.val;

    if (r.currentPart != null) {
        r.currentPart.Close();
    }
    if (string(r.dashBoundary) == "--") {
        return (_addr_null!, error.As(fmt.Errorf("multipart: boundary is empty"))!);
    }
    var expectNewPart = false;
    while (true) {
        var (line, err) = r.bufReader.ReadSlice('\n');

        if (err == io.EOF && r.isFinalBoundary(line)) { 
            // If the buffer ends in "--boundary--" without the
            // trailing "\r\n", ReadSlice will return an error
            // (since it's missing the '\n'), but this is a valid
            // multipart EOF so we need to return io.EOF instead of
            // a fmt-wrapped one.
            return (_addr_null!, error.As(io.EOF)!);

        }
        if (err != null) {
            return (_addr_null!, error.As(fmt.Errorf("multipart: NextPart: %v", err))!);
        }
        if (r.isBoundaryDelimiterLine(line)) {
            r.partsRead++;
            var (bp, err) = newPart(_addr_r, rawPart);
            if (err != null) {
                return (_addr_null!, error.As(err)!);
            }
            r.currentPart = bp;
            return (_addr_bp!, error.As(null!)!);
        }
        if (r.isFinalBoundary(line)) { 
            // Expected EOF
            return (_addr_null!, error.As(io.EOF)!);

        }
        if (expectNewPart) {
            return (_addr_null!, error.As(fmt.Errorf("multipart: expecting a new Part; got line %q", string(line)))!);
        }
        if (r.partsRead == 0) { 
            // skip line
            continue;

        }
        if (bytes.Equal(line, r.nl)) {
            expectNewPart = true;
            continue;
        }
        return (_addr_null!, error.As(fmt.Errorf("multipart: unexpected line in Next(): %q", line))!);

    }

}

// isFinalBoundary reports whether line is the final boundary line
// indicating that all parts are over.
// It matches `^--boundary--[ \t]*(\r\n)?$`
private static bool isFinalBoundary(this ptr<Reader> _addr_mr, slice<byte> line) {
    ref Reader mr = ref _addr_mr.val;

    if (!bytes.HasPrefix(line, mr.dashBoundaryDash)) {
        return false;
    }
    var rest = line[(int)len(mr.dashBoundaryDash)..];
    rest = skipLWSPChar(rest);
    return len(rest) == 0 || bytes.Equal(rest, mr.nl);

}

private static bool isBoundaryDelimiterLine(this ptr<Reader> _addr_mr, slice<byte> line) {
    bool ret = default;
    ref Reader mr = ref _addr_mr.val;
 
    // https://tools.ietf.org/html/rfc2046#section-5.1
    //   The boundary delimiter line is then defined as a line
    //   consisting entirely of two hyphen characters ("-",
    //   decimal value 45) followed by the boundary parameter
    //   value from the Content-Type header field, optional linear
    //   whitespace, and a terminating CRLF.
    if (!bytes.HasPrefix(line, mr.dashBoundary)) {
        return false;
    }
    var rest = line[(int)len(mr.dashBoundary)..];
    rest = skipLWSPChar(rest); 

    // On the first part, see our lines are ending in \n instead of \r\n
    // and switch into that mode if so. This is a violation of the spec,
    // but occurs in practice.
    if (mr.partsRead == 0 && len(rest) == 1 && rest[0] == '\n') {
        mr.nl = mr.nl[(int)1..];
        mr.nlDashBoundary = mr.nlDashBoundary[(int)1..];
    }
    return bytes.Equal(rest, mr.nl);

}

// skipLWSPChar returns b with leading spaces and tabs removed.
// RFC 822 defines:
//    LWSP-char = SPACE / HTAB
private static slice<byte> skipLWSPChar(slice<byte> b) {
    while (len(b) > 0 && (b[0] == ' ' || b[0] == '\t')) {
        b = b[(int)1..];
    }
    return b;
}

} // end multipart_package
