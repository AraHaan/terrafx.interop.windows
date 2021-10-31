// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96")]
    [NativeTypeName("struct IWICPlanarFormatConverter : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICPlanarFormatConverter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint>)(lpVtbl[1]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint>)(lpVtbl[2]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint*, uint*, int>)(lpVtbl[3]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, int>)(lpVtbl[4]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetResolution(double* pDpiX, double* pDpiY)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, double*, double*, int>)(lpVtbl[5]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CopyPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, IWICPalette*, int>)(lpVtbl[6]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Initialize(IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int>)(lpVtbl[8]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, [NativeTypeName("UINT")] uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, BOOL* pfCanConvert)
        {
            return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, uint, Guid*, BOOL*, int>)(lpVtbl[9]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
        }
    }
}
