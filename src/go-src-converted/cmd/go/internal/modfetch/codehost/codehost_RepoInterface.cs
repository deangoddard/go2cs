//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using str = go.cmd.go.@internal.str_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace modfetch
{
    public static partial class codehost_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Repo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Repo As<T>(in T target) => (Repo<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Repo As<T>(ptr<T> target_ptr) => (Repo<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Repo? As(object target) =>
                typeof(Repo<>).CreateInterfaceHandler<Repo>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Repo<T> : Repo
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public Repo(in T target) => m_target = target;

            public Repo(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (bool, error) TagsByPtr(ptr<T> value, @string prefix);
            private delegate (bool, error) TagsByVal(T value, @string prefix);

            private static readonly TagsByPtr? s_TagsByPtr;
            private static readonly TagsByVal? s_TagsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) Tags(@string prefix)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_TagsByPtr is null || !m_target_is_ptr)
                    return s_TagsByVal!(target, prefix);

                return s_TagsByPtr(m_target_ptr, prefix);
            }

            private delegate (bool, error) StatByPtr(ptr<T> value, @string rev);
            private delegate (bool, error) StatByVal(T value, @string rev);

            private static readonly StatByPtr? s_StatByPtr;
            private static readonly StatByVal? s_StatByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) Stat(@string rev)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_StatByPtr is null || !m_target_is_ptr)
                    return s_StatByVal!(target, rev);

                return s_StatByPtr(m_target_ptr, rev);
            }

            private delegate (bool, error) LatestByPtr(ptr<T> value);
            private delegate (bool, error) LatestByVal(T value);

            private static readonly LatestByPtr? s_LatestByPtr;
            private static readonly LatestByVal? s_LatestByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) Latest()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LatestByPtr is null || !m_target_is_ptr)
                    return s_LatestByVal!(target);

                return s_LatestByPtr(m_target_ptr);
            }

            private delegate (bool, error) ReadFileByPtr(ptr<T> value, @string rev, @string file, long maxSize);
            private delegate (bool, error) ReadFileByVal(T value, @string rev, @string file, long maxSize);

            private static readonly ReadFileByPtr? s_ReadFileByPtr;
            private static readonly ReadFileByVal? s_ReadFileByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) ReadFile(@string rev, @string file, long maxSize)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadFileByPtr is null || !m_target_is_ptr)
                    return s_ReadFileByVal!(target, rev, file, maxSize);

                return s_ReadFileByPtr(m_target_ptr, rev, file, maxSize);
            }

            private delegate (bool, error) ReadFileRevsByPtr(ptr<T> value, slice<@string> revs, @string file, long maxSize);
            private delegate (bool, error) ReadFileRevsByVal(T value, slice<@string> revs, @string file, long maxSize);

            private static readonly ReadFileRevsByPtr? s_ReadFileRevsByPtr;
            private static readonly ReadFileRevsByVal? s_ReadFileRevsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) ReadFileRevs(slice<@string> revs, @string file, long maxSize)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadFileRevsByPtr is null || !m_target_is_ptr)
                    return s_ReadFileRevsByVal!(target, revs, file, maxSize);

                return s_ReadFileRevsByPtr(m_target_ptr, revs, file, maxSize);
            }

            private delegate (bool, error) ReadZipByPtr(ptr<T> value, @string rev, @string subdir, long maxSize);
            private delegate (bool, error) ReadZipByVal(T value, @string rev, @string subdir, long maxSize);

            private static readonly ReadZipByPtr? s_ReadZipByPtr;
            private static readonly ReadZipByVal? s_ReadZipByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) ReadZip(@string rev, @string subdir, long maxSize)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadZipByPtr is null || !m_target_is_ptr)
                    return s_ReadZipByVal!(target, rev, subdir, maxSize);

                return s_ReadZipByPtr(m_target_ptr, rev, subdir, maxSize);
            }

            private delegate (bool, error) RecentTagByPtr(ptr<T> value, @string rev, @string prefix, @string major);
            private delegate (bool, error) RecentTagByVal(T value, @string rev, @string prefix, @string major);

            private static readonly RecentTagByPtr? s_RecentTagByPtr;
            private static readonly RecentTagByVal? s_RecentTagByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) RecentTag(@string rev, @string prefix, @string major)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_RecentTagByPtr is null || !m_target_is_ptr)
                    return s_RecentTagByVal!(target, rev, prefix, major);

                return s_RecentTagByPtr(m_target_ptr, rev, prefix, major);
            }

            private delegate (bool, error) DescendsFromByPtr(ptr<T> value, @string rev, @string tag);
            private delegate (bool, error) DescendsFromByVal(T value, @string rev, @string tag);

            private static readonly DescendsFromByPtr? s_DescendsFromByPtr;
            private static readonly DescendsFromByVal? s_DescendsFromByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (bool, error) DescendsFrom(@string rev, @string tag)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_DescendsFromByPtr is null || !m_target_is_ptr)
                    return s_DescendsFromByVal!(target, rev, tag);

                return s_DescendsFromByPtr(m_target_ptr, rev, tag);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static Repo()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Tags");

                if (!(extensionMethod is null))
                    s_TagsByPtr = extensionMethod.CreateStaticDelegate(typeof(TagsByPtr)) as TagsByPtr;

                extensionMethod = targetType.GetExtensionMethod("Tags");

                if (!(extensionMethod is null))
                    s_TagsByVal = extensionMethod.CreateStaticDelegate(typeof(TagsByVal)) as TagsByVal;

                if (s_TagsByPtr is null && s_TagsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.Tags method", new Exception("Tags"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Stat");

                if (!(extensionMethod is null))
                    s_StatByPtr = extensionMethod.CreateStaticDelegate(typeof(StatByPtr)) as StatByPtr;

                extensionMethod = targetType.GetExtensionMethod("Stat");

                if (!(extensionMethod is null))
                    s_StatByVal = extensionMethod.CreateStaticDelegate(typeof(StatByVal)) as StatByVal;

                if (s_StatByPtr is null && s_StatByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.Stat method", new Exception("Stat"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Latest");

                if (!(extensionMethod is null))
                    s_LatestByPtr = extensionMethod.CreateStaticDelegate(typeof(LatestByPtr)) as LatestByPtr;

                extensionMethod = targetType.GetExtensionMethod("Latest");

                if (!(extensionMethod is null))
                    s_LatestByVal = extensionMethod.CreateStaticDelegate(typeof(LatestByVal)) as LatestByVal;

                if (s_LatestByPtr is null && s_LatestByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.Latest method", new Exception("Latest"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadFile");

                if (!(extensionMethod is null))
                    s_ReadFileByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadFileByPtr)) as ReadFileByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadFile");

                if (!(extensionMethod is null))
                    s_ReadFileByVal = extensionMethod.CreateStaticDelegate(typeof(ReadFileByVal)) as ReadFileByVal;

                if (s_ReadFileByPtr is null && s_ReadFileByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.ReadFile method", new Exception("ReadFile"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadFileRevs");

                if (!(extensionMethod is null))
                    s_ReadFileRevsByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadFileRevsByPtr)) as ReadFileRevsByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadFileRevs");

                if (!(extensionMethod is null))
                    s_ReadFileRevsByVal = extensionMethod.CreateStaticDelegate(typeof(ReadFileRevsByVal)) as ReadFileRevsByVal;

                if (s_ReadFileRevsByPtr is null && s_ReadFileRevsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.ReadFileRevs method", new Exception("ReadFileRevs"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadZip");

                if (!(extensionMethod is null))
                    s_ReadZipByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadZipByPtr)) as ReadZipByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadZip");

                if (!(extensionMethod is null))
                    s_ReadZipByVal = extensionMethod.CreateStaticDelegate(typeof(ReadZipByVal)) as ReadZipByVal;

                if (s_ReadZipByPtr is null && s_ReadZipByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.ReadZip method", new Exception("ReadZip"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("RecentTag");

                if (!(extensionMethod is null))
                    s_RecentTagByPtr = extensionMethod.CreateStaticDelegate(typeof(RecentTagByPtr)) as RecentTagByPtr;

                extensionMethod = targetType.GetExtensionMethod("RecentTag");

                if (!(extensionMethod is null))
                    s_RecentTagByVal = extensionMethod.CreateStaticDelegate(typeof(RecentTagByVal)) as RecentTagByVal;

                if (s_RecentTagByPtr is null && s_RecentTagByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.RecentTag method", new Exception("RecentTag"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("DescendsFrom");

                if (!(extensionMethod is null))
                    s_DescendsFromByPtr = extensionMethod.CreateStaticDelegate(typeof(DescendsFromByPtr)) as DescendsFromByPtr;

                extensionMethod = targetType.GetExtensionMethod("DescendsFrom");

                if (!(extensionMethod is null))
                    s_DescendsFromByVal = extensionMethod.CreateStaticDelegate(typeof(DescendsFromByVal)) as DescendsFromByVal;

                if (s_DescendsFromByPtr is null && s_DescendsFromByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Repo.DescendsFrom method", new Exception("DescendsFrom"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Repo<T>(in ptr<T> target_ptr) => new Repo<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Repo<T>(in T target) => new Repo<T>(target);

            // Enable comparisons between nil and Repo<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Repo<T> value, NilType nil) => Activator.CreateInstance<Repo<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Repo<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Repo<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Repo<T> value) => value != nil;
        }
    }
}}}}}

namespace go
{
    public static class codehost_RepoExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.go.@internal.modfetch.codehost_package.Repo target)
        {
            try
            {
                return ((go.cmd.go.@internal.modfetch.codehost_package.Repo<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.go.@internal.modfetch.codehost_package.Repo target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.cmd.go.@internal.modfetch.codehost_package.Repo target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.go.@internal.modfetch.codehost_package.Repo<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.cmd.go.@internal.modfetch.codehost_package.Repo target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}