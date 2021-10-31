// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    [NativeTypeName("struct IWICJpegFrameDecode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICJpegFrameDecode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint>)(lpVtbl[1]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint>)(lpVtbl[2]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DoesSupportIndexing(BOOL* pfIndexingSupported)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, BOOL*, int>)(lpVtbl[3]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetIndexing(WICJpegIndexingOptions options, [NativeTypeName("UINT")] uint horizontalIntervalSize)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, WICJpegIndexingOptions, uint, int>)(lpVtbl[4]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ClearIndexing()
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, int>)(lpVtbl[5]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetAcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int>)(lpVtbl[6]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDcHuffmanTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int>)(lpVtbl[7]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetQuantizationTable([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int>)(lpVtbl[8]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetFrameHeader(WICJpegFrameHeader* pFrameHeader)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, WICJpegFrameHeader*, int>)(lpVtbl[9]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetScanHeader([NativeTypeName("UINT")] uint scanIndex, WICJpegScanHeader* pScanHeader)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, WICJpegScanHeader*, int>)(lpVtbl[10]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CopyScan([NativeTypeName("UINT")] uint scanIndex, [NativeTypeName("UINT")] uint scanOffset, [NativeTypeName("UINT")] uint cbScanData, [NativeTypeName("BYTE *")] byte* pbScanData, [NativeTypeName("UINT *")] uint* pcbScanDataActual)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)(lpVtbl[11]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CopyMinimalStream([NativeTypeName("UINT")] uint streamOffset, [NativeTypeName("UINT")] uint cbStreamData, [NativeTypeName("BYTE *")] byte* pbStreamData, [NativeTypeName("UINT *")] uint* pcbStreamDataActual)
        {
            return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)(lpVtbl[12]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        }
    }
}
