//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T26
        {
            // Value of the T26 struct
            private readonly ptr<T27> m_value;

            public T26(ptr<T27> value) => m_value = value;

            // Enable implicit conversions between ptr<T27> and T26 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T26(ptr<T27> value) => new T26(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptr<T27>(T26 value) => value.m_value;
            
            // Enable comparisons between nil and T26 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T26 value, NilType nil) => value.Equals(default(T26));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T26 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T26 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T26 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T26(NilType nil) => default(T26);
        }
    }
}}}
