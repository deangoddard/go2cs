//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HTMLAttr
        {
            // Value of the HTMLAttr struct
            private readonly @string m_value;

            public HTMLAttr(@string value) => m_value = value;

            // Enable implicit conversions between @string and HTMLAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HTMLAttr(@string value) => new HTMLAttr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(HTMLAttr value) => value.m_value;
            
            // Enable comparisons between nil and HTMLAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HTMLAttr value, NilType nil) => value.Equals(default(HTMLAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HTMLAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HTMLAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HTMLAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HTMLAttr(NilType nil) => default(HTMLAttr);
        }
    }
}}
