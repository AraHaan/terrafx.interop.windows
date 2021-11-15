// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D4236675-A5BF-4570-9D42-5D6D7B02D59B")]
    [NativeTypeName("struct ITfLMLattice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfLMLattice : ITfLMLattice.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLMLattice*, Guid*, void**, int>)(lpVtbl[0]))((ITfLMLattice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLMLattice*, uint>)(lpVtbl[1]))((ITfLMLattice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLMLattice*, uint>)(lpVtbl[2]))((ITfLMLattice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported)
        {
            return ((delegate* unmanaged<ITfLMLattice*, Guid*, BOOL*, int>)(lpVtbl[3]))((ITfLMLattice*)Unsafe.AsPointer(ref this), rguidType, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumLatticeElements([NativeTypeName("DWORD")] uint dwFrameStart, [NativeTypeName("const GUID &")] Guid* rguidType, IEnumTfLatticeElements** ppEnum)
        {
            return ((delegate* unmanaged<ITfLMLattice*, uint, Guid*, IEnumTfLatticeElements**, int>)(lpVtbl[4]))((ITfLMLattice*)Unsafe.AsPointer(ref this), dwFrameStart, rguidType, ppEnum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported);

            [VtblIndex(4)]
            HRESULT EnumLatticeElements([NativeTypeName("DWORD")] uint dwFrameStart, [NativeTypeName("const GUID &")] Guid* rguidType, IEnumTfLatticeElements** ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLMLattice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLMLattice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLMLattice*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLMLattice*, Guid*, BOOL*, int> QueryType;

            [NativeTypeName("HRESULT (DWORD, const GUID &, IEnumTfLatticeElements **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLMLattice*, uint, Guid*, IEnumTfLatticeElements**, int> EnumLatticeElements;
        }
    }
}