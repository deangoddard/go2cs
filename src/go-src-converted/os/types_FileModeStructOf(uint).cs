//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:07:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FileMode
        {
            // Value of the FileMode struct
            private readonly uint m_value;

            public FileMode(uint value) => m_value = value;

            // Enable implicit conversions between uint and FileMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FileMode(uint value) => new FileMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(FileMode value) => value.m_value;
            
            // Enable comparisons between nil and FileMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FileMode value, NilType nil) => value.Equals(default(FileMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FileMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FileMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FileMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FileMode(NilType nil) => default(FileMode);
        }
    }
}
