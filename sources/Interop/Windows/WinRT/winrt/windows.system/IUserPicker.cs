// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker"]/*' />
[Guid("7D548008-F1E3-4A6C-8DDC-A9BB0F488AED")]
[NativeTypeName("struct IUserPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserPicker : IUserPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserPicker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, Guid*, void**, int>)(lpVtbl[0]))((IUserPicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, uint>)(lpVtbl[1]))((IUserPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, uint>)(lpVtbl[2]))((IUserPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, uint*, Guid**, int>)(lpVtbl[3]))((IUserPicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, HSTRING*, int>)(lpVtbl[4]))((IUserPicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, TrustLevel*, int>)(lpVtbl[5]))((IUserPicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker.get_AllowGuestAccounts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowGuestAccounts([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, byte*, int>)(lpVtbl[6]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker.put_AllowGuestAccounts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowGuestAccounts([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, byte, int>)(lpVtbl[7]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker.get_SuggestedSelectedUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, IUser**, int>)(lpVtbl[8]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker.put_SuggestedSelectedUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, IUser*, int>)(lpVtbl[9]))((IUserPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserPicker.xml' path='doc/member[@name="IUserPicker.PickSingleUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PickSingleUserAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CUser_t **")] IAsyncOperation<Pointer<IUser>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserPicker*, IAsyncOperation<Pointer<IUser>>**, int>)(lpVtbl[10]))((IUserPicker*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowGuestAccounts([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowGuestAccounts([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(9)]
        HRESULT put_SuggestedSelectedUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* value);

        [VtblIndex(10)]
        HRESULT PickSingleUserAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CUser_t **")] IAsyncOperation<Pointer<IUser>>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowGuestAccounts;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowGuestAccounts;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_SuggestedSelectedUser;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, int> put_SuggestedSelectedUser;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CUser_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IUser>>**, int> PickSingleUserAsync;
    }
}
