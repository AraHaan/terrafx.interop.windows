// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("E982CE48-0B96-440C-BC37-0C869B27A29E")]
    [NativeTypeName("struct IUriBuilderFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUriBuilderFactory : IUriBuilderFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUriBuilderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUriBuilderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUriBuilderFactory*, uint>)(lpVtbl[1]))((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUriBuilderFactory*, uint>)(lpVtbl[2]))((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder)
        {
            return ((delegate* unmanaged<IUriBuilderFactory*, uint, nuint, IUriBuilder**, int>)(lpVtbl[3]))((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateInitializedIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder)
        {
            return ((delegate* unmanaged<IUriBuilderFactory*, uint, nuint, IUriBuilder**, int>)(lpVtbl[4]))((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);

            [VtblIndex(4)]
            HRESULT CreateInitializedIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUriBuilderFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUriBuilderFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUriBuilderFactory*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUriBuilderFactory*, uint, nuint, IUriBuilder**, int> CreateIUriBuilder;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUriBuilderFactory*, uint, nuint, IUriBuilder**, int> CreateInitializedIUriBuilder;
        }
    }
}