// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICustomSystemEventTrigger.xml' path='doc/member[@name="ICustomSystemEventTrigger"]/*' />
[Guid("F3596798-CF6B-4EF4-A0CA-29CF4A278C87")]
[NativeTypeName("struct ICustomSystemEventTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICustomSystemEventTrigger : ICustomSystemEventTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICustomSystemEventTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, Guid*, void**, int>)(lpVtbl[0]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, uint>)(lpVtbl[1]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, uint>)(lpVtbl[2]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, HSTRING*, int>)(lpVtbl[4]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, TrustLevel*, int>)(lpVtbl[5]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICustomSystemEventTrigger.xml' path='doc/member[@name="ICustomSystemEventTrigger.get_TriggerId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, HSTRING*, int>)(lpVtbl[6]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICustomSystemEventTrigger.xml' path='doc/member[@name="ICustomSystemEventTrigger.get_Recurrence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Background::CustomSystemEventTriggerRecurrence *")] CustomSystemEventTriggerRecurrence* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomSystemEventTrigger*, CustomSystemEventTriggerRecurrence*, int>)(lpVtbl[7]))((ICustomSystemEventTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Recurrence([NativeTypeName("ABI::Windows::ApplicationModel::Background::CustomSystemEventTriggerRecurrence *")] CustomSystemEventTriggerRecurrence* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TriggerId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::CustomSystemEventTriggerRecurrence *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CustomSystemEventTriggerRecurrence*, int> get_Recurrence;
    }
}
