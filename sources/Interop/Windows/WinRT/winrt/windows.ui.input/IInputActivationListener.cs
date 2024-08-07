// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInputActivationListener.xml' path='doc/member[@name="IInputActivationListener"]/*' />
[Guid("5D6D4ED2-28C7-5AE3-AA74-C918A9F243CA")]
[NativeTypeName("struct IInputActivationListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputActivationListener : IInputActivationListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputActivationListener));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, Guid*, void**, int>)(lpVtbl[0]))((IInputActivationListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, uint>)(lpVtbl[1]))((IInputActivationListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, uint>)(lpVtbl[2]))((IInputActivationListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, uint*, Guid**, int>)(lpVtbl[3]))((IInputActivationListener*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, HSTRING*, int>)(lpVtbl[4]))((IInputActivationListener*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, TrustLevel*, int>)(lpVtbl[5]))((IInputActivationListener*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInputActivationListener.xml' path='doc/member[@name="IInputActivationListener.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::UI::Input::InputActivationState *")] InputActivationState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, InputActivationState*, int>)(lpVtbl[6]))((IInputActivationListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInputActivationListener.xml' path='doc/member[@name="IInputActivationListener.add_InputActivationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_InputActivationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CInputActivationListener_Windows__CUI__CInput__CInputActivationListenerActivationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInputActivationListener>, Pointer<IInputActivationListenerActivationChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, ITypedEventHandler<Pointer<IInputActivationListener>, Pointer<IInputActivationListenerActivationChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IInputActivationListener*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IInputActivationListener.xml' path='doc/member[@name="IInputActivationListener.remove_InputActivationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_InputActivationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputActivationListener*, EventRegistrationToken, int>)(lpVtbl[8]))((IInputActivationListener*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State([NativeTypeName("ABI::Windows::UI::Input::InputActivationState *")] InputActivationState* value);

        [VtblIndex(7)]
        HRESULT add_InputActivationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CInputActivationListener_Windows__CUI__CInput__CInputActivationListenerActivationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IInputActivationListener>, Pointer<IInputActivationListenerActivationChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_InputActivationChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::InputActivationState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InputActivationState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CInputActivationListener_Windows__CUI__CInput__CInputActivationListenerActivationChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInputActivationListener>, Pointer<IInputActivationListenerActivationChangedEventArgs>>*, EventRegistrationToken*, int> add_InputActivationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_InputActivationChanged;
    }
}
