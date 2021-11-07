// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("31627037-53AB-4200-9061-05FAA9AB45F9")]
    [NativeTypeName("struct ID3D11VideoProcessorEnumerator : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator : ID3D11VideoProcessorEnumerator.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVideoProcessorContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, int>)(lpVtbl[7]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pContentDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CheckVideoProcessorFormat(DXGI_FORMAT Format, uint* pFlags)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, DXGI_FORMAT, uint*, int>)(lpVtbl[8]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Format, pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetVideoProcessorCaps(D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CAPS*, int>)(lpVtbl[9]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetVideoProcessorRateConversionCaps(uint TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, int>)(lpVtbl[10]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, uint, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*, int>)(lpVtbl[11]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE*, int>)(lpVtbl[12]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Filter, pRange);
        }

        public interface Interface : ID3D11DeviceChild.Interface
        {
            [VtblIndex(7)]
            HRESULT GetVideoProcessorContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc);

            [VtblIndex(8)]
            HRESULT CheckVideoProcessorFormat(DXGI_FORMAT Format, uint* pFlags);

            [VtblIndex(9)]
            HRESULT GetVideoProcessorCaps(D3D11_VIDEO_PROCESSOR_CAPS* pCaps);

            [VtblIndex(10)]
            HRESULT GetVideoProcessorRateConversionCaps(uint TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps);

            [VtblIndex(11)]
            HRESULT GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate);

            [VtblIndex(12)]
            HRESULT GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, int> GetVideoProcessorContentDesc;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, DXGI_FORMAT, uint*, int> CheckVideoProcessorFormat;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CAPS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CAPS*, int> GetVideoProcessorCaps;

            [NativeTypeName("HRESULT (UINT, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, int> GetVideoProcessorRateConversionCaps;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, uint, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*, int> GetVideoProcessorCustomRate;

            [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE*, int> GetVideoProcessorFilterRange;
        }
    }
}
