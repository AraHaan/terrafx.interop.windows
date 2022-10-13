// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUriEscapeStatics.xml' path='doc/member[@name="IUriEscapeStatics"]/*' />
[Guid("C1D432BA-C824-4452-A7FD-512BC3BBE9A1")]
[NativeTypeName("struct IUriEscapeStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUriEscapeStatics : IUriEscapeStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriEscapeStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, uint>)(lpVtbl[1]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, uint>)(lpVtbl[2]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, HSTRING*, int>)(lpVtbl[4]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUriEscapeStatics.xml' path='doc/member[@name="IUriEscapeStatics.UnescapeComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnescapeComponent(HSTRING toUnescape, HSTRING* value)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, HSTRING, HSTRING*, int>)(lpVtbl[6]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), toUnescape, value);
    }

    /// <include file='IUriEscapeStatics.xml' path='doc/member[@name="IUriEscapeStatics.EscapeComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EscapeComponent(HSTRING toEscape, HSTRING* value)
    {
        return ((delegate* unmanaged<IUriEscapeStatics*, HSTRING, HSTRING*, int>)(lpVtbl[7]))((IUriEscapeStatics*)Unsafe.AsPointer(ref this), toEscape, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UnescapeComponent(HSTRING toUnescape, HSTRING* value);

        [VtblIndex(7)]
        HRESULT EscapeComponent(HSTRING toEscape, HSTRING* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> UnescapeComponent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> EscapeComponent;
    }
}
