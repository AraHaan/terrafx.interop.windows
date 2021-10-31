// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawSurface3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawSurface3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint>)(lpVtbl[1]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint>)(lpVtbl[2]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawSurface3*, int>)(lpVtbl[3]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, uint, IDirectDrawSurface3*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[8]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param2)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[10]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawSurface3*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3 *")] IDirectDrawSurface3** param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDSCAPS*, IDirectDrawSurface3**, int>)(lpVtbl[12]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCaps([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDSCAPS*, int>)(lpVtbl[14]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDSURFACEDESC*, int>)(lpVtbl[22]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[23]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT IsLost()
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, int>)(lpVtbl[24]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] IntPtr param3)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, DDSURFACEDESC*, uint, IntPtr, int>)(lpVtbl[25]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT Restore()
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, int>)(lpVtbl[27]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Unlock([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, void*, int>)(lpVtbl[32]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[35]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT PageLock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDrawSurface3*, DDSURFACEDESC*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
