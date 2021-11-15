// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("C004F646-BE2C-48F3-93A2-A0983EBA1108")]
    [NativeTypeName("struct IMFPMPClientApp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFPMPClientApp : IMFPMPClientApp.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMPClientApp*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMPClientApp*, uint>)(lpVtbl[1]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMPClientApp*, uint>)(lpVtbl[2]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPMPHost(IMFPMPHostApp* pPMPHost)
        {
            return ((delegate* unmanaged<IMFPMPClientApp*, IMFPMPHostApp*, int>)(lpVtbl[3]))((IMFPMPClientApp*)Unsafe.AsPointer(ref this), pPMPHost);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetPMPHost(IMFPMPHostApp* pPMPHost);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPClientApp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPClientApp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPClientApp*, uint> Release;

            [NativeTypeName("HRESULT (IMFPMPHostApp *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPClientApp*, IMFPMPHostApp*, int> SetPMPHost;
        }
    }
}