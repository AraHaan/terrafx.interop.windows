// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareUIOptions.xml' path='doc/member[@name="IShareUIOptions"]/*' />
[Guid("72FA8A80-342F-4D90-9551-2AE04E37680C")]
[NativeTypeName("struct IShareUIOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareUIOptions : IShareUIOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareUIOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, Guid*, void**, int>)(lpVtbl[0]))((IShareUIOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, uint>)(lpVtbl[1]))((IShareUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, uint>)(lpVtbl[2]))((IShareUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IShareUIOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, HSTRING*, int>)(lpVtbl[4]))((IShareUIOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, TrustLevel*, int>)(lpVtbl[5]))((IShareUIOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareUIOptions.xml' path='doc/member[@name="IShareUIOptions.get_Theme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Theme([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme *")] ShareUITheme* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, ShareUITheme*, int>)(lpVtbl[6]))((IShareUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareUIOptions.xml' path='doc/member[@name="IShareUIOptions.put_Theme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Theme([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme")] ShareUITheme value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, ShareUITheme, int>)(lpVtbl[7]))((IShareUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareUIOptions.xml' path='doc/member[@name="IShareUIOptions.get_SelectionRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **")] IReference<Rect>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, IReference<Rect>**, int>)(lpVtbl[8]))((IShareUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareUIOptions.xml' path='doc/member[@name="IShareUIOptions.put_SelectionRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *")] IReference<Rect>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareUIOptions*, IReference<Rect>*, int>)(lpVtbl[9]))((IShareUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Theme([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme *")] ShareUITheme* value);

        [VtblIndex(7)]
        HRESULT put_Theme([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme")] ShareUITheme value);

        [VtblIndex(8)]
        HRESULT get_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **")] IReference<Rect>** value);

        [VtblIndex(9)]
        HRESULT put_SelectionRect([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *")] IReference<Rect>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ShareUITheme*, int> get_Theme;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ShareUITheme) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ShareUITheme, int> put_Theme;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Rect>**, int> get_SelectionRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CRect_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Rect>*, int> put_SelectionRect;
    }
}
