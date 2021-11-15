// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("89C31040-846B-11CE-97D3-00AA0055595A")]
    [NativeTypeName("struct IEnumMediaTypes : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumMediaTypes : IEnumMediaTypes.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, Guid*, void**, int>)(lpVtbl[0]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, uint>)(lpVtbl[1]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, uint>)(lpVtbl[2]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint cMediaTypes, AM_MEDIA_TYPE** ppMediaTypes, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, uint, AM_MEDIA_TYPE**, uint*, int>)(lpVtbl[3]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), cMediaTypes, ppMediaTypes, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint cMediaTypes)
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, uint, int>)(lpVtbl[4]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), cMediaTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, int>)(lpVtbl[5]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumMediaTypes** ppEnum)
        {
            return ((delegate* unmanaged<IEnumMediaTypes*, IEnumMediaTypes**, int>)(lpVtbl[6]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Next([NativeTypeName("ULONG")] uint cMediaTypes, AM_MEDIA_TYPE** ppMediaTypes, [NativeTypeName("ULONG *")] uint* pcFetched);

            [VtblIndex(4)]
            HRESULT Skip([NativeTypeName("ULONG")] uint cMediaTypes);

            [VtblIndex(5)]
            HRESULT Reset();

            [VtblIndex(6)]
            HRESULT Clone(IEnumMediaTypes** ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, AM_MEDIA_TYPE **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, uint, AM_MEDIA_TYPE**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, int> Reset;

            [NativeTypeName("HRESULT (IEnumMediaTypes **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumMediaTypes*, IEnumMediaTypes**, int> Clone;
        }
    }
}