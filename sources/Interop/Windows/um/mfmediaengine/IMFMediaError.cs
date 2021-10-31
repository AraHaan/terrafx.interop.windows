// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC0E10D2-AB2A-4501-A951-06BB1075184C")]
    [NativeTypeName("struct IMFMediaError : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaError
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
        [return: NativeTypeName("USHORT")]
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
    }
}
