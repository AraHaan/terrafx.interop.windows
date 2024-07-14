// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioStreamDescriptorFactory.xml' path='doc/member[@name="IAudioStreamDescriptorFactory"]/*' />
[Guid("4A86CE9E-4CB1-4380-8E0C-83504B7F5BF3")]
[NativeTypeName("struct IAudioStreamDescriptorFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioStreamDescriptorFactory : IAudioStreamDescriptorFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioStreamDescriptorFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, uint>)(lpVtbl[1]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, uint>)(lpVtbl[2]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, HSTRING*, int>)(lpVtbl[4]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, TrustLevel*, int>)(lpVtbl[5]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioStreamDescriptorFactory.xml' path='doc/member[@name="IAudioStreamDescriptorFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Core::IAudioStreamDescriptor **")] IAudioStreamDescriptor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptorFactory*, IAudioEncodingProperties*, IAudioStreamDescriptor**, int>)(lpVtbl[6]))((IAudioStreamDescriptorFactory*)Unsafe.AsPointer(ref this), encodingProperties, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Core::IAudioStreamDescriptor **")] IAudioStreamDescriptor** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Core::IAudioStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioStreamDescriptor**, int> Create;
    }
}
