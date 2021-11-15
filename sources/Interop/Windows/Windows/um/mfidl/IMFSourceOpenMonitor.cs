// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("059054B3-027C-494C-A27D-9113291CF87F")]
    [NativeTypeName("struct IMFSourceOpenMonitor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceOpenMonitor : IMFSourceOpenMonitor.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceOpenMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceOpenMonitor*, uint>)(lpVtbl[1]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceOpenMonitor*, uint>)(lpVtbl[2]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnSourceEvent(IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFSourceOpenMonitor*, IMFMediaEvent*, int>)(lpVtbl[3]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this), pEvent);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnSourceEvent(IMFMediaEvent* pEvent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceOpenMonitor*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceOpenMonitor*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceOpenMonitor*, uint> Release;

            [NativeTypeName("HRESULT (IMFMediaEvent *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceOpenMonitor*, IMFMediaEvent*, int> OnSourceEvent;
        }
    }
}