//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class token_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct serializedFile
        {
            // Constructors
            public serializedFile(NilType _)
            {
                this.Name = default;
                this.Base = default;
                this.Size = default;
                this.Lines = default;
                this.Infos = default;
            }

            public serializedFile(@string Name = default, long Base = default, long Size = default, slice<long> Lines = default, slice<lineInfo> Infos = default)
            {
                this.Name = Name;
                this.Base = Base;
                this.Size = Size;
                this.Lines = Lines;
                this.Infos = Infos;
            }

            // Enable comparisons between nil and serializedFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(serializedFile value, NilType nil) => value.Equals(default(serializedFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(serializedFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, serializedFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, serializedFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator serializedFile(NilType nil) => default(serializedFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static serializedFile serializedFile_cast(dynamic value)
        {
            return new serializedFile(value.Name, value.Base, value.Size, value.Lines, value.Infos);
        }
    }
}}