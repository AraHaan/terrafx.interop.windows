// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("FC0E10D2-AB2A-4501-A951-06BB1075184C")]
    [NativeTypeName("struct IMFMediaError : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaError : IMFMediaError.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaError*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaError*, uint>)(lpVtbl[1]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaError*, uint>)(lpVtbl[2]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public ushort GetErrorCode()
        {
            return ((delegate* unmanaged<IMFMediaError*, ushort>)(lpVtbl[3]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetExtendedErrorCode()
        {
            return ((delegate* unmanaged<IMFMediaError*, int>)(lpVtbl[4]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* unmanaged<IMFMediaError*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[5]))((IMFMediaError*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetExtendedErrorCode(HRESULT error)
        {
            return ((delegate* unmanaged<IMFMediaError*, HRESULT, int>)(lpVtbl[6]))((IMFMediaError*)Unsafe.AsPointer(ref this), error);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            ushort GetErrorCode();

            [VtblIndex(4)]
            HRESULT GetExtendedErrorCode();

            [VtblIndex(5)]
            HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error);

            [VtblIndex(6)]
            HRESULT SetExtendedErrorCode(HRESULT error);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, uint> Release;

            [NativeTypeName("USHORT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, ushort> GetErrorCode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, int> GetExtendedErrorCode;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_ERR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, MF_MEDIA_ENGINE_ERR, int> SetErrorCode;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaError*, HRESULT, int> SetExtendedErrorCode;
        }
    }
}