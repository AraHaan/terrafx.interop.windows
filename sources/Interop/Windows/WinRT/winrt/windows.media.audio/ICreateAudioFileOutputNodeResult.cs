// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICreateAudioFileOutputNodeResult.xml' path='doc/member[@name="ICreateAudioFileOutputNodeResult"]/*' />
[Guid("47D6BA7B-E909-453F-866E-5540CDA734FF")]
[NativeTypeName("struct ICreateAudioFileOutputNodeResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICreateAudioFileOutputNodeResult : ICreateAudioFileOutputNodeResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateAudioFileOutputNodeResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, Guid*, void**, int>)(lpVtbl[0]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, uint>)(lpVtbl[1]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, uint>)(lpVtbl[2]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, uint*, Guid**, int>)(lpVtbl[3]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, HSTRING*, int>)(lpVtbl[4]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, TrustLevel*, int>)(lpVtbl[5]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICreateAudioFileOutputNodeResult.xml' path='doc/member[@name="ICreateAudioFileOutputNodeResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioFileNodeCreationStatus *")] AudioFileNodeCreationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, AudioFileNodeCreationStatus*, int>)(lpVtbl[6]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICreateAudioFileOutputNodeResult.xml' path='doc/member[@name="ICreateAudioFileOutputNodeResult.get_FileOutputNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FileOutputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFileOutputNode **")] IAudioFileOutputNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioFileOutputNodeResult*, IAudioFileOutputNode**, int>)(lpVtbl[7]))((ICreateAudioFileOutputNodeResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioFileNodeCreationStatus *")] AudioFileNodeCreationStatus* value);

        [VtblIndex(7)]
        HRESULT get_FileOutputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFileOutputNode **")] IAudioFileOutputNode** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioFileNodeCreationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioFileNodeCreationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioFileOutputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioFileOutputNode**, int> get_FileOutputNode;
    }
}
