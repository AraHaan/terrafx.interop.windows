// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("000001CF-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMarshal2 : IMarshal")]
    [NativeInheritance("IMarshal")]
    public unsafe partial struct IMarshal2 : IMarshal2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarshal2*, Guid*, void**, int>)(lpVtbl[0]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarshal2*, uint>)(lpVtbl[1]))((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarshal2*, uint>)(lpVtbl[2]))((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return ((delegate* unmanaged<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)(lpVtbl[3]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return ((delegate* unmanaged<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return ((delegate* unmanaged<IMarshal2*, IStream*, Guid*, void*, uint, void*, uint, int>)(lpVtbl[5]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UnmarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMarshal2*, IStream*, Guid*, void**, int>)(lpVtbl[6]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ReleaseMarshalData(IStream* pStm)
        {
            return ((delegate* unmanaged<IMarshal2*, IStream*, int>)(lpVtbl[7]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IMarshal2*, uint, int>)(lpVtbl[8]))((IMarshal2*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public interface Interface : IMarshal.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int> GetUnmarshalClass;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int> GetMarshalSizeMax;

            [NativeTypeName("HRESULT (IStream *, const IID &, void *, DWORD, void *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, IStream*, Guid*, void*, uint, void*, uint, int> MarshalInterface;

            [NativeTypeName("HRESULT (IStream *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, IStream*, Guid*, void**, int> UnmarshalInterface;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, IStream*, int> ReleaseMarshalData;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarshal2*, uint, int> DisconnectObject;
        }
    }
}