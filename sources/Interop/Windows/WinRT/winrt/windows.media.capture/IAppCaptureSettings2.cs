// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureSettings2.xml' path='doc/member[@name="IAppCaptureSettings2"]/*' />
[Guid("FCB8CEE7-E26B-476F-9B1A-EC342D2A8FDE")]
[NativeTypeName("struct IAppCaptureSettings2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureSettings2 : IAppCaptureSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureSettings2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, uint>)(lpVtbl[1]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, uint>)(lpVtbl[2]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureSettings2.xml' path='doc/member[@name="IAppCaptureSettings2.get_IsGpuConstrained"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, byte*, int>)(lpVtbl[6]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings2.xml' path='doc/member[@name="IAppCaptureSettings2.get_AlternateShortcutKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlternateShortcutKeys([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureAlternateShortcutKeys **")] IAppCaptureAlternateShortcutKeys** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings2*, IAppCaptureAlternateShortcutKeys**, int>)(lpVtbl[7]))((IAppCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsGpuConstrained([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_AlternateShortcutKeys([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureAlternateShortcutKeys **")] IAppCaptureAlternateShortcutKeys** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsGpuConstrained;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureAlternateShortcutKeys **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureAlternateShortcutKeys**, int> get_AlternateShortcutKeys;
    }
}
