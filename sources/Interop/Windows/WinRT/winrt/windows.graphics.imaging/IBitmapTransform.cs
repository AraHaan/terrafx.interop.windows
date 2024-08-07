// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform"]/*' />
[Guid("AE755344-E268-4D35-ADCF-E995D31A8D34")]
[NativeTypeName("struct IBitmapTransform : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapTransform : IBitmapTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapTransform));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint>)(lpVtbl[1]))((IBitmapTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint>)(lpVtbl[2]))((IBitmapTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapTransform*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, HSTRING*, int>)(lpVtbl[4]))((IBitmapTransform*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapTransform*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_ScaledWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ScaledWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint*, int>)(lpVtbl[6]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_ScaledWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ScaledWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint, int>)(lpVtbl[7]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_ScaledHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ScaledHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint*, int>)(lpVtbl[8]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_ScaledHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ScaledHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, uint, int>)(lpVtbl[9]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_InterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InterpolationMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *")] BitmapInterpolationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapInterpolationMode*, int>)(lpVtbl[10]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_InterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InterpolationMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode")] BitmapInterpolationMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapInterpolationMode, int>)(lpVtbl[11]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_Flip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Flip([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip *")] BitmapFlip* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapFlip*, int>)(lpVtbl[12]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_Flip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Flip([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip")] BitmapFlip value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapFlip, int>)(lpVtbl[13]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_Rotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Rotation([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation *")] BitmapRotation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapRotation*, int>)(lpVtbl[14]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_Rotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Rotation([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation")] BitmapRotation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapRotation, int>)(lpVtbl[15]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.get_Bounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Bounds([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds *")] BitmapBounds* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapBounds*, int>)(lpVtbl[16]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapTransform.xml' path='doc/member[@name="IBitmapTransform.put_Bounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Bounds([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")] BitmapBounds value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapTransform*, BitmapBounds, int>)(lpVtbl[17]))((IBitmapTransform*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ScaledWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_ScaledWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ScaledHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_ScaledHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_InterpolationMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *")] BitmapInterpolationMode* value);

        [VtblIndex(11)]
        HRESULT put_InterpolationMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode")] BitmapInterpolationMode value);

        [VtblIndex(12)]
        HRESULT get_Flip([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip *")] BitmapFlip* value);

        [VtblIndex(13)]
        HRESULT put_Flip([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip")] BitmapFlip value);

        [VtblIndex(14)]
        HRESULT get_Rotation([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation *")] BitmapRotation* value);

        [VtblIndex(15)]
        HRESULT put_Rotation([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation")] BitmapRotation value);

        [VtblIndex(16)]
        HRESULT get_Bounds([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds *")] BitmapBounds* value);

        [VtblIndex(17)]
        HRESULT put_Bounds([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")] BitmapBounds value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ScaledWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ScaledWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ScaledHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ScaledHeight;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapInterpolationMode*, int> get_InterpolationMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapInterpolationMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapInterpolationMode, int> put_InterpolationMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapFlip *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapFlip*, int> get_Flip;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapFlip) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapFlip, int> put_Flip;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapRotation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapRotation*, int> get_Rotation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapRotation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapRotation, int> put_Rotation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapBounds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapBounds*, int> get_Bounds;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapBounds) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapBounds, int> put_Bounds;
    }
}
