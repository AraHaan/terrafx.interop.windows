// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IServiceRequestedEventHandler.xml' path='doc/member[@name="IServiceRequestedEventHandler"]/*' />
[Guid("D2D690BA-CAC9-48E1-95C0-D38495A84055")]
[NativeTypeName("struct IServiceRequestedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IServiceRequestedEventHandler : IServiceRequestedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IServiceRequestedEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IServiceRequestedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IServiceRequestedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IServiceRequestedEventHandler*, uint>)(lpVtbl[1]))((IServiceRequestedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IServiceRequestedEventHandler*, uint>)(lpVtbl[2]))((IServiceRequestedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IServiceRequestedEventHandler.xml' path='doc/member[@name="IServiceRequestedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* sender, [NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventArgs *")] IServiceRequestedEventArgs* e)
    {
        return ((delegate* unmanaged[MemberFunction]<IServiceRequestedEventHandler*, IMediaProtectionManager*, IServiceRequestedEventArgs*, int>)(lpVtbl[3]))((IServiceRequestedEventHandler*)Unsafe.AsPointer(ref this), sender, e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* sender, [NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventArgs *")] IServiceRequestedEventArgs* e);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager *, ABI::Windows::Media::Protection::IServiceRequestedEventArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager*, IServiceRequestedEventArgs*, int> Invoke;
    }
}
