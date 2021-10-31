// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD04E6E3-FE0C-4C3C-AB19-A07601A576EE")]
    [NativeTypeName("struct ICompositionDrawingSurfaceInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICompositionDrawingSurfaceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, uint>)(lpVtbl[1]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, uint>)(lpVtbl[2]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[4]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Resize(SIZE sizePixels)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, SIZE, int>)(lpVtbl[5]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), sizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, RECT*, RECT*, int, int, int>)(lpVtbl[6]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResumeDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[7]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SuspendDraw()
        {
            return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[8]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }
    }
}
