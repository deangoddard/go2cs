// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package logopt -- go2cs converted at 2020 October 09 05:24:11 UTC
// import "cmd/compile/internal/logopt" ==> using logopt = go.cmd.compile.@internal.logopt_package
// Original source: C:\Go\src\cmd\compile\internal\logopt\log_opts.go
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using url = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using static go.builtin;
using System.ComponentModel;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class logopt_package
    {
        // This implements (non)optimization logging for -json option to the Go compiler
        // The option is -json 0,<destination>.
        //
        // 0 is the version number; to avoid the need for synchronized updates, if
        // new versions of the logging appear, the compiler will support both, for a while,
        // and clients will specify what they need.
        //
        // <destination> is a directory.
        // Directories are specified with a leading / or os.PathSeparator,
        // or more explicitly with file://directory.  The second form is intended to
        // deal with corner cases on Windows, and to allow specification of a relative
        // directory path (which is normally a bad idea, because the local directory
        // varies a lot in a build, especially with modules and/or vendoring, and may
        // not be writeable).
        //
        // For each package pkg compiled, a url.PathEscape(pkg)-named subdirectory
        // is created.  For each source file.go in that package that generates
        // diagnostics (no diagnostics means no file),
        // a url.PathEscape(file)+".json"-named file is created and contains the
        // logged diagnostics.
        //
        // For example, "cmd%2Finternal%2Fdwarf/%3Cautogenerated%3E.json"
        // for "cmd/internal/dwarf" and <autogenerated> (which is not really a file, but the compiler sees it)
        //
        // If the package string is empty, it is replaced internally with string(0) which encodes to %00.
        //
        // Each log file begins with a JSON record identifying version,
        // platform, and other context, followed by optimization-relevant
        // LSP Diagnostic records, one per line (LSP version 3.15, no difference from 3.14 on the subset used here
        // see https://microsoft.github.io/language-server-protocol/specifications/specification-3-15/ )
        //
        // The fields of a Diagnostic are used in the following way:
        // Range: the outermost source position, for now begin and end are equal.
        // Severity: (always) SeverityInformation (3)
        // Source: (always) "go compiler"
        // Code: a string describing the missed optimization, e.g., "nilcheck", "cannotInline", "isInBounds", "escape"
        // Message: depending on code, additional information, e.g., the reason a function cannot be inlined.
        // RelatedInformation: if the missed optimization actually occurred at a function inlined at Range,
        //    then the sequence of inlined locations appears here, from (second) outermost to innermost,
        //    each with message="inlineLoc".
        //
        //    In the case of escape analysis explanations, after any outer inlining locations,
        //    the lines of the explanation appear, each potentially followed with its own inlining
        //    location if the escape flow occurred within an inlined function.
        //
        // For example <destination>/cmd%2Fcompile%2Finternal%2Fssa/prove.json
        // might begin with the following line (wrapped for legibility):
        //
        // {"version":0,"package":"cmd/compile/internal/ssa","goos":"darwin","goarch":"amd64",
        //  "gc_version":"devel +e1b9a57852 Fri Nov 1 15:07:00 2019 -0400",
        //  "file":"/Users/drchase/work/go/src/cmd/compile/internal/ssa/prove.go"}
        //
        // and later contain (also wrapped for legibility):
        //
        // {"range":{"start":{"line":191,"character":24},"end":{"line":191,"character":24}},
        //  "severity":3,"code":"nilcheck","source":"go compiler","message":"",
        //  "relatedInformation":[
        //    {"location":{"uri":"file:///Users/drchase/work/go/src/cmd/compile/internal/ssa/func.go",
        //                 "range":{"start":{"line":153,"character":16},"end":{"line":153,"character":16}}},
        //     "message":"inlineLoc"}]}
        //
        // That is, at prove.go (implicit from context, provided in both filename and header line),
        // line 191, column 24, a nilcheck occurred in the generated code.
        // The relatedInformation indicates that this code actually came from
        // an inlined call to func.go, line 153, character 16.
        //
        // prove.go:191:
        //     ft.orderS = f.newPoset()
        // func.go:152 and 153:
        //  func (f *Func) newPoset() *poset {
        //        if len(f.Cache.scrPoset) > 0 {
        //
        // In the case that the package is empty, the string(0) package name is also used in the header record, for example
        //
        //  go tool compile -json=0,file://logopt x.go       # no -p option to set the package
        //  head -1 logopt/%00/x.json
        //  {"version":0,"package":"\u0000","goos":"darwin","goarch":"amd64","gc_version":"devel +86487adf6a Thu Nov 7 19:34:56 2019 -0500","file":"x.go"}
        public partial struct VersionHeader
        {
            [Description("json:\"version\"")]
            public long Version;
            [Description("json:\"package\"")]
            public @string Package;
            [Description("json:\"goos\"")]
            public @string Goos;
            [Description("json:\"goarch\"")]
            public @string Goarch;
            [Description("json:\"gc_version\"")]
            public @string GcVersion;
            [Description("json:\"file,omitempty\"")]
            public @string File; // LSP requires an enclosing resource, i.e., a file
        }

        // DocumentURI, Position, Range, Location, Diagnostic, DiagnosticRelatedInformation all reuse json definitions from gopls.
        // See https://github.com/golang/tools/blob/22afafe3322a860fcd3d88448768f9db36f8bc5f/internal/lsp/protocol/tsprotocol.go

        public partial struct DocumentURI // : @string
        {
        }

        public partial struct Position
        {
            [Description("json:\"line\"")]
            public ulong Line; // gopls uses float64, but json output is the same for integers
            [Description("json:\"character\"")]
            public ulong Character; // gopls uses float64, but json output is the same for integers
        }

        // A Range in a text document expressed as (zero-based) start and end positions.
        // A range is comparable to a selection in an editor. Therefore the end position is exclusive.
        // If you want to specify a range that contains a line including the line ending character(s)
        // then use an end position denoting the start of the next line.
        public partial struct Range
        {
            [Description("json:\"start\"")]
            public Position Start; /*End defined:
     * The range's end position
     */
            [Description("json:\"end\"")]
            public Position End; // exclusive
        }

        // A Location represents a location inside a resource, such as a line inside a text file.
        public partial struct Location
        {
            [Description("json:\"uri\"")]
            public DocumentURI URI; // Range is
            [Description("json:\"range\"")]
            public Range Range;
        }

        /* DiagnosticRelatedInformation defined:
         * Represents a related message and source code location for a diagnostic. This should be
         * used to point to code locations that cause or related to a diagnostics, e.g when duplicating
         * a symbol in a scope.
         */
        public partial struct DiagnosticRelatedInformation
        {
            [Description("json:\"location\"")]
            public Location Location; /*Message defined:
     * The message of this related diagnostic information.
     */
            [Description("json:\"message\"")]
            public @string Message;
        }

        // DiagnosticSeverity defines constants
        public partial struct DiagnosticSeverity // : ulong
        {
        }

        /*SeverityInformation defined:
             * Reports an information.
             */
        public static readonly DiagnosticSeverity SeverityInformation = (DiagnosticSeverity)3L;


        // DiagnosticTag defines constants
        public partial struct DiagnosticTag // : ulong
        {
        }

        /*Diagnostic defined:
         * Represents a diagnostic, such as a compiler error or warning. Diagnostic objects
         * are only valid in the scope of a resource.
         */
        public partial struct Diagnostic
        {
            [Description("json:\"range\"")]
            public Range Range; /*Severity defined:
     * The diagnostic's severity. Can be omitted. If omitted it is up to the
     * client to interpret diagnostics as error, warning, info or hint.
     */
            [Description("json:\"severity,omitempty\"")]
            public DiagnosticSeverity Severity; // always SeverityInformation for optimizer logging.

/*Code defined:
     * The diagnostic's code, which usually appear in the user interface.
     */
            [Description("json:\"code,omitempty\"")]
            public @string Code; // LSP uses 'number | string' = gopls interface{}, but only string here, e.g. "boundsCheck", "nilcheck", etc.

/*Source defined:
     * A human-readable string describing the source of this
     * diagnostic, e.g. 'typescript' or 'super lint'. It usually
     * appears in the user interface.
     */
            [Description("json:\"source,omitempty\"")]
            public @string Source; // "go compiler"

/*Message defined:
     * The diagnostic's message. It usually appears in the user interface
     */
            [Description("json:\"message\"")]
            public @string Message; // sometimes used, provides additional information.

/*Tags defined:
     * Additional metadata about the diagnostic.
     */
            [Description("json:\"tags,omitempty\"")]
            public slice<DiagnosticTag> Tags; // always empty for logging optimizations.

/*RelatedInformation defined:
     * An array of related diagnostic information, e.g. when symbol-names within
     * a scope collide all definitions can be marked via this property.
     */
            [Description("json:\"relatedInformation,omitempty\"")]
            public slice<DiagnosticRelatedInformation> RelatedInformation;
        }

        // A LoggedOpt is what the compiler produces and accumulates,
        // to be converted to JSON for human or IDE consumption.
        public partial struct LoggedOpt
        {
            public src.XPos pos; // Source code position at which the event occurred. If it is inlined, outer and all inlined locations will appear in JSON.
            public @string pass; // For human/adhoc consumption; does not appear in JSON (yet)
            public @string fname; // For human/adhoc consumption; does not appear in JSON (yet)
            public @string what; // The (non) optimization; "nilcheck", "boundsCheck", "inline", "noInline"
            public slice<object> target; // Optional target(s) or parameter(s) of "what" -- what was inlined, why it was not, size of copy, etc. 1st is most important/relevant.
        }

        private partial struct logFormat // : byte
        {
        }

        public static readonly logFormat None = (logFormat)iota;
        public static readonly var Json0 = 0; // version 0 for LSP 3.14, 3.15; future versions of LSP may change the format and the compiler may need to support both as clients are updated.

        public static var Format = None;
        private static @string dest = default;

        public static void LogJsonOption(@string flagValue)
        {
            var (version, directory) = parseLogFlag("json", flagValue);
            if (version != 0L)
            {
                log.Fatal("-json version must be 0");
            }

            checkLogPath("json", directory);
            Format = Json0;

        }

        // parseLogFlag checks the flag passed to -json
        // for version,destination format and returns the two parts.
        private static (long, @string) parseLogFlag(@string flag, @string value)
        {
            long version = default;
            @string directory = default;

            if (Format != None)
            {
                log.Fatal("Cannot repeat -json flag");
            }

            var commaAt = strings.Index(value, ",");
            if (commaAt <= 0L)
            {
                log.Fatalf("-%s option should be '<version>,<destination>' where <version> is a number", flag);
            }

            var (v, err) = strconv.Atoi(value[..commaAt]);
            if (err != null)
            {
                log.Fatalf("-%s option should be '<version>,<destination>' where <version> is a number: err=%v", flag, err);
            }

            version = v;
            directory = value[commaAt + 1L..];
            return ;

        }

        // checkLogPath does superficial early checking of the string specifying
        // the directory to which optimizer logging is directed, and if
        // it passes the test, stores the string in LO_dir
        private static void checkLogPath(@string flag, @string destination)
        {
            var sep = string(os.PathSeparator);
            if (strings.HasPrefix(destination, "/") || strings.HasPrefix(destination, sep))
            {
                var err = os.MkdirAll(destination, 0755L);
                if (err != null)
                {
                    log.Fatalf("optimizer logging destination '<version>,<directory>' but could not create <directory>: err=%v", err);
                }

            }
            else if (strings.HasPrefix(destination, "file://"))
            { // IKWIAD, or Windows C:\foo\bar\baz
                var (uri, err) = url.Parse(destination);
                if (err != null)
                {
                    log.Fatalf("optimizer logging destination looked like file:// URI but failed to parse: err=%v", err);
                }

                destination = uri.Host + uri.Path;
                err = os.MkdirAll(destination, 0755L);
                if (err != null)
                {
                    log.Fatalf("optimizer logging destination '<version>,<directory>' but could not create %s: err=%v", destination, err);
                }

            }
            else
            {
                log.Fatalf("optimizer logging destination %s was neither %s-prefixed directory nor file://-prefixed file URI", destination, sep);
            }

            dest = destination;

        }

        private static slice<ptr<LoggedOpt>> loggedOpts = default;
        private static sync.Mutex mu = new sync.Mutex(); // mu protects loggedOpts.

        public static ptr<LoggedOpt> NewLoggedOpt(src.XPos pos, @string what, @string pass, @string fname, params object[] args)
        {
            args = args.Clone();

            pass = strings.Replace(pass, " ", "_", -1L);
            return addr(new LoggedOpt(pos,pass,fname,what,args));
        }

        public static void LogOpt(src.XPos pos, @string what, @string pass, @string fname, params object[] args) => func((defer, _, __) =>
        {
            args = args.Clone();

            if (Format == None)
            {
                return ;
            }

            var lo = NewLoggedOpt(pos, what, pass, fname, args);
            mu.Lock();
            defer(mu.Unlock()); 
            // Because of concurrent calls from back end, no telling what the order will be, but is stable-sorted by outer Pos before use.
            loggedOpts = append(loggedOpts, lo);

        });

        public static bool Enabled() => func((_, panic, __) =>
        {

            if (Format == None) 
                return false;
            else if (Format == Json0) 
                return true;
                        panic("Unexpected optimizer-logging level");

        });

        // byPos sorts diagnostics by source position.
        private partial struct byPos
        {
            public ptr<obj.Link> ctxt;
            public slice<ptr<LoggedOpt>> a;
        }

        private static long Len(this byPos x)
        {
            return len(x.a);
        }
        private static bool Less(this byPos x, long i, long j)
        {
            return x.ctxt.OutermostPos(x.a[i].pos).Before(x.ctxt.OutermostPos(x.a[j].pos));
        }
        private static void Swap(this byPos x, long i, long j)
        {
            x.a[i] = x.a[j];
            x.a[j] = x.a[i];
        }

        private static io.WriteCloser writerForLSP(@string subdirpath, @string file)
        {
            var basename = file;
            var lastslash = strings.LastIndexAny(basename, "\\/");
            if (lastslash != -1L)
            {
                basename = basename[lastslash + 1L..];
            }

            var lastdot = strings.LastIndex(basename, ".go");
            if (lastdot != -1L)
            {
                basename = basename[..lastdot];
            }

            basename = pathEscape(basename); 

            // Assume a directory, make a file
            var p = filepath.Join(subdirpath, basename + ".json");
            var (w, err) = os.Create(p);
            if (err != null)
            {
                log.Fatalf("Could not create file %s for logging optimizer actions, %v", p, err);
            }

            return w;

        }

        private static @string fixSlash(@string f)
        {
            if (os.PathSeparator == '/')
            {
                return f;
            }

            return strings.Replace(f, string(os.PathSeparator), "/", -1L);

        }

        private static DocumentURI uriIfy(@string f)
        {
            url.URL url = new url.URL(Scheme:"file",Path:fixSlash(f),);
            return DocumentURI(url.String());
        }

        // Return filename, replacing a first occurrence of $GOROOT with the
        // actual value of the GOROOT (because LSP does not speak "$GOROOT").
        private static @string uprootedPath(@string filename)
        {
            if (!strings.HasPrefix(filename, "$GOROOT/"))
            {
                return filename;
            }

            return objabi.GOROOT + filename[len("$GOROOT")..];

        }

        // FlushLoggedOpts flushes all the accumulated optimization log entries.
        public static void FlushLoggedOpts(ptr<obj.Link> _addr_ctxt, @string slashPkgPath)
        {
            ref obj.Link ctxt = ref _addr_ctxt.val;

            if (Format == None)
            {
                return ;
            }

            sort.Stable(new byPos(ctxt,loggedOpts)); // Stable is necessary to preserve the per-function order, which is repeatable.


            if (Format == Json0) // LSP 3.15
                slice<src.Pos> posTmp = default;
                ptr<json.Encoder> encoder;
                io.WriteCloser w = default;

                if (slashPkgPath == "")
                {
                    slashPkgPath = " ";
                }

                var subdirpath = filepath.Join(dest, pathEscape(slashPkgPath));
                var err = os.MkdirAll(subdirpath, 0755L);
                if (err != null)
                {
                    log.Fatalf("Could not create directory %s for logging optimizer actions, %v", subdirpath, err);
                }

                ref Diagnostic diagnostic = ref heap(new Diagnostic(Source:"go compiler",Severity:SeverityInformation), out ptr<Diagnostic> _addr_diagnostic); 

                // For LSP, make a subdirectory for the package, and for each file foo.go, create foo.json in that subdirectory.
                @string currentFile = "";
                foreach (var (_, x) in loggedOpts)
                {
                    var (posTmp, p0) = x.parsePos(ctxt, posTmp);
                    var p0f = uprootedPath(p0.Filename());

                    if (currentFile != p0f)
                    {
                        if (w != null)
                        {
                            w.Close();
                        }

                        currentFile = p0f;
                        w = writerForLSP(subdirpath, currentFile);
                        encoder = json.NewEncoder(w);
                        encoder.Encode(new VersionHeader(Version:0,Package:slashPkgPath,Goos:objabi.GOOS,Goarch:objabi.GOARCH,GcVersion:objabi.Version,File:currentFile));

                    } 

                    // The first "target" is the most important one.
                    @string target = default;
                    if (len(x.target) > 0L)
                    {
                        target = fmt.Sprint(x.target[0L]);
                    }

                    diagnostic.Code = x.what;
                    diagnostic.Message = target;
                    diagnostic.Range = newPointRange(p0);
                    diagnostic.RelatedInformation = diagnostic.RelatedInformation[..0L];

                    appendInlinedPos(posTmp, _addr_diagnostic); 

                    // Diagnostic explanation is stored in RelatedInformation after inlining info
                    if (len(x.target) > 1L)
                    {
                        switch (x.target[1L].type())
                        {
                            case slice<ptr<LoggedOpt>> y:
                                foreach (var (_, z) in y)
                                {
                                    (posTmp, p0) = z.parsePos(ctxt, posTmp);
                                    var loc = newLocation(p0);
                                    var msg = z.what;
                                    if (len(z.target) > 0L)
                                    {
                                        msg = msg + ": " + fmt.Sprint(z.target[0L]);
                                    }

                                    diagnostic.RelatedInformation = append(diagnostic.RelatedInformation, new DiagnosticRelatedInformation(Location:loc,Message:msg));
                                    appendInlinedPos(posTmp, _addr_diagnostic);

                                }
                                break;
                        }

                    }

                    encoder.Encode(diagnostic);

                }
                if (w != null)
                {
                    w.Close();
                }

                    }

        private static Range newPointRange(src.Pos p)
        {
            return new Range(Start:Position{p.Line(),p.Col()},End:Position{p.Line(),p.Col()});
        }

        private static Location newLocation(src.Pos p)
        {
            Location loc = new Location(URI:uriIfy(uprootedPath(p.Filename())),Range:newPointRange(p));
            return loc;
        }

        // appendInlinedPos extracts inlining information from posTmp and append it to diagnostic
        private static void appendInlinedPos(slice<src.Pos> posTmp, ptr<Diagnostic> _addr_diagnostic)
        {
            ref Diagnostic diagnostic = ref _addr_diagnostic.val;

            for (long i = 1L; i < len(posTmp); i++)
            {
                var p = posTmp[i];
                var loc = newLocation(p);
                diagnostic.RelatedInformation = append(diagnostic.RelatedInformation, new DiagnosticRelatedInformation(Location:loc,Message:"inlineLoc"));
            }


        }

        private static (slice<src.Pos>, src.Pos) parsePos(this ptr<LoggedOpt> _addr_x, ptr<obj.Link> _addr_ctxt, slice<src.Pos> posTmp)
        {
            slice<src.Pos> _p0 = default;
            src.Pos _p0 = default;
            ref LoggedOpt x = ref _addr_x.val;
            ref obj.Link ctxt = ref _addr_ctxt.val;

            posTmp = ctxt.AllPos(x.pos, posTmp); 
            // Reverse posTmp to put outermost first.
            var l = len(posTmp);
            for (long i = 0L; i < l / 2L; i++)
            {
                posTmp[i] = posTmp[l - i - 1L];
                posTmp[l - i - 1L] = posTmp[i];

            }

            var p0 = posTmp[0L];
            return (posTmp, p0);

        }
    }
}}}}
