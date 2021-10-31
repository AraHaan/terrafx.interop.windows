// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDraw : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDraw
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDraw*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDraw*, uint>)(lpVtbl[1]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDraw*, uint>)(lpVtbl[2]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Compact()
        {
            return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[3]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1, IUnknown* param2)
        {
            return ((delegate* unmanaged<IDirectDraw*, DDSURFACEDESC*, IDirectDrawSurface**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1)
        {
            return ((delegate* unmanaged<IDirectDraw*, IDirectDrawSurface*, IDirectDrawSurface**, int>)(lpVtbl[7]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK")] delegate* unmanaged<DDSURFACEDESC*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[8]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param3)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT FlipToGDISurface()
        {
            return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[10]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
        {
            return ((delegate* unmanaged<IDirectDraw*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[12]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, IDirectDrawSurface**, int>)(lpVtbl[14]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint*, int>)(lpVtbl[15]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint*, int>)(lpVtbl[16]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Initialize([NativeTypeName("GUID *")] Guid* param0)
        {
            return ((delegate* unmanaged<IDirectDraw*, Guid*, int>)(lpVtbl[18]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RestoreDisplayMode()
        {
            return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[19]))((IDirectDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged<IDirectDraw*, IntPtr, uint, int>)(lpVtbl[20]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] IntPtr param1)
        {
            return ((delegate* unmanaged<IDirectDraw*, uint, IntPtr, int>)(lpVtbl[22]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
