// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BFE56B0-390C-4863-9430-1F3D083B7684")]
    [NativeTypeName("struct IDiaInputAssemblyFile : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaInputAssemblyFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, Guid*, void**, int>)(lpVtbl[0]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint>)(lpVtbl[1]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint>)(lpVtbl[2]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[3]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_index([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[4]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_timestamp([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint*, int>)(lpVtbl[5]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_pdbAvailableAtILMerge(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, BOOL*, int>)(lpVtbl[6]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_fileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, ushort**, int>)(lpVtbl[7]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_version([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaInputAssemblyFile*, uint, uint*, byte*, int>)(lpVtbl[8]))((IDiaInputAssemblyFile*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
        }
    }
}
