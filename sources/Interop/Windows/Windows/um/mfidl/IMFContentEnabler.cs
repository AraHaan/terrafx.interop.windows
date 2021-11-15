// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D3C4EF59-49CE-4381-9071-D5BCD044C770")]
    [NativeTypeName("struct IMFContentEnabler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFContentEnabler : IMFContentEnabler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentEnabler*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentEnabler*, uint>)(lpVtbl[1]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentEnabler*, uint>)(lpVtbl[2]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEnableType(Guid* pType)
        {
            return ((delegate* unmanaged<IMFContentEnabler*, Guid*, int>)(lpVtbl[3]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetEnableURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL, [NativeTypeName("DWORD *")] uint* pcchURL, MF_URL_TRUST_STATUS* pTrustStatus)
        {
            return ((delegate* unmanaged<IMFContentEnabler*, ushort**, uint*, MF_URL_TRUST_STATUS*, int>)(lpVtbl[4]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppwszURL, pcchURL, pTrustStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
        {
            return ((delegate* unmanaged<IMFContentEnabler*, byte**, uint*, int>)(lpVtbl[5]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppbData, pcbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsAutomaticSupported(BOOL* pfAutomatic)
        {
            return ((delegate* unmanaged<IMFContentEnabler*, BOOL*, int>)(lpVtbl[6]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pfAutomatic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AutomaticEnable()
        {
            return ((delegate* unmanaged<IMFContentEnabler*, int>)(lpVtbl[7]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MonitorEnable()
        {
            return ((delegate* unmanaged<IMFContentEnabler*, int>)(lpVtbl[8]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Cancel()
        {
            return ((delegate* unmanaged<IMFContentEnabler*, int>)(lpVtbl[9]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetEnableType(Guid* pType);

            [VtblIndex(4)]
            HRESULT GetEnableURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL, [NativeTypeName("DWORD *")] uint* pcchURL, MF_URL_TRUST_STATUS* pTrustStatus);

            [VtblIndex(5)]
            HRESULT GetEnableData(byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData);

            [VtblIndex(6)]
            HRESULT IsAutomaticSupported(BOOL* pfAutomatic);

            [VtblIndex(7)]
            HRESULT AutomaticEnable();

            [VtblIndex(8)]
            HRESULT MonitorEnable();

            [VtblIndex(9)]
            HRESULT Cancel();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, Guid*, int> GetEnableType;

            [NativeTypeName("HRESULT (LPWSTR *, DWORD *, MF_URL_TRUST_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, ushort**, uint*, MF_URL_TRUST_STATUS*, int> GetEnableURL;

            [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, byte**, uint*, int> GetEnableData;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, BOOL*, int> IsAutomaticSupported;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, int> AutomaticEnable;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, int> MonitorEnable;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentEnabler*, int> Cancel;
        }
    }
}