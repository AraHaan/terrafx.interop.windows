// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat"]/*' />
[Guid("71902B4E-B279-4A97-A9DB-BD5A2FB78F39")]
[NativeTypeName("struct IMediaFrameFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameFormat : IMediaFrameFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameFormat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, uint>)(lpVtbl[1]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, uint>)(lpVtbl[2]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat.get_MajorType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MajorType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, HSTRING*, int>)(lpVtbl[6]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat.get_Subtype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Subtype(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, HSTRING*, int>)(lpVtbl[7]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat.get_FrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, IMediaRatio**, int>)(lpVtbl[8]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, IMapView<Guid, Pointer<IInspectable>>**, int>)(lpVtbl[9]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameFormat.xml' path='doc/member[@name="IMediaFrameFormat.get_VideoFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameFormat*, IVideoMediaFrameFormat**, int>)(lpVtbl[10]))((IMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MajorType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Subtype(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_FrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(9)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value);

        [VtblIndex(10)]
        HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MajorType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subtype;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRatio**, int> get_FrameRate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<Guid, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoMediaFrameFormat**, int> get_VideoFormat;
    }
}
