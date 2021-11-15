// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("73131F9C-56A9-49DD-B0EE-D046633F7528")]
    [NativeTypeName("struct ITfSourceSingle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfSourceSingle : ITfSourceSingle.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, Guid*, void**, int>)(lpVtbl[0]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint>)(lpVtbl[1]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint>)(lpVtbl[2]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, IUnknown*, int>)(lpVtbl[3]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, int>)(lpVtbl[4]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AdviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);

            [VtblIndex(4)]
            HRESULT UnadviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSourceSingle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSourceSingle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSourceSingle*, uint> Release;

            [NativeTypeName("HRESULT (TfClientId, const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSourceSingle*, uint, Guid*, IUnknown*, int> AdviseSingleSink;

            [NativeTypeName("HRESULT (TfClientId, const IID &) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfSourceSingle*, uint, Guid*, int> UnadviseSingleSink;
        }
    }
}