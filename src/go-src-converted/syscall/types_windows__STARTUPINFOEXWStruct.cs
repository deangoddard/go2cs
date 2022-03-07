//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:19 UTC
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
        [PromotedStruct(typeof(StartupInfo))]
        private partial struct _STARTUPINFOEXW
        {
            // StartupInfo structure promotion - sourced from value copy
            private readonly ptr<StartupInfo> m_StartupInfoRef;

            private ref StartupInfo StartupInfo_val => ref m_StartupInfoRef.Value;

            public ref uint Cb => ref m_StartupInfoRef.Value.Cb;

            public ref ptr<ushort> _ => ref m_StartupInfoRef.Value._;

            public ref ptr<ushort> Desktop => ref m_StartupInfoRef.Value.Desktop;

            public ref ptr<ushort> Title => ref m_StartupInfoRef.Value.Title;

            public ref uint X => ref m_StartupInfoRef.Value.X;

            public ref uint Y => ref m_StartupInfoRef.Value.Y;

            public ref uint XSize => ref m_StartupInfoRef.Value.XSize;

            public ref uint YSize => ref m_StartupInfoRef.Value.YSize;

            public ref uint XCountChars => ref m_StartupInfoRef.Value.XCountChars;

            public ref uint YCountChars => ref m_StartupInfoRef.Value.YCountChars;

            public ref uint FillAttribute => ref m_StartupInfoRef.Value.FillAttribute;

            public ref uint Flags => ref m_StartupInfoRef.Value.Flags;

            public ref ushort ShowWindow => ref m_StartupInfoRef.Value.ShowWindow;

            public ref ushort _ => ref m_StartupInfoRef.Value._;

            public ref ptr<byte> _ => ref m_StartupInfoRef.Value._;

            public ref Handle StdInput => ref m_StartupInfoRef.Value.StdInput;

            public ref Handle StdOutput => ref m_StartupInfoRef.Value.StdOutput;

            public ref Handle StdErr => ref m_StartupInfoRef.Value.StdErr;

            // Constructors
            public _STARTUPINFOEXW(NilType _)
            {
                this.m_StartupInfoRef = new ptr<StartupInfo>(new StartupInfo(nil));
                this.ProcThreadAttributeList = default;
            }

            public _STARTUPINFOEXW(StartupInfo StartupInfo = default, ref ptr<_PROC_THREAD_ATTRIBUTE_LIST> ProcThreadAttributeList = default)
            {
                this.m_StartupInfoRef = new ptr<StartupInfo>(StartupInfo);
                this.ProcThreadAttributeList = ProcThreadAttributeList;
            }

            // Enable comparisons between nil and _STARTUPINFOEXW struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_STARTUPINFOEXW value, NilType nil) => value.Equals(default(_STARTUPINFOEXW));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_STARTUPINFOEXW value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _STARTUPINFOEXW value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _STARTUPINFOEXW value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _STARTUPINFOEXW(NilType nil) => default(_STARTUPINFOEXW);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static _STARTUPINFOEXW _STARTUPINFOEXW_cast(dynamic value)
        {
            return new _STARTUPINFOEXW(value.StartupInfo, ref value.ProcThreadAttributeList);
        }
    }
}