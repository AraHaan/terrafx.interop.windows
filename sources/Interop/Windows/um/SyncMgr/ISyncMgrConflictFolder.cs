// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59287F5E-BC81-4FCA-A7F1-E5A8ECDB1D69")]
    [NativeTypeName("struct ISyncMgrConflictFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrConflictFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflictFolder*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflictFolder*, uint>)(lpVtbl[1]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflictFolder*, uint>)(lpVtbl[2]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetConflictIDList(ISyncMgrConflict* pConflict, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlConflict)
        {
            return ((delegate* unmanaged<ISyncMgrConflictFolder*, ISyncMgrConflict*, ITEMIDLIST**, int>)(lpVtbl[3]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this), pConflict, ppidlConflict);
        }
    }
}
