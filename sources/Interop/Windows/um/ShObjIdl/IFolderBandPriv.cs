// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("47C01F95-E185-412C-B5C5-4F27DF965AEA")]
    [NativeTypeName("struct IFolderBandPriv : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFolderBandPriv
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderBandPriv*, Guid*, void**, int>)(lpVtbl[0]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderBandPriv*, uint>)(lpVtbl[1]))((IFolderBandPriv*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderBandPriv*, uint>)(lpVtbl[2]))((IFolderBandPriv*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetCascade([NativeTypeName("BOOL")] int fCascade)
        {
            return ((delegate* unmanaged<IFolderBandPriv*, int, int>)(lpVtbl[3]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fCascade);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetAccelerators([NativeTypeName("BOOL")] int fAccelerators)
        {
            return ((delegate* unmanaged<IFolderBandPriv*, int, int>)(lpVtbl[4]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fAccelerators);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetNoIcons([NativeTypeName("BOOL")] int fNoIcons)
        {
            return ((delegate* unmanaged<IFolderBandPriv*, int, int>)(lpVtbl[5]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fNoIcons);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetNoText([NativeTypeName("BOOL")] int fNoText)
        {
            return ((delegate* unmanaged<IFolderBandPriv*, int, int>)(lpVtbl[6]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fNoText);
        }
    }
}