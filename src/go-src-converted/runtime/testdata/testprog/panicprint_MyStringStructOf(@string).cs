//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyString
        {
            // Value of the MyString struct
            private readonly @string m_value;

            public MyString(@string value) => m_value = value;

            // Enable implicit conversions between @string and MyString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyString(@string value) => new MyString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(MyString value) => value.m_value;
            
            // Enable comparisons between nil and MyString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyString value, NilType nil) => value.Equals(default(MyString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyString(NilType nil) => default(MyString);
        }
    }
}
