// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("973810AE-9599-4B88-9E4D-6EE98C9552DA")]
    [NativeTypeName("struct IEnumAssocHandlers : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumAssocHandlers : IEnumAssocHandlers.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumAssocHandlers*, Guid*, void**, int>)(lpVtbl[0]))((IEnumAssocHandlers*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumAssocHandlers*, uint>)(lpVtbl[1]))((IEnumAssocHandlers*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumAssocHandlers*, uint>)(lpVtbl[2]))((IEnumAssocHandlers*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IAssocHandler** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumAssocHandlers*, uint, IAssocHandler**, uint*, int>)(lpVtbl[3]))((IEnumAssocHandlers*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, IAssocHandler** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumAssocHandlers*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumAssocHandlers*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumAssocHandlers*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, IAssocHandler **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumAssocHandlers*, uint, IAssocHandler**, uint*, int> Next;
        }
    }
}