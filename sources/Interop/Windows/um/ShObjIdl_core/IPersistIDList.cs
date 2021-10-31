// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1079ACFC-29BD-11D3-8E0D-00C04F6837D5")]
    [NativeTypeName("struct IPersistIDList : IPersist")]
    [NativeInheritance("IPersist")]
    public unsafe partial struct IPersistIDList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistIDList*, Guid*, void**, int>)(lpVtbl[0]))((IPersistIDList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistIDList*, uint>)(lpVtbl[1]))((IPersistIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistIDList*, uint>)(lpVtbl[2]))((IPersistIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistIDList*, Guid*, int>)(lpVtbl[3]))((IPersistIDList*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IPersistIDList*, ITEMIDLIST*, int>)(lpVtbl[4]))((IPersistIDList*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IPersistIDList*, ITEMIDLIST**, int>)(lpVtbl[5]))((IPersistIDList*)Unsafe.AsPointer(ref this), ppidl);
        }
    }
}
