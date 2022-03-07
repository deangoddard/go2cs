//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using types = go.go.types_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using packagesdriver = go.golang.org.x.tools.go.@internal.packagesdriver_package;
using gocommand = go.golang.org.x.tools.@internal.gocommand_package;
using xerrors = go.golang.org.x.xerrors_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class packages_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct goTooOldError
        {
            // error.Error function promotion
            private delegate @string ErrorByVal(T value);
            private delegate @string ErrorByRef(ref T value);

            private static readonly ErrorByVal s_ErrorByVal;
            private static readonly ErrorByRef s_ErrorByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error() => s_ErrorByRef?.Invoke(ref this) ?? s_ErrorByVal?.Invoke(this) ?? error?.Error() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static goTooOldError()
            {
                Type targetType = typeof(goTooOldError);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Error");

                if (extensionMethod is not null)
                {
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                    if (s_ErrorByRef is null)
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }
            }

            // Constructors
            public goTooOldError(NilType _)
            {
                this.error = default;
            }

            public goTooOldError(error error = default)
            {
                this.error = error;
            }

            // Enable comparisons between nil and goTooOldError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(goTooOldError value, NilType nil) => value.Equals(default(goTooOldError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(goTooOldError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, goTooOldError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, goTooOldError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator goTooOldError(NilType nil) => default(goTooOldError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static goTooOldError goTooOldError_cast(dynamic value)
        {
            return new goTooOldError(value.error);
        }
    }
}}}}}