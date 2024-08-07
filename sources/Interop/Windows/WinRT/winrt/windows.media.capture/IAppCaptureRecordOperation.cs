// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation"]/*' />
[Guid("C66020A9-1538-495C-9BBB-2BA870EC5861")]
[NativeTypeName("struct IAppCaptureRecordOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureRecordOperation : IAppCaptureRecordOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureRecordOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, uint>)(lpVtbl[1]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, uint>)(lpVtbl[2]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.StopRecording"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StopRecording()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, int>)(lpVtbl[6]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureRecordingState *")] AppCaptureRecordingState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, AppCaptureRecordingState*, int>)(lpVtbl[7]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.get_ErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ErrorCode([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, IReference<uint>**, int>)(lpVtbl[8]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, IReference<TimeSpan>**, int>)(lpVtbl[9]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.get_File"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, IStorageFile**, int>)(lpVtbl[10]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.get_IsFileTruncated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsFileTruncated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, IReference<bool>**, int>)(lpVtbl[11]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureRecordingStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureRecordingStateChangedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureRecordingStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.add_DurationGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_DurationGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureDurationGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureDurationGeneratedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureDurationGeneratedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.remove_DurationGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_DurationGenerated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.add_FileGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_FileGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureFileGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureFileGeneratedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureFileGeneratedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppCaptureRecordOperation.xml' path='doc/member[@name="IAppCaptureRecordOperation.remove_FileGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_FileGenerated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureRecordOperation*, EventRegistrationToken, int>)(lpVtbl[17]))((IAppCaptureRecordOperation*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StopRecording();

        [VtblIndex(7)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureRecordingState *")] AppCaptureRecordingState* value);

        [VtblIndex(8)]
        HRESULT get_ErrorCode([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(10)]
        HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(11)]
        HRESULT get_IsFileTruncated([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(12)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureRecordingStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureRecordingStateChangedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_StateChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_DurationGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureDurationGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureDurationGeneratedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_DurationGenerated(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_FileGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureFileGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureFileGeneratedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_FileGenerated(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopRecording;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppCaptureRecordingState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppCaptureRecordingState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_ErrorCode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_File;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_IsFileTruncated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureRecordingStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureRecordingStateChangedEventArgs>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureDurationGeneratedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureDurationGeneratedEventArgs>>*, EventRegistrationToken*, int> add_DurationGenerated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DurationGenerated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureRecordOperation_Windows__CMedia__CCapture__CAppCaptureFileGeneratedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppCaptureRecordOperation>, Pointer<IAppCaptureFileGeneratedEventArgs>>*, EventRegistrationToken*, int> add_FileGenerated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FileGenerated;
    }
}
