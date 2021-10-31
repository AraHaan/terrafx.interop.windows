// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D19F8E98-B126-4446-890C-5DCB7AD71453")]
    [NativeTypeName("struct IMFInputTrustAuthority : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFInputTrustAuthority
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, Guid*, void**, int>)(lpVtbl[0]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, uint>)(lpVtbl[1]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, uint>)(lpVtbl[2]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDecrypter([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, Guid*, void**, int>)(lpVtbl[3]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RequestAccess(MFPOLICYMANAGER_ACTION Action, IMFActivate** ppContentEnablerActivate)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, MFPOLICYMANAGER_ACTION, IMFActivate**, int>)(lpVtbl[4]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), Action, ppContentEnablerActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPolicy(MFPOLICYMANAGER_ACTION Action, IMFOutputPolicy** ppPolicy)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, MFPOLICYMANAGER_ACTION, IMFOutputPolicy**, int>)(lpVtbl[5]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), Action, ppPolicy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BindAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int>)(lpVtbl[6]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), pParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UpdateAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int>)(lpVtbl[7]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), pParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IMFInputTrustAuthority*, int>)(lpVtbl[8]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }
    }
}
