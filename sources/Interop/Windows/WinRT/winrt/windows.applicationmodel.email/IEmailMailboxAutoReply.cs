// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxAutoReply.xml' path='doc/member[@name="IEmailMailboxAutoReply"]/*' />
[Guid("E223254C-8AB4-485B-B31F-04D15476BD59")]
[NativeTypeName("struct IEmailMailboxAutoReply : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxAutoReply : IEmailMailboxAutoReply.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxAutoReply));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, uint>)(lpVtbl[1]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, uint>)(lpVtbl[2]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxAutoReply.xml' path='doc/member[@name="IEmailMailboxAutoReply.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, byte*, int>)(lpVtbl[6]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReply.xml' path='doc/member[@name="IEmailMailboxAutoReply.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, byte, int>)(lpVtbl[7]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReply.xml' path='doc/member[@name="IEmailMailboxAutoReply.get_Response"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Response(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, HSTRING*, int>)(lpVtbl[8]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReply.xml' path='doc/member[@name="IEmailMailboxAutoReply.put_Response"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Response(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReply*, HSTRING, int>)(lpVtbl[9]))((IEmailMailboxAutoReply*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_Response(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Response(HSTRING value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Response;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Response;
    }
}
