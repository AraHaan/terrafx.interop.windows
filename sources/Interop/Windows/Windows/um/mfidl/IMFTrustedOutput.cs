// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D19F8E95-B126-4446-890C-5DCB7AD71453")]
    [NativeTypeName("struct IMFTrustedOutput : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTrustedOutput : IMFTrustedOutput.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, uint>)(lpVtbl[1]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, uint>)(lpVtbl[2]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetOutputTrustAuthorityCount([NativeTypeName("DWORD *")] uint* pcOutputTrustAuthorities)
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, uint*, int>)(lpVtbl[3]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), pcOutputTrustAuthorities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetOutputTrustAuthorityByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFOutputTrustAuthority** ppauthority)
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, uint, IMFOutputTrustAuthority**, int>)(lpVtbl[4]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), dwIndex, ppauthority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsFinal(BOOL* pfIsFinal)
        {
            return ((delegate* unmanaged<IMFTrustedOutput*, BOOL*, int>)(lpVtbl[5]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), pfIsFinal);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetOutputTrustAuthorityCount([NativeTypeName("DWORD *")] uint* pcOutputTrustAuthorities);

            [VtblIndex(4)]
            HRESULT GetOutputTrustAuthorityByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFOutputTrustAuthority** ppauthority);

            [VtblIndex(5)]
            HRESULT IsFinal(BOOL* pfIsFinal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, uint*, int> GetOutputTrustAuthorityCount;

            [NativeTypeName("HRESULT (DWORD, IMFOutputTrustAuthority **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, uint, IMFOutputTrustAuthority**, int> GetOutputTrustAuthorityByIndex;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTrustedOutput*, BOOL*, int> IsFinal;
        }
    }
}