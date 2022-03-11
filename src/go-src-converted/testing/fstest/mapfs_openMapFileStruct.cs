//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using fs = go.io.fs_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace testing
{
    public static partial class fstest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(mapFileInfo))]
        private partial struct openMapFile
        {
            // mapFileInfo structure promotion - sourced from value copy
            private readonly ptr<mapFileInfo> m_mapFileInfoRef;

            private ref mapFileInfo mapFileInfo_val => ref m_mapFileInfoRef.Value;

            public ref @string name => ref m_mapFileInfoRef.Value.name;

            public ref ptr<MapFile> f => ref m_mapFileInfoRef.Value.f;

            // Constructors
            public openMapFile(NilType _)
            {
                this.path = default;
                this.m_mapFileInfoRef = new ptr<mapFileInfo>(new mapFileInfo(nil));
                this.offset = default;
            }

            public openMapFile(@string path = default, mapFileInfo mapFileInfo = default, long offset = default)
            {
                this.path = path;
                this.m_mapFileInfoRef = new ptr<mapFileInfo>(mapFileInfo);
                this.offset = offset;
            }

            // Enable comparisons between nil and openMapFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(openMapFile value, NilType nil) => value.Equals(default(openMapFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(openMapFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, openMapFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, openMapFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator openMapFile(NilType nil) => default(openMapFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static openMapFile openMapFile_cast(dynamic value)
        {
            return new openMapFile(value.path, value.mapFileInfo, value.offset);
        }
    }
}}