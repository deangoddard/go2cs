//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using pe = go.debug.pe_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct peFile
        {
            // Constructors
            public peFile(NilType _)
            {
                this.sections = default;
                this.stringTable = default;
                this.textSect = default;
                this.rdataSect = default;
                this.dataSect = default;
                this.bssSect = default;
                this.ctorsSect = default;
                this.nextSectOffset = default;
                this.nextFileOffset = default;
                this.symtabOffset = default;
                this.symbolCount = default;
                this.dataDirectory = default;
            }

            public peFile(slice<ptr<peSection>> sections = default, peStringTable stringTable = default, ref ptr<peSection> textSect = default, ref ptr<peSection> rdataSect = default, ref ptr<peSection> dataSect = default, ref ptr<peSection> bssSect = default, ref ptr<peSection> ctorsSect = default, uint nextSectOffset = default, uint nextFileOffset = default, long symtabOffset = default, nint symbolCount = default, array<pe.DataDirectory> dataDirectory = default)
            {
                this.sections = sections;
                this.stringTable = stringTable;
                this.textSect = textSect;
                this.rdataSect = rdataSect;
                this.dataSect = dataSect;
                this.bssSect = bssSect;
                this.ctorsSect = ctorsSect;
                this.nextSectOffset = nextSectOffset;
                this.nextFileOffset = nextFileOffset;
                this.symtabOffset = symtabOffset;
                this.symbolCount = symbolCount;
                this.dataDirectory = dataDirectory;
            }

            // Enable comparisons between nil and peFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peFile value, NilType nil) => value.Equals(default(peFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peFile(NilType nil) => default(peFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static peFile peFile_cast(dynamic value)
        {
            return new peFile(value.sections, value.stringTable, ref value.textSect, ref value.rdataSect, ref value.dataSect, ref value.bssSect, ref value.ctorsSect, value.nextSectOffset, value.nextFileOffset, value.symtabOffset, value.symbolCount, value.dataDirectory);
        }
    }
}}}}