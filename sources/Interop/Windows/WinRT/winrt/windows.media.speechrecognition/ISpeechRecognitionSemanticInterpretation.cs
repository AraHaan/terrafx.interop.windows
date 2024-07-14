// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionSemanticInterpretation.xml' path='doc/member[@name="ISpeechRecognitionSemanticInterpretation"]/*' />
[Guid("AAE1DA9B-7E32-4C1F-89FE-0C65F486F52E")]
[NativeTypeName("struct ISpeechRecognitionSemanticInterpretation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionSemanticInterpretation : ISpeechRecognitionSemanticInterpretation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionSemanticInterpretation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, uint>)(lpVtbl[1]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, uint>)(lpVtbl[2]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionSemanticInterpretation.xml' path='doc/member[@name="ISpeechRecognitionSemanticInterpretation.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING___FIVectorView_1_HSTRING_t **")] IMapView<HSTRING, Pointer<IVectorView<HSTRING>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionSemanticInterpretation*, IMapView<HSTRING, Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[6]))((ISpeechRecognitionSemanticInterpretation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING___FIVectorView_1_HSTRING_t **")] IMapView<HSTRING, Pointer<IVectorView<HSTRING>>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IVectorView<HSTRING>>>**, int> get_Properties;
    }
}
