// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("C8263AAC-9E0C-4A2D-9B8E-007521A3317C")]
    [NativeTypeName("struct IDMLObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDMLObject : IDMLObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLObject*, Guid*, void**, int>)(lpVtbl[0]))((IDMLObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLObject*, uint>)(lpVtbl[1]))((IDMLObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLObject*, uint>)(lpVtbl[2]))((IDMLObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLObject*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLObject*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLObject*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLObject*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLObject*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLObject*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLObject*, ushort*, int>)(lpVtbl[6]))((IDMLObject*)Unsafe.AsPointer(ref this), name);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data);

            [VtblIndex(4)]
            HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data);

            [VtblIndex(5)]
            HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data);

            [VtblIndex(6)]
            HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLObject*, ushort*, int> SetName;
        }
    }
}