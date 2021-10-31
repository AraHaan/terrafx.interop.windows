// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IEnumConnectionPoints : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumConnectionPoints
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, Guid*, void**, int>)(lpVtbl[0]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, uint>)(lpVtbl[1]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, uint>)(lpVtbl[2]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTIONPOINT *")] IConnectionPoint** ppCP, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)(lpVtbl[3]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections, ppCP, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint cConnections)
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, uint, int>)(lpVtbl[4]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, int>)(lpVtbl[5]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumConnectionPoints** ppEnum)
        {
            return ((delegate* unmanaged<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)(lpVtbl[6]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
