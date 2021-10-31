// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000139-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATPROPSTG : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSTATPROPSTG
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, uint>)(lpVtbl[1]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, uint>)(lpVtbl[2]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, STATPROPSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, uint, STATPROPSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, int>)(lpVtbl[5]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumSTATPROPSTG** ppenum)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSTG*, IEnumSTATPROPSTG**, int>)(lpVtbl[6]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
