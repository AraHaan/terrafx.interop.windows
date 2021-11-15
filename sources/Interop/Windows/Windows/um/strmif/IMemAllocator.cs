// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("56A8689C-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMemAllocator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMemAllocator : IMemAllocator.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemAllocator*, uint>)(lpVtbl[1]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemAllocator*, uint>)(lpVtbl[2]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
        {
            return ((delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IMemAllocator*)Unsafe.AsPointer(ref this), pRequest, pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IMemAllocator*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged<IMemAllocator*, int>)(lpVtbl[5]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Decommit()
        {
            return ((delegate* unmanaged<IMemAllocator*, int>)(lpVtbl[6]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetBuffer(IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMemAllocator*, IMediaSample**, long*, long*, uint, int>)(lpVtbl[7]))((IMemAllocator*)Unsafe.AsPointer(ref this), ppBuffer, pStartTime, pEndTime, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReleaseBuffer(IMediaSample* pBuffer)
        {
            return ((delegate* unmanaged<IMemAllocator*, IMediaSample*, int>)(lpVtbl[8]))((IMemAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual);

            [VtblIndex(4)]
            HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps);

            [VtblIndex(5)]
            HRESULT Commit();

            [VtblIndex(6)]
            HRESULT Decommit();

            [VtblIndex(7)]
            HRESULT GetBuffer(IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(8)]
            HRESULT ReleaseBuffer(IMediaSample* pBuffer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, uint> Release;

            [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *, ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int> SetProperties;

            [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, int> GetProperties;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, int> Decommit;

            [NativeTypeName("HRESULT (IMediaSample **, REFERENCE_TIME *, REFERENCE_TIME *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, IMediaSample**, long*, long*, uint, int> GetBuffer;

            [NativeTypeName("HRESULT (IMediaSample *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocator*, IMediaSample*, int> ReleaseBuffer;
        }
    }
}