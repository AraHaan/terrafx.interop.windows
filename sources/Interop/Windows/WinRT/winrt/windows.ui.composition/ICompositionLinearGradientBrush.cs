// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionLinearGradientBrush.xml' path='doc/member[@name="ICompositionLinearGradientBrush"]/*' />
[Guid("983BC519-A9DB-413C-A2D8-2A9056FC525E")]
[NativeTypeName("struct ICompositionLinearGradientBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionLinearGradientBrush : ICompositionLinearGradientBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionLinearGradientBrush));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, uint>)(lpVtbl[1]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, uint>)(lpVtbl[2]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, HSTRING*, int>)(lpVtbl[4]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionLinearGradientBrush.xml' path='doc/member[@name="ICompositionLinearGradientBrush.get_EndPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EndPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, Vector2*, int>)(lpVtbl[6]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionLinearGradientBrush.xml' path='doc/member[@name="ICompositionLinearGradientBrush.put_EndPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_EndPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, Vector2, int>)(lpVtbl[7]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionLinearGradientBrush.xml' path='doc/member[@name="ICompositionLinearGradientBrush.get_StartPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, Vector2*, int>)(lpVtbl[8]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionLinearGradientBrush.xml' path='doc/member[@name="ICompositionLinearGradientBrush.put_StartPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_StartPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionLinearGradientBrush*, Vector2, int>)(lpVtbl[9]))((ICompositionLinearGradientBrush*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EndPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT put_EndPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(8)]
        HRESULT get_StartPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_StartPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_EndPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_EndPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_StartPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_StartPoint;
    }
}
