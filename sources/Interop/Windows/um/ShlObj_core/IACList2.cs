// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("470141A0-5186-11D2-BBB6-0060977B464C")]
    [NativeTypeName("struct IACList2 : IACList")]
    [NativeInheritance("IACList")]
    public unsafe partial struct IACList2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IACList2*, Guid*, void**, int>)(lpVtbl[0]))((IACList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IACList2*, uint>)(lpVtbl[1]))((IACList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IACList2*, uint>)(lpVtbl[2]))((IACList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Expand([NativeTypeName("PCWSTR")] ushort* pszExpand)
        {
            return ((delegate* unmanaged<IACList2*, ushort*, int>)(lpVtbl[3]))((IACList2*)Unsafe.AsPointer(ref this), pszExpand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOptions([NativeTypeName("DWORD")] uint dwFlag)
        {
            return ((delegate* unmanaged<IACList2*, uint, int>)(lpVtbl[4]))((IACList2*)Unsafe.AsPointer(ref this), dwFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
        {
            return ((delegate* unmanaged<IACList2*, uint*, int>)(lpVtbl[5]))((IACList2*)Unsafe.AsPointer(ref this), pdwFlag);
        }
    }
}
