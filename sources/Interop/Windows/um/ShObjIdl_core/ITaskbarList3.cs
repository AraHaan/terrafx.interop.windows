// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1AFB91-9E28-4B86-90E9-9E9F8A5EEFAF")]
    [NativeTypeName("struct ITaskbarList3 : ITaskbarList2")]
    [NativeInheritance("ITaskbarList2")]
    public unsafe partial struct ITaskbarList3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITaskbarList3*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[1]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[2]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList3*, int>)(lpVtbl[3]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[4]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DeleteTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[5]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ActivateTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[6]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetActiveAlt([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[7]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MarkFullscreenWindow([NativeTypeName("HWND")] IntPtr hwnd, BOOL fFullscreen)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, BOOL, int>)(lpVtbl[8]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetProgressValue([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, ulong, ulong, int>)(lpVtbl[9]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, ullCompleted, ullTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetProgressState([NativeTypeName("HWND")] IntPtr hwnd, TBPFLAG tbpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, TBPFLAG, int>)(lpVtbl[10]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, tbpFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RegisterTab([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[11]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT UnregisterTab([NativeTypeName("HWND")] IntPtr hwndTab)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[12]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetTabOrder([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndInsertBefore)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[13]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndInsertBefore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetTabActive([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, uint, int>)(lpVtbl[14]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ThumbBarAddButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[15]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ThumbBarUpdateButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[16]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ThumbBarSetImageList([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HIMAGELIST")] IntPtr himl)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[17]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, himl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetOverlayIcon([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, ushort*, int>)(lpVtbl[18]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, hIcon, pszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetThumbnailTooltip([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, ushort*, int>)(lpVtbl[19]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, pszTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetThumbnailClip([NativeTypeName("HWND")] IntPtr hwnd, RECT* prcClip)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, RECT*, int>)(lpVtbl[20]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, prcClip);
        }
    }
}
