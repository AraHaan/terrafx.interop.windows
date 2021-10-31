// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("602D4995-B13A-429B-A66E-1935E44F4317")]
    [NativeTypeName("struct ITaskbarList2 : ITaskbarList")]
    [NativeInheritance("ITaskbarList")]
    public unsafe partial struct ITaskbarList2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITaskbarList2*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITaskbarList2*, uint>)(lpVtbl[1]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITaskbarList2*, uint>)(lpVtbl[2]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList2*, int>)(lpVtbl[3]))((ITaskbarList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList2*, IntPtr, int>)(lpVtbl[4]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DeleteTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList2*, IntPtr, int>)(lpVtbl[5]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ActivateTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList2*, IntPtr, int>)(lpVtbl[6]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetActiveAlt([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList2*, IntPtr, int>)(lpVtbl[7]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MarkFullscreenWindow([NativeTypeName("HWND")] IntPtr hwnd, BOOL fFullscreen)
        {
            return ((delegate* unmanaged<ITaskbarList2*, IntPtr, BOOL, int>)(lpVtbl[8]))((ITaskbarList2*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
        }
    }
}
