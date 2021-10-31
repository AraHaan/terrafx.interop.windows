// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DB9F920-0770-4781-B0C6-381912F9D167")]
    [NativeTypeName("struct IDCompositionHueRotationEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionHueRotationEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint>)(lpVtbl[1]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint>)(lpVtbl[2]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetAngle(float amountDegrees)
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, float, int>)(lpVtbl[5]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), amountDegrees);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAngle(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionHueRotationEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
