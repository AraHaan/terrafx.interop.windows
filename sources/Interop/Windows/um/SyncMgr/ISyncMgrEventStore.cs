// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37E412F9-016E-44C2-81FF-DB3ADD774266")]
    [NativeTypeName("struct ISyncMgrEventStore : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrEventStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, uint>)(lpVtbl[1]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, uint>)(lpVtbl[2]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEventEnumerator(IEnumSyncMgrEvents** ppenum)
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, IEnumSyncMgrEvents**, int>)(lpVtbl[3]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetEventCount([NativeTypeName("ULONG *")] uint* pcEvents)
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, uint*, int>)(lpVtbl[4]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), pcEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetEvent([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent** ppEvent)
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, ISyncMgrEvent**, int>)(lpVtbl[5]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), rguidEventID, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveEvent([NativeTypeName("GUID *")] Guid* pguidEventIDs, [NativeTypeName("ULONG")] uint cEvents)
        {
            return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, uint, int>)(lpVtbl[6]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), pguidEventIDs, cEvents);
        }
    }
}
