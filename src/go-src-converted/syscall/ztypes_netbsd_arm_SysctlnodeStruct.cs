//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sysctlnode
        {
            // Constructors
            public Sysctlnode(NilType _)
            {
                this.Flags = default;
                this.Num = default;
                this.Name = default;
                this.Ver = default;
                this.X__rsvd = default;
                this.Un = default;
                this.X_sysctl_size = default;
                this.X_sysctl_func = default;
                this.X_sysctl_parent = default;
                this.X_sysctl_desc = default;
            }

            public Sysctlnode(uint Flags = default, int Num = default, array<sbyte> Name = default, uint Ver = default, uint X__rsvd = default, array<byte> Un = default, array<byte> X_sysctl_size = default, array<byte> X_sysctl_func = default, array<byte> X_sysctl_parent = default, array<byte> X_sysctl_desc = default)
            {
                this.Flags = Flags;
                this.Num = Num;
                this.Name = Name;
                this.Ver = Ver;
                this.X__rsvd = X__rsvd;
                this.Un = Un;
                this.X_sysctl_size = X_sysctl_size;
                this.X_sysctl_func = X_sysctl_func;
                this.X_sysctl_parent = X_sysctl_parent;
                this.X_sysctl_desc = X_sysctl_desc;
            }

            // Enable comparisons between nil and Sysctlnode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sysctlnode value, NilType nil) => value.Equals(default(Sysctlnode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sysctlnode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sysctlnode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sysctlnode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sysctlnode(NilType nil) => default(Sysctlnode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sysctlnode Sysctlnode_cast(dynamic value)
        {
            return new Sysctlnode(value.Flags, value.Num, value.Name, value.Ver, value.X__rsvd, value.Un, value.X_sysctl_size, value.X_sysctl_func, value.X_sysctl_parent, value.X_sysctl_desc);
        }
    }
}