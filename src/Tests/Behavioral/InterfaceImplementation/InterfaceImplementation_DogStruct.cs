//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 11 17:48:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Dog
        {
            // Constructors
            public Dog(NilType _)
            {
                this.Name = default;
                this.Breed = default;
            }

            public Dog(@string Name = default, @string Breed = default)
            {
                this.Name = Name;
                this.Breed = Breed;
            }

            // Enable comparisons between nil and Dog struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dog value, NilType nil) => value.Equals(default(Dog));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dog value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dog value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dog value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dog(NilType nil) => default(Dog);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Dog Dog_cast(dynamic value)
        {
            return new Dog(value.Name, value.Breed);
        }
    }
}