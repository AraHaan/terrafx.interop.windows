// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotification3.xml' path='doc/member[@name="IToastNotification3"]/*' />
[Guid("31E8AED8-8141-4F99-BC0A-C4ED21297D77")]
[NativeTypeName("struct IToastNotification3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotification3 : IToastNotification3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotification3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotification3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, uint>)(lpVtbl[1]))((IToastNotification3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, uint>)(lpVtbl[2]))((IToastNotification3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotification3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, HSTRING*, int>)(lpVtbl[4]))((IToastNotification3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotification3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotification3.xml' path='doc/member[@name="IToastNotification3.get_NotificationMirroring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring *")] NotificationMirroring* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, NotificationMirroring*, int>)(lpVtbl[6]))((IToastNotification3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification3.xml' path='doc/member[@name="IToastNotification3.put_NotificationMirroring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring")] NotificationMirroring value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, NotificationMirroring, int>)(lpVtbl[7]))((IToastNotification3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification3.xml' path='doc/member[@name="IToastNotification3.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, HSTRING*, int>)(lpVtbl[8]))((IToastNotification3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastNotification3.xml' path='doc/member[@name="IToastNotification3.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotification3*, HSTRING, int>)(lpVtbl[9]))((IToastNotification3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring *")] NotificationMirroring* value);

        [VtblIndex(7)]
        HRESULT put_NotificationMirroring([NativeTypeName("ABI::Windows::UI::Notifications::NotificationMirroring")] NotificationMirroring value);

        [VtblIndex(8)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_RemoteId(HSTRING value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationMirroring *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationMirroring*, int> get_NotificationMirroring;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationMirroring) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationMirroring, int> put_NotificationMirroring;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;
    }
}
