// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2EF5353-F5A8-4EB3-90D2-CB526ACB3CDD")]
    [NativeTypeName("struct IDiaSourceFile : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaSourceFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSourceFile*, uint>)(lpVtbl[1]))((IDiaSourceFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSourceFile*, uint>)(lpVtbl[2]))((IDiaSourceFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, uint*, int>)(lpVtbl[3]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, ushort**, int>)(lpVtbl[4]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_checksumType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, uint*, int>)(lpVtbl[5]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_compilands(IDiaEnumSymbols** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, IDiaEnumSymbols**, int>)(lpVtbl[6]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_checksum([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaSourceFile*, uint, uint*, byte*, int>)(lpVtbl[7]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
        }
    }
}