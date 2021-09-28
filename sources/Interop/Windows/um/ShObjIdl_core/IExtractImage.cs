// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB2E617C-0920-11D1-9A0B-00C04FC2D6C1")]
    [NativeTypeName("struct IExtractImage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExtractImage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExtractImage*, Guid*, void**, int>)(lpVtbl[0]))((IExtractImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExtractImage*, uint>)(lpVtbl[1]))((IExtractImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExtractImage*, uint>)(lpVtbl[2]))((IExtractImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("LPWSTR")] ushort* pszPathBuffer, [NativeTypeName("DWORD")] uint cch, [NativeTypeName("DWORD *")] uint* pdwPriority, [NativeTypeName("const SIZE *")] SIZE* prgSize, [NativeTypeName("DWORD")] uint dwRecClrDepth, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IExtractImage*, ushort*, uint, uint*, SIZE*, uint, uint*, int>)(lpVtbl[3]))((IExtractImage*)Unsafe.AsPointer(ref this), pszPathBuffer, cch, pdwPriority, prgSize, dwRecClrDepth, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Extract([NativeTypeName("HBITMAP *")] IntPtr* phBmpThumbnail)
        {
            return ((delegate* unmanaged<IExtractImage*, IntPtr*, int>)(lpVtbl[4]))((IExtractImage*)Unsafe.AsPointer(ref this), phBmpThumbnail);
        }
    }
}