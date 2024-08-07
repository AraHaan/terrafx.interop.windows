// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUICommandInvokedHandler.xml' path='doc/member[@name="IUICommandInvokedHandler"]/*' />
[Guid("DAF77A4F-C27A-4298-9AC6-2922C45E7DA6")]
[NativeTypeName("struct IUICommandInvokedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUICommandInvokedHandler : IUICommandInvokedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUICommandInvokedHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandInvokedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandInvokedHandler*, uint>)(lpVtbl[1]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandInvokedHandler*, uint>)(lpVtbl[2]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUICommandInvokedHandler.xml' path='doc/member[@name="IUICommandInvokedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::UI::Popups::IUICommand *")] IUICommand* command)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandInvokedHandler*, IUICommand*, int>)(lpVtbl[3]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this), command);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::UI::Popups::IUICommand *")] IUICommand* command);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommand *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommand*, int> Invoke;
    }
}
