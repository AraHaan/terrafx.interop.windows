// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D82BE2B1-5764-11D0-A96E-00C04FD705A2")]
    [NativeTypeName("struct IShellChangeNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellChangeNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellChangeNotify*, Guid*, void**, int>)(lpVtbl[0]))((IShellChangeNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellChangeNotify*, uint>)(lpVtbl[1]))((IShellChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellChangeNotify*, uint>)(lpVtbl[2]))((IShellChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnChange([NativeTypeName("LONG")] int lEvent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
        {
            return ((delegate* unmanaged<IShellChangeNotify*, int, ITEMIDLIST*, ITEMIDLIST*, int>)(lpVtbl[3]))((IShellChangeNotify*)Unsafe.AsPointer(ref this), lEvent, pidl1, pidl2);
        }
    }
}