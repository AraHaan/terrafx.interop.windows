// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4966EED-76DB-44DA-84C1-EE9A7AFB20A8")]
    [NativeTypeName("struct IDXGIFactory7 : IDXGIFactory6")]
    [NativeInheritance("IDXGIFactory6")]
    public unsafe partial struct IDXGIFactory7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint>)(lpVtbl[1]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint>)(lpVtbl[2]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnumAdapters([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint, int>)(lpVtbl[8]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr*, int>)(lpVtbl[9]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, IDXGIAdapter** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT EnumAdapters1([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public BOOL IsCurrent()
        {
            return ((delegate* unmanaged<IDXGIFactory7*, int>)(lpVtbl[13]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public BOOL IsWindowedStereoEnabled()
        {
            return ((delegate* unmanaged<IDXGIFactory7*, int>)(lpVtbl[14]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateSwapChainForHwnd(IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IUnknown*, IntPtr, DXGI_SWAP_CHAIN_DESC1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[15]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IUnknown*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[16]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, LUID* pLuid)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, LUID*, int>)(lpVtbl[17]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hResource, pLuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint, uint*, int>)(lpVtbl[18]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[19]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IDXGIFactory7*, uint, void>)(lpVtbl[20]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint, uint*, int>)(lpVtbl[21]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[22]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IDXGIFactory7*, uint, void>)(lpVtbl[23]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT CreateSwapChainForComposition(IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[24]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint>)(lpVtbl[25]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, LUID, Guid*, void**, int>)(lpVtbl[26]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[27]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT CheckFeatureSupport(DXGI_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, DXGI_FEATURE, void*, uint, int>)(lpVtbl[28]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT EnumAdapterByGpuPreference([NativeTypeName("UINT")] uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int>)(lpVtbl[29]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT RegisterAdaptersChangedEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, IntPtr, uint*, int>)(lpVtbl[30]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT UnregisterAdaptersChangedEvent([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IDXGIFactory7*, uint, int>)(lpVtbl[31]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
