// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E693CF68-D967-4112-8763-99172AEE5E5A")]
    [NativeTypeName("struct IVisualProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVisualProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualProperties*, Guid*, void**, int>)(lpVtbl[0]))((IVisualProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualProperties*, uint>)(lpVtbl[1]))((IVisualProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualProperties*, uint>)(lpVtbl[2]))((IVisualProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetWatermark([NativeTypeName("HBITMAP")] IntPtr hbmp, VPWATERMARKFLAGS vpwf)
        {
            return ((delegate* unmanaged<IVisualProperties*, IntPtr, VPWATERMARKFLAGS, int>)(lpVtbl[3]))((IVisualProperties*)Unsafe.AsPointer(ref this), hbmp, vpwf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetColor(VPCOLORFLAGS vpcf, [NativeTypeName("COLORREF")] uint cr)
        {
            return ((delegate* unmanaged<IVisualProperties*, VPCOLORFLAGS, uint, int>)(lpVtbl[4]))((IVisualProperties*)Unsafe.AsPointer(ref this), vpcf, cr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetColor(VPCOLORFLAGS vpcf, [NativeTypeName("COLORREF *")] uint* pcr)
        {
            return ((delegate* unmanaged<IVisualProperties*, VPCOLORFLAGS, uint*, int>)(lpVtbl[5]))((IVisualProperties*)Unsafe.AsPointer(ref this), vpcf, pcr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemHeight(int cyItemInPixels)
        {
            return ((delegate* unmanaged<IVisualProperties*, int, int>)(lpVtbl[6]))((IVisualProperties*)Unsafe.AsPointer(ref this), cyItemInPixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemHeight(int* cyItemInPixels)
        {
            return ((delegate* unmanaged<IVisualProperties*, int*, int>)(lpVtbl[7]))((IVisualProperties*)Unsafe.AsPointer(ref this), cyItemInPixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf, [NativeTypeName("BOOL")] int bRedraw)
        {
            return ((delegate* unmanaged<IVisualProperties*, LOGFONTW*, int, int>)(lpVtbl[8]))((IVisualProperties*)Unsafe.AsPointer(ref this), plf, bRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetFont(LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IVisualProperties*, LOGFONTW*, int>)(lpVtbl[9]))((IVisualProperties*)Unsafe.AsPointer(ref this), plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetTheme([NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList)
        {
            return ((delegate* unmanaged<IVisualProperties*, ushort*, ushort*, int>)(lpVtbl[10]))((IVisualProperties*)Unsafe.AsPointer(ref this), pszSubAppName, pszSubIdList);
        }
    }
}