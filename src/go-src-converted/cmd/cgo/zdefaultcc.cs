// Code generated by go tool dist; DO NOT EDIT.

// package main -- go2cs converted at 2020 August 29 08:52:56 UTC
// Original source: C:\Go\src\cmd\cgo\zdefaultcc.go

using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static readonly @string defaultPkgConfig = "pkg-config";

        private static @string defaultCC(@string goos, @string goarch)
        {
            switch (goos + "/" + goarch)
            {
            }
            return "gcc";
        }
        private static @string defaultCXX(@string goos, @string goarch)
        {
            switch (goos + "/" + goarch)
            {
            }
            return "g++";
        }
    }
}
