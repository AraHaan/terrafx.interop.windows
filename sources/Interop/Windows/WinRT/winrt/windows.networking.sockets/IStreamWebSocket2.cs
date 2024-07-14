// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamWebSocket2.xml' path='doc/member[@name="IStreamWebSocket2"]/*' />
[Guid("AA4D08CB-93F5-4678-8236-57CCE5417ED5")]
[NativeTypeName("struct IStreamWebSocket2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamWebSocket2 : IStreamWebSocket2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamWebSocket2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, Guid*, void**, int>)(lpVtbl[0]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, uint>)(lpVtbl[1]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, uint>)(lpVtbl[2]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, HSTRING*, int>)(lpVtbl[4]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, TrustLevel*, int>)(lpVtbl[5]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamWebSocket2.xml' path='doc/member[@name="IStreamWebSocket2.add_ServerCustomValidationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ServerCustomValidationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketServerCustomValidationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IStreamWebSocket>, Pointer<IWebSocketServerCustomValidationRequestedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, ITypedEventHandler<Pointer<IStreamWebSocket>, Pointer<IWebSocketServerCustomValidationRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IStreamWebSocket2.xml' path='doc/member[@name="IStreamWebSocket2.remove_ServerCustomValidationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ServerCustomValidationRequested(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket2*, EventRegistrationToken, int>)(lpVtbl[7]))((IStreamWebSocket2*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ServerCustomValidationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketServerCustomValidationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IStreamWebSocket>, Pointer<IWebSocketServerCustomValidationRequestedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(7)]
        HRESULT remove_ServerCustomValidationRequested(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketServerCustomValidationRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStreamWebSocket>, Pointer<IWebSocketServerCustomValidationRequestedEventArgs>>*, EventRegistrationToken*, int> add_ServerCustomValidationRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ServerCustomValidationRequested;
    }
}
