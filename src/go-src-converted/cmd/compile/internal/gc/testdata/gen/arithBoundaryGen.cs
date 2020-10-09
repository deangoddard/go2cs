// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This program generates a test to verify that the standard arithmetic
// operators properly handle some special cases. The test file should be
// generated with a known working version of go.
// launch with `go run arithBoundaryGen.go` a file called arithBoundary.go
// will be written into the parent directory containing the tests

// package main -- go2cs converted at 2020 October 09 05:43:52 UTC
// Original source: C:\Go\src\cmd\compile\internal\gc\testdata\gen\arithBoundaryGen.go
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using format = go.go.format_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using template = go.text.template_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        // used for interpolation in a text template
        private partial struct tmplData
        {
            public @string Name;
            public @string Stype;
            public @string Symbol;
        }

        // used to work around an issue with the mod symbol being
        // interpreted as part of a format string
        private static @string SymFirst(this tmplData s)
        {
            return string(s.Symbol[0L]);
        }

        // ucast casts an unsigned int to the size in s
        private static ulong ucast(ulong i, sizedTestData s)
        {
            switch (s.name)
            {
                case "uint32": 
                    return uint64(uint32(i));
                    break;
                case "uint16": 
                    return uint64(uint16(i));
                    break;
                case "uint8": 
                    return uint64(uint8(i));
                    break;
            }
            return i;

        }

        // icast casts a signed int to the size in s
        private static long icast(long i, sizedTestData s)
        {
            switch (s.name)
            {
                case "int32": 
                    return int64(int32(i));
                    break;
                case "int16": 
                    return int64(int16(i));
                    break;
                case "int8": 
                    return int64(int8(i));
                    break;
            }
            return i;

        }

        private partial struct sizedTestData
        {
            public @string name;
            public @string sn;
            public slice<ulong> u;
            public slice<long> i;
        }

        // values to generate tests. these should include the smallest and largest values, along
        // with any other values that might cause issues. we generate n^2 tests for each size to
        // cover all cases.
        private static sizedTestData szs = new slice<sizedTestData>(new sizedTestData[] { sizedTestData{name:"uint64",sn:"64",u:[]uint64{0,1,4294967296,0xffffFFFFffffFFFF}}, sizedTestData{name:"int64",sn:"64",i:[]int64{-0x8000000000000000,-0x7FFFFFFFFFFFFFFF,-4294967296,-1,0,1,4294967296,0x7FFFFFFFFFFFFFFE,0x7FFFFFFFFFFFFFFF}}, sizedTestData{name:"uint32",sn:"32",u:[]uint64{0,1,4294967295}}, sizedTestData{name:"int32",sn:"32",i:[]int64{-0x80000000,-0x7FFFFFFF,-1,0,1,0x7FFFFFFF}}, sizedTestData{name:"uint16",sn:"16",u:[]uint64{0,1,65535}}, sizedTestData{name:"int16",sn:"16",i:[]int64{-32768,-32767,-1,0,1,32766,32767}}, sizedTestData{name:"uint8",sn:"8",u:[]uint64{0,1,255}}, sizedTestData{name:"int8",sn:"8",i:[]int64{-128,-127,-1,0,1,126,127}} });

        private partial struct op
        {
            public @string name;
            public @string symbol;
        }

        // ops that we will be generating tests for
        private static op ops = new slice<op>(new op[] { op{"add","+"}, op{"sub","-"}, op{"div","/"}, op{"mod","%%"}, op{"mul","*"} });

        private static void Main() => func((_, panic, __) =>
        {
            ptr<object> w = @new<bytes.Buffer>();
            fmt.Fprintf(w, "// Code generated by gen/arithBoundaryGen.go. DO NOT EDIT.\n\n");
            fmt.Fprintf(w, "package main;\n");
            fmt.Fprintf(w, "import \"testing\"\n");

            foreach (var (_, sz) in new slice<long>(new long[] { 64, 32, 16, 8 }))
            {
                fmt.Fprintf(w, "type utd%d struct {\n", sz);
                fmt.Fprintf(w, "  a,b uint%d\n", sz);
                fmt.Fprintf(w, "  add,sub,mul,div,mod uint%d\n", sz);
                fmt.Fprintf(w, "}\n");

                fmt.Fprintf(w, "type itd%d struct {\n", sz);
                fmt.Fprintf(w, "  a,b int%d\n", sz);
                fmt.Fprintf(w, "  add,sub,mul,div,mod int%d\n", sz);
                fmt.Fprintf(w, "}\n");
            } 

            // the function being tested
            var (testFunc, err) = template.New("testFunc").Parse("//go:noinline\n\t\tfunc {{.Name}}_{{.Stype}}_ssa(a, b {{.Stype}}) {{.Stype}} {\n\tretu" +
    "rn a {{.SymFirst}} b\n}\n");
            if (err != null)
            {
                panic(err);
            } 

            // generate our functions to be tested
            {
                var s__prev1 = s;

                foreach (var (_, __s) in szs)
                {
                    s = __s;
                    {
                        var o__prev2 = o;

                        foreach (var (_, __o) in ops)
                        {
                            o = __o;
                            tmplData fd = new tmplData(o.name,s.name,o.symbol);
                            err = testFunc.Execute(w, fd);
                            if (err != null)
                            {
                                panic(err);
                            }

                        }

                        o = o__prev2;
                    }
                } 

                // generate the test data

                s = s__prev1;
            }

            {
                var s__prev1 = s;

                foreach (var (_, __s) in szs)
                {
                    s = __s;
                    if (len(s.u) > 0L)
                    {
                        fmt.Fprintf(w, "var %s_data []utd%s = []utd%s{", s.name, s.sn, s.sn);
                        {
                            var i__prev2 = i;

                            foreach (var (_, __i) in s.u)
                            {
                                i = __i;
                                {
                                    var j__prev3 = j;

                                    foreach (var (_, __j) in s.u)
                                    {
                                        j = __j;
                                        fmt.Fprintf(w, "utd%s{a: %d, b: %d, add: %d, sub: %d, mul: %d", s.sn, i, j, ucast(i + j, s), ucast(i - j, s), ucast(i * j, s));
                                        if (j != 0L)
                                        {
                                            fmt.Fprintf(w, ", div: %d, mod: %d", ucast(i / j, s), ucast(i % j, s));
                                        }

                                        fmt.Fprint(w, "},\n");

                                    }
                    else

                                    j = j__prev3;
                                }
                            }

                            i = i__prev2;
                        }

                        fmt.Fprintf(w, "}\n");

                    }                    { 
                        // TODO: clean up this duplication
                        fmt.Fprintf(w, "var %s_data []itd%s = []itd%s{", s.name, s.sn, s.sn);
                        {
                            var i__prev2 = i;

                            foreach (var (_, __i) in s.i)
                            {
                                i = __i;
                                {
                                    var j__prev3 = j;

                                    foreach (var (_, __j) in s.i)
                                    {
                                        j = __j;
                                        fmt.Fprintf(w, "itd%s{a: %d, b: %d, add: %d, sub: %d, mul: %d", s.sn, i, j, icast(i + j, s), icast(i - j, s), icast(i * j, s));
                                        if (j != 0L)
                                        {
                                            fmt.Fprintf(w, ", div: %d, mod: %d", icast(i / j, s), icast(i % j, s));
                                        }

                                        fmt.Fprint(w, "},\n");

                                    }

                                    j = j__prev3;
                                }
                            }

                            i = i__prev2;
                        }

                        fmt.Fprintf(w, "}\n");

                    }

                }

                s = s__prev1;
            }

            fmt.Fprintf(w, "//TestArithmeticBoundary tests boundary results for arithmetic operations.\n");
            fmt.Fprintf(w, "func TestArithmeticBoundary(t *testing.T) {\n\n");

            var (verify, err) = template.New("tst").Parse("if got := {{.Name}}_{{.Stype}}_ssa(v.a, v.b); got != v.{{.Name}} {\n       t.Error" +
    "f(\"{{.Name}}_{{.Stype}} %d{{.Symbol}}%d = %d, wanted %d\\n\",v.a,v.b,got,v.{{.Name" +
    "}})\n}\n");

            {
                var s__prev1 = s;

                foreach (var (_, __s) in szs)
                {
                    s = __s;
                    fmt.Fprintf(w, "for _, v := range %s_data {\n", s.name);

                    {
                        var o__prev2 = o;

                        foreach (var (_, __o) in ops)
                        {
                            o = __o; 
                            // avoid generating tests that divide by zero
                            if (o.name == "div" || o.name == "mod")
                            {
                                fmt.Fprint(w, "if v.b != 0 {");
                            }

                            err = verify.Execute(w, new tmplData(o.name,s.name,o.symbol));

                            if (o.name == "div" || o.name == "mod")
                            {
                                fmt.Fprint(w, "\n}\n");
                            }

                            if (err != null)
                            {
                                panic(err);
                            }

                        }

                        o = o__prev2;
                    }

                    fmt.Fprint(w, "    }\n");

                }

                s = s__prev1;
            }

            fmt.Fprintf(w, "}\n"); 

            // gofmt result
            var b = w.Bytes();
            var (src, err) = format.Source(b);
            if (err != null)
            {
                fmt.Printf("%s\n", b);
                panic(err);
            } 

            // write to file
            err = ioutil.WriteFile("../arithBoundary_test.go", src, 0666L);
            if (err != null)
            {
                log.Fatalf("can't write output: %v\n", err);
            }

        });
    }
}
