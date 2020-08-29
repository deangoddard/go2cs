//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:38:32 UTC
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
        public partial struct Win32FileAttributeData
        {
            // Constructors
            public Win32FileAttributeData(NilType _)
            {
                this.FileAttributes = default;
                this.CreationTime = default;
                this.LastAccessTime = default;
                this.LastWriteTime = default;
                this.FileSizeHigh = default;
                this.FileSizeLow = default;
            }

            public Win32FileAttributeData(uint FileAttributes = default, Filetime CreationTime = default, Filetime LastAccessTime = default, Filetime LastWriteTime = default, uint FileSizeHigh = default, uint FileSizeLow = default)
            {
                this.FileAttributes = FileAttributes;
                this.CreationTime = CreationTime;
                this.LastAccessTime = LastAccessTime;
                this.LastWriteTime = LastWriteTime;
                this.FileSizeHigh = FileSizeHigh;
                this.FileSizeLow = FileSizeLow;
            }

            // Enable comparisons between nil and Win32FileAttributeData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Win32FileAttributeData value, NilType nil) => value.Equals(default(Win32FileAttributeData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Win32FileAttributeData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Win32FileAttributeData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Win32FileAttributeData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Win32FileAttributeData(NilType nil) => default(Win32FileAttributeData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Win32FileAttributeData Win32FileAttributeData_cast(dynamic value)
        {
            return new Win32FileAttributeData(value.FileAttributes, value.CreationTime, value.LastAccessTime, value.LastWriteTime, value.FileSizeHigh, value.FileSizeLow);
        }
    }
}