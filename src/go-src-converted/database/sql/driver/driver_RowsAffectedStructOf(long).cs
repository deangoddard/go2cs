//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RowsAffected
        {
            // Value of the RowsAffected struct
            private readonly long m_value;

            public RowsAffected(long value) => m_value = value;

            // Enable implicit conversions between long and RowsAffected struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RowsAffected(long value) => new RowsAffected(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(RowsAffected value) => value.m_value;
            
            // Enable comparisons between nil and RowsAffected struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RowsAffected value, NilType nil) => value.Equals(default(RowsAffected));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RowsAffected value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RowsAffected value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RowsAffected value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RowsAffected(NilType nil) => default(RowsAffected);
        }
    }
}}}