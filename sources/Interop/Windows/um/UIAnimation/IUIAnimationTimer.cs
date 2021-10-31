// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6B0EFAD1-A053-41D6-9085-33A689144665")]
    [NativeTypeName("struct IUIAnimationTimer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationTimer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, uint>)(lpVtbl[1]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, uint>)(lpVtbl[2]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetTimerUpdateHandler(IUIAnimationTimerUpdateHandler* updateHandler, UI_ANIMATION_IDLE_BEHAVIOR idleBehavior)
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, IUIAnimationTimerUpdateHandler*, UI_ANIMATION_IDLE_BEHAVIOR, int>)(lpVtbl[3]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), updateHandler, idleBehavior);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTimerEventHandler(IUIAnimationTimerEventHandler* handler)
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, IUIAnimationTimerEventHandler*, int>)(lpVtbl[4]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Enable()
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[5]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Disable()
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[6]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsEnabled()
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, int>)(lpVtbl[7]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, double*, int>)(lpVtbl[8]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), seconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetFrameRateThreshold([NativeTypeName("UINT32")] uint framesPerSecond)
        {
            return ((delegate* unmanaged<IUIAnimationTimer*, uint, int>)(lpVtbl[9]))((IUIAnimationTimer*)Unsafe.AsPointer(ref this), framesPerSecond);
        }
    }
}
