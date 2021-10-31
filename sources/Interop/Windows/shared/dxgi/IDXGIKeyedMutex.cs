// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9D8E1289-D7B3-465F-8126-250E349AF85D")]
    [NativeTypeName("struct IDXGIKeyedMutex : IDXGIDeviceSubObject")]
    [NativeInheritance("IDXGIDeviceSubObject")]
    public unsafe partial struct IDXGIKeyedMutex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, uint>)(lpVtbl[1]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, uint>)(lpVtbl[2]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AcquireSync([NativeTypeName("UINT64")] ulong Key, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, ulong, uint, int>)(lpVtbl[8]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key, dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ReleaseSync([NativeTypeName("UINT64")] ulong Key)
        {
            return ((delegate* unmanaged<IDXGIKeyedMutex*, ulong, int>)(lpVtbl[9]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key);
        }
    }
}
