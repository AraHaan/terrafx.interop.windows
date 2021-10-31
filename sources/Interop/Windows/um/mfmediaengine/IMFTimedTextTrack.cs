// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8822C32D-654E-4233-BF21-D7F2E67D30D4")]
    [NativeTypeName("struct IMFTimedTextTrack : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextTrack
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, uint>)(lpVtbl[1]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, uint>)(lpVtbl[2]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint GetId()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, uint>)(lpVtbl[3]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLabel([NativeTypeName("LPWSTR *")] ushort** label)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[4]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetLabel([NativeTypeName("LPCWSTR")] ushort* label)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, ushort*, int>)(lpVtbl[5]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), label);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[6]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public MF_TIMED_TEXT_TRACK_KIND GetTrackKind()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_KIND>)(lpVtbl[7]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public BOOL IsInBand()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, int>)(lpVtbl[8]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetInBandMetadataTrackDispatchType([NativeTypeName("LPWSTR *")] ushort** dispatchType)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, ushort**, int>)(lpVtbl[9]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), dispatchType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public BOOL IsActive()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, int>)(lpVtbl[10]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public MF_TIMED_TEXT_ERROR_CODE GetErrorCode()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_ERROR_CODE>)(lpVtbl[11]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetExtendedErrorCode()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, int>)(lpVtbl[12]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDataFormat([NativeTypeName("GUID *")] Guid* format)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, Guid*, int>)(lpVtbl[13]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState()
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, MF_TIMED_TEXT_TRACK_READY_STATE>)(lpVtbl[14]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetCueList(IMFTimedTextCueList** cues)
        {
            return ((delegate* unmanaged<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)(lpVtbl[15]))((IMFTimedTextTrack*)Unsafe.AsPointer(ref this), cues);
        }
    }
}
