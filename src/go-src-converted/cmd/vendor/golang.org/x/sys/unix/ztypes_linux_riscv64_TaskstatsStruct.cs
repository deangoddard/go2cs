//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Taskstats
        {
            // Constructors
            public Taskstats(NilType _)
            {
                this.Version = default;
                this.Ac_exitcode = default;
                this.Ac_flag = default;
                this.Ac_nice = default;
                this.Cpu_count = default;
                this.Cpu_delay_total = default;
                this.Blkio_count = default;
                this.Blkio_delay_total = default;
                this.Swapin_count = default;
                this.Swapin_delay_total = default;
                this.Cpu_run_real_total = default;
                this.Cpu_run_virtual_total = default;
                this.Ac_comm = default;
                this.Ac_sched = default;
                this.Ac_pad = default;
                this._ = default;
                this.Ac_uid = default;
                this.Ac_gid = default;
                this.Ac_pid = default;
                this.Ac_ppid = default;
                this.Ac_btime = default;
                this.Ac_etime = default;
                this.Ac_utime = default;
                this.Ac_stime = default;
                this.Ac_minflt = default;
                this.Ac_majflt = default;
                this.Coremem = default;
                this.Virtmem = default;
                this.Hiwater_rss = default;
                this.Hiwater_vm = default;
                this.Read_char = default;
                this.Write_char = default;
                this.Read_syscalls = default;
                this.Write_syscalls = default;
                this.Read_bytes = default;
                this.Write_bytes = default;
                this.Cancelled_write_bytes = default;
                this.Nvcsw = default;
                this.Nivcsw = default;
                this.Ac_utimescaled = default;
                this.Ac_stimescaled = default;
                this.Cpu_scaled_run_real_total = default;
                this.Freepages_count = default;
                this.Freepages_delay_total = default;
                this.Thrashing_count = default;
                this.Thrashing_delay_total = default;
                this.Ac_btime64 = default;
            }

            public Taskstats(ushort Version = default, uint Ac_exitcode = default, byte Ac_flag = default, byte Ac_nice = default, ulong Cpu_count = default, ulong Cpu_delay_total = default, ulong Blkio_count = default, ulong Blkio_delay_total = default, ulong Swapin_count = default, ulong Swapin_delay_total = default, ulong Cpu_run_real_total = default, ulong Cpu_run_virtual_total = default, array<byte> Ac_comm = default, byte Ac_sched = default, array<byte> Ac_pad = default, array<byte> _ = default, uint Ac_uid = default, uint Ac_gid = default, uint Ac_pid = default, uint Ac_ppid = default, uint Ac_btime = default, ulong Ac_etime = default, ulong Ac_utime = default, ulong Ac_stime = default, ulong Ac_minflt = default, ulong Ac_majflt = default, ulong Coremem = default, ulong Virtmem = default, ulong Hiwater_rss = default, ulong Hiwater_vm = default, ulong Read_char = default, ulong Write_char = default, ulong Read_syscalls = default, ulong Write_syscalls = default, ulong Read_bytes = default, ulong Write_bytes = default, ulong Cancelled_write_bytes = default, ulong Nvcsw = default, ulong Nivcsw = default, ulong Ac_utimescaled = default, ulong Ac_stimescaled = default, ulong Cpu_scaled_run_real_total = default, ulong Freepages_count = default, ulong Freepages_delay_total = default, ulong Thrashing_count = default, ulong Thrashing_delay_total = default, ulong Ac_btime64 = default)
            {
                this.Version = Version;
                this.Ac_exitcode = Ac_exitcode;
                this.Ac_flag = Ac_flag;
                this.Ac_nice = Ac_nice;
                this.Cpu_count = Cpu_count;
                this.Cpu_delay_total = Cpu_delay_total;
                this.Blkio_count = Blkio_count;
                this.Blkio_delay_total = Blkio_delay_total;
                this.Swapin_count = Swapin_count;
                this.Swapin_delay_total = Swapin_delay_total;
                this.Cpu_run_real_total = Cpu_run_real_total;
                this.Cpu_run_virtual_total = Cpu_run_virtual_total;
                this.Ac_comm = Ac_comm;
                this.Ac_sched = Ac_sched;
                this.Ac_pad = Ac_pad;
                this._ = _;
                this.Ac_uid = Ac_uid;
                this.Ac_gid = Ac_gid;
                this.Ac_pid = Ac_pid;
                this.Ac_ppid = Ac_ppid;
                this.Ac_btime = Ac_btime;
                this.Ac_etime = Ac_etime;
                this.Ac_utime = Ac_utime;
                this.Ac_stime = Ac_stime;
                this.Ac_minflt = Ac_minflt;
                this.Ac_majflt = Ac_majflt;
                this.Coremem = Coremem;
                this.Virtmem = Virtmem;
                this.Hiwater_rss = Hiwater_rss;
                this.Hiwater_vm = Hiwater_vm;
                this.Read_char = Read_char;
                this.Write_char = Write_char;
                this.Read_syscalls = Read_syscalls;
                this.Write_syscalls = Write_syscalls;
                this.Read_bytes = Read_bytes;
                this.Write_bytes = Write_bytes;
                this.Cancelled_write_bytes = Cancelled_write_bytes;
                this.Nvcsw = Nvcsw;
                this.Nivcsw = Nivcsw;
                this.Ac_utimescaled = Ac_utimescaled;
                this.Ac_stimescaled = Ac_stimescaled;
                this.Cpu_scaled_run_real_total = Cpu_scaled_run_real_total;
                this.Freepages_count = Freepages_count;
                this.Freepages_delay_total = Freepages_delay_total;
                this.Thrashing_count = Thrashing_count;
                this.Thrashing_delay_total = Thrashing_delay_total;
                this.Ac_btime64 = Ac_btime64;
            }

            // Enable comparisons between nil and Taskstats struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Taskstats value, NilType nil) => value.Equals(default(Taskstats));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Taskstats value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Taskstats value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Taskstats value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Taskstats(NilType nil) => default(Taskstats);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Taskstats Taskstats_cast(dynamic value)
        {
            return new Taskstats(value.Version, value.Ac_exitcode, value.Ac_flag, value.Ac_nice, value.Cpu_count, value.Cpu_delay_total, value.Blkio_count, value.Blkio_delay_total, value.Swapin_count, value.Swapin_delay_total, value.Cpu_run_real_total, value.Cpu_run_virtual_total, value.Ac_comm, value.Ac_sched, value.Ac_pad, value._, value.Ac_uid, value.Ac_gid, value.Ac_pid, value.Ac_ppid, value.Ac_btime, value.Ac_etime, value.Ac_utime, value.Ac_stime, value.Ac_minflt, value.Ac_majflt, value.Coremem, value.Virtmem, value.Hiwater_rss, value.Hiwater_vm, value.Read_char, value.Write_char, value.Read_syscalls, value.Write_syscalls, value.Read_bytes, value.Write_bytes, value.Cancelled_write_bytes, value.Nvcsw, value.Nivcsw, value.Ac_utimescaled, value.Ac_stimescaled, value.Cpu_scaled_run_real_total, value.Freepages_count, value.Freepages_delay_total, value.Thrashing_count, value.Thrashing_delay_total, value.Ac_btime64);
        }
    }
}}}}}}