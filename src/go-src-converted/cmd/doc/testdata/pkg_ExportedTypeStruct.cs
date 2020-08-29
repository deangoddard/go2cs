//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd
{
    public static partial class pkg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ExportedType
        {
            // error.Error function promotion
            private delegate @string ErrorByVal(T value);
            private delegate @string ErrorByRef(ref T value);

            private static readonly ErrorByVal s_ErrorByVal;
            private static readonly ErrorByRef s_ErrorByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error() => s_ErrorByRef?.Invoke(ref this) ?? s_ErrorByVal?.Invoke(this) ?? error?.Error() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static ExportedType()
            {
                Type targetType = typeof(ExportedType);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Error");

                if ((object)extensionMethod != null)
                {
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                    if ((object)s_ErrorByRef == null)
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }
            }

            // Constructors
            public ExportedType(NilType _)
            {
                this.ExportedField = default;
                this.unexportedField = default;
                this.ExportedEmbeddedType = default;
                this.ExportedEmbeddedType = default;
                this.ExportedEmbeddedType = default;
                this.unexportedType = default;
                this.unexportedType = default;
                this.Reader = default;
                this.error = default;
            }

            public ExportedType(long ExportedField = default, long unexportedField = default, ExportedEmbeddedType ExportedEmbeddedType = default, ref ExportedEmbeddedType ExportedEmbeddedType = default, ref qualified.ExportedEmbeddedType ExportedEmbeddedType = default, unexportedType unexportedType = default, ref unexportedType unexportedType = default, io.Reader Reader = default, error error = default)
            {
                this.ExportedField = ExportedField;
                this.unexportedField = unexportedField;
                this.ExportedEmbeddedType = ExportedEmbeddedType;
                this.ExportedEmbeddedType = ExportedEmbeddedType;
                this.ExportedEmbeddedType = ExportedEmbeddedType;
                this.unexportedType = unexportedType;
                this.unexportedType = unexportedType;
                this.Reader = Reader;
                this.error = error;
            }

            // Enable comparisons between nil and ExportedType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ExportedType value, NilType nil) => value.Equals(default(ExportedType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ExportedType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ExportedType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ExportedType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ExportedType(NilType nil) => default(ExportedType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ExportedType ExportedType_cast(dynamic value)
        {
            return new ExportedType(value.ExportedField, value.unexportedField, value.ExportedEmbeddedType, ref value.ExportedEmbeddedType, ref value.ExportedEmbeddedType, value.unexportedType, ref value.unexportedType, value.Reader, value.error);
        }
    }
}}