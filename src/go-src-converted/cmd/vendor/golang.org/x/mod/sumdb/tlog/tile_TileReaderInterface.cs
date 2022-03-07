//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable
#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class tlog_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface TileReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TileReader As<T>(in T target) => (TileReader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TileReader As<T>(ptr<T> target_ptr) => (TileReader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static TileReader? As(object target) =>
                typeof(TileReader<>).CreateInterfaceHandler<TileReader>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class TileReader<T> : TileReader
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && m_target_ptr is not null)
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public TileReader(in T target) => m_target = target;

            public TileReader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<slice<byte>>, error) HeightByPtr(ptr<T> value);
            private delegate (slice<slice<byte>>, error) HeightByVal(T value);

            private static readonly HeightByPtr? s_HeightByPtr;
            private static readonly HeightByVal? s_HeightByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<slice<byte>>, error) Height()
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_HeightByPtr is null || !m_target_is_ptr)
                    return s_HeightByVal!(target);

                return s_HeightByPtr(m_target_ptr!);
            }

            private delegate (slice<slice<byte>>, error) ReadTilesByPtr(ptr<T> value, slice<Tile> tiles);
            private delegate (slice<slice<byte>>, error) ReadTilesByVal(T value, slice<Tile> tiles);

            private static readonly ReadTilesByPtr? s_ReadTilesByPtr;
            private static readonly ReadTilesByVal? s_ReadTilesByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<slice<byte>>, error) ReadTiles(slice<Tile> tiles)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_ReadTilesByPtr is null || !m_target_is_ptr)
                    return s_ReadTilesByVal!(target, tiles);

                return s_ReadTilesByPtr(m_target_ptr!, tiles);
            }

            private delegate (slice<slice<byte>>, error) SaveTilesByPtr(ptr<T> value, slice<Tile> tiles, slice<slice<byte>> data);
            private delegate (slice<slice<byte>>, error) SaveTilesByVal(T value, slice<Tile> tiles, slice<slice<byte>> data);

            private static readonly SaveTilesByPtr? s_SaveTilesByPtr;
            private static readonly SaveTilesByVal? s_SaveTilesByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<slice<byte>>, error) SaveTiles(slice<Tile> tiles, slice<slice<byte>> data)
            {
                T target = m_target;

                if (m_target_is_ptr && m_target_ptr is not null)
                    target = m_target_ptr.val;

                if (s_SaveTilesByPtr is null || !m_target_is_ptr)
                    return s_SaveTilesByVal!(target, tiles, data);

                return s_SaveTilesByPtr(m_target_ptr!, tiles, data);
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format ?? GetGoTypeName(typeof(T));

            [DebuggerStepperBoundary]
            static TileReader()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Height");

                if (extensionMethod is not null)
                    s_HeightByPtr = extensionMethod.CreateStaticDelegate(typeof(HeightByPtr)) as HeightByPtr;

                extensionMethod = targetType.GetExtensionMethod("Height");

                if (extensionMethod is not null)
                    s_HeightByVal = extensionMethod.CreateStaticDelegate(typeof(HeightByVal)) as HeightByVal;

                if (s_HeightByPtr is null && s_HeightByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TileReader.Height method", new Exception("Height"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadTiles");

                if (extensionMethod is not null)
                    s_ReadTilesByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadTilesByPtr)) as ReadTilesByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadTiles");

                if (extensionMethod is not null)
                    s_ReadTilesByVal = extensionMethod.CreateStaticDelegate(typeof(ReadTilesByVal)) as ReadTilesByVal;

                if (s_ReadTilesByPtr is null && s_ReadTilesByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TileReader.ReadTiles method", new Exception("ReadTiles"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SaveTiles");

                if (extensionMethod is not null)
                    s_SaveTilesByPtr = extensionMethod.CreateStaticDelegate(typeof(SaveTilesByPtr)) as SaveTilesByPtr;

                extensionMethod = targetType.GetExtensionMethod("SaveTiles");

                if (extensionMethod is not null)
                    s_SaveTilesByVal = extensionMethod.CreateStaticDelegate(typeof(SaveTilesByVal)) as SaveTilesByVal;

                if (s_SaveTilesByPtr is null && s_SaveTilesByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement TileReader.SaveTiles method", new Exception("SaveTiles"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TileReader<T>(in ptr<T> target_ptr) => new TileReader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator TileReader<T>(in T target) => new TileReader<T>(target);

            // Enable comparisons between nil and TileReader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TileReader<T> value, NilType nil) => Activator.CreateInstance<TileReader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TileReader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TileReader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TileReader<T> value) => value != nil;
        }
    }
}}}}}}}

namespace go
{
    public static class tlog_TileReaderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.mod.sumdb.tlog_package.TileReader target, Type type, out object? result)
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