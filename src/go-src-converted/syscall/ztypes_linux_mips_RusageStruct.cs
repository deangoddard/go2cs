//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rusage
        {
            // Constructors
            public Rusage(NilType _)
            {
                this.Utime = default;
                this.Stime = default;
                this.Maxrss = default;
                this.Ixrss = default;
                this.Idrss = default;
                this.Isrss = default;
                this.Minflt = default;
                this.Majflt = default;
                this.Nswap = default;
                this.Inblock = default;
                this.Oublock = default;
                this.Msgsnd = default;
                this.Msgrcv = default;
                this.Nsignals = default;
                this.Nvcsw = default;
                this.Nivcsw = default;
            }

            public Rusage(Timeval Utime = default, Timeval Stime = default, int Maxrss = default, int Ixrss = default, int Idrss = default, int Isrss = default, int Minflt = default, int Majflt = default, int Nswap = default, int Inblock = default, int Oublock = default, int Msgsnd = default, int Msgrcv = default, int Nsignals = default, int Nvcsw = default, int Nivcsw = default)
            {
                this.Utime = Utime;
                this.Stime = Stime;
                this.Maxrss = Maxrss;
                this.Ixrss = Ixrss;
                this.Idrss = Idrss;
                this.Isrss = Isrss;
                this.Minflt = Minflt;
                this.Majflt = Majflt;
                this.Nswap = Nswap;
                this.Inblock = Inblock;
                this.Oublock = Oublock;
                this.Msgsnd = Msgsnd;
                this.Msgrcv = Msgrcv;
                this.Nsignals = Nsignals;
                this.Nvcsw = Nvcsw;
                this.Nivcsw = Nivcsw;
            }

            // Enable comparisons between nil and Rusage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rusage value, NilType nil) => value.Equals(default(Rusage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rusage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rusage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rusage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rusage(NilType nil) => default(Rusage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rusage Rusage_cast(dynamic value)
        {
            return new Rusage(value.Utime, value.Stime, value.Maxrss, value.Ixrss, value.Idrss, value.Isrss, value.Minflt, value.Majflt, value.Nswap, value.Inblock, value.Oublock, value.Msgsnd, value.Msgrcv, value.Nsignals, value.Nvcsw, value.Nivcsw);
        }
    }
}