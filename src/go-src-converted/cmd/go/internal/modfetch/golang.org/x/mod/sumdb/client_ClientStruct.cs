//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using path = go.path_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using module = go.golang.org.x.mod.module_package;
using note = go.golang.org.x.mod.sumdb.note_package;
using tlog = go.golang.org.x.mod.sumdb.tlog_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Client
        {
            // Constructors
            public Client(NilType _)
            {
                this.ops = default;
                this.didLookup = default;
                this.initOnce = default;
                this.initErr = default;
                this.name = default;
                this.verifiers = default;
                this.tileReader = default;
                this.tileHeight = default;
                this.nosumdb = default;
                this.record = default;
                this.tileCache = default;
                this.latestMu = default;
                this.latest = default;
                this.latestMsg = default;
                this.tileSavedMu = default;
                this.tileSaved = default;
            }

            public Client(ClientOps ops = default, uint didLookup = default, sync.Once initOnce = default, error initErr = default, @string name = default, note.Verifiers verifiers = default, tileReader tileReader = default, long tileHeight = default, @string nosumdb = default, parCache record = default, parCache tileCache = default, sync.Mutex latestMu = default, tlog.Tree latest = default, slice<byte> latestMsg = default, sync.Mutex tileSavedMu = default, map<tlog.Tile, bool> tileSaved = default)
            {
                this.ops = ops;
                this.didLookup = didLookup;
                this.initOnce = initOnce;
                this.initErr = initErr;
                this.name = name;
                this.verifiers = verifiers;
                this.tileReader = tileReader;
                this.tileHeight = tileHeight;
                this.nosumdb = nosumdb;
                this.record = record;
                this.tileCache = tileCache;
                this.latestMu = latestMu;
                this.latest = latest;
                this.latestMsg = latestMsg;
                this.tileSavedMu = tileSavedMu;
                this.tileSaved = tileSaved;
            }

            // Enable comparisons between nil and Client struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Client value, NilType nil) => value.Equals(default(Client));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Client value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Client value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Client value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Client(NilType nil) => default(Client);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Client Client_cast(dynamic value)
        {
            return new Client(value.ops, value.didLookup, value.initOnce, value.initErr, value.name, value.verifiers, value.tileReader, value.tileHeight, value.nosumdb, value.record, value.tileCache, value.latestMu, value.latest, value.latestMsg, value.tileSavedMu, value.tileSaved);
        }
    }
}}}}