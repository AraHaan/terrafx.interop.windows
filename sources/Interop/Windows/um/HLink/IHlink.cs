// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C3-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHlink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHlink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHlink*, Guid*, void**, int>)(lpVtbl[0]))((IHlink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHlink*, uint>)(lpVtbl[1]))((IHlink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHlink*, uint>)(lpVtbl[2]))((IHlink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetHlinkSite(IHlinkSite* pihlSite, [NativeTypeName("DWORD")] uint dwSiteData)
        {
            return ((delegate* unmanaged<IHlink*, IHlinkSite*, uint, int>)(lpVtbl[3]))((IHlink*)Unsafe.AsPointer(ref this), pihlSite, dwSiteData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHlinkSite(IHlinkSite** ppihlSite, [NativeTypeName("DWORD *")] uint* pdwSiteData)
        {
            return ((delegate* unmanaged<IHlink*, IHlinkSite**, uint*, int>)(lpVtbl[4]))((IHlink*)Unsafe.AsPointer(ref this), ppihlSite, pdwSiteData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetMonikerReference([NativeTypeName("DWORD")] uint grfHLSETF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation)
        {
            return ((delegate* unmanaged<IHlink*, uint, IMoniker*, ushort*, int>)(lpVtbl[5]))((IHlink*)Unsafe.AsPointer(ref this), grfHLSETF, pimkTarget, pwzLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMonikerReference([NativeTypeName("DWORD")] uint dwWhichRef, IMoniker** ppimkTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation)
        {
            return ((delegate* unmanaged<IHlink*, uint, IMoniker**, ushort**, int>)(lpVtbl[6]))((IHlink*)Unsafe.AsPointer(ref this), dwWhichRef, ppimkTarget, ppwzLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetStringReference([NativeTypeName("DWORD")] uint grfHLSETF, [NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation)
        {
            return ((delegate* unmanaged<IHlink*, uint, ushort*, ushort*, int>)(lpVtbl[7]))((IHlink*)Unsafe.AsPointer(ref this), grfHLSETF, pwzTarget, pwzLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetStringReference([NativeTypeName("DWORD")] uint dwWhichRef, [NativeTypeName("LPWSTR *")] ushort** ppwzTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation)
        {
            return ((delegate* unmanaged<IHlink*, uint, ushort**, ushort**, int>)(lpVtbl[8]))((IHlink*)Unsafe.AsPointer(ref this), dwWhichRef, ppwzTarget, ppwzLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlink*, ushort*, int>)(lpVtbl[9]))((IHlink*)Unsafe.AsPointer(ref this), pwzFriendlyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFriendlyName([NativeTypeName("DWORD")] uint grfHLFNAMEF, [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlink*, uint, ushort**, int>)(lpVtbl[10]))((IHlink*)Unsafe.AsPointer(ref this), grfHLFNAMEF, ppwzFriendlyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetTargetFrameName([NativeTypeName("LPCWSTR")] ushort* pwzTargetFrameName)
        {
            return ((delegate* unmanaged<IHlink*, ushort*, int>)(lpVtbl[11]))((IHlink*)Unsafe.AsPointer(ref this), pwzTargetFrameName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetTargetFrameName([NativeTypeName("LPWSTR *")] ushort** ppwzTargetFrameName)
        {
            return ((delegate* unmanaged<IHlink*, ushort**, int>)(lpVtbl[12]))((IHlink*)Unsafe.AsPointer(ref this), ppwzTargetFrameName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IHlink*, uint*, int>)(lpVtbl[13]))((IHlink*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Navigate([NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pibc, IBindStatusCallback* pibsc, IHlinkBrowseContext* pihlbc)
        {
            return ((delegate* unmanaged<IHlink*, uint, IBindCtx*, IBindStatusCallback*, IHlinkBrowseContext*, int>)(lpVtbl[14]))((IHlink*)Unsafe.AsPointer(ref this), grfHLNF, pibc, pibsc, pihlbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetAdditionalParams([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalParams)
        {
            return ((delegate* unmanaged<IHlink*, ushort*, int>)(lpVtbl[15]))((IHlink*)Unsafe.AsPointer(ref this), pwzAdditionalParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAdditionalParams([NativeTypeName("LPWSTR *")] ushort** ppwzAdditionalParams)
        {
            return ((delegate* unmanaged<IHlink*, ushort**, int>)(lpVtbl[16]))((IHlink*)Unsafe.AsPointer(ref this), ppwzAdditionalParams);
        }
    }
}
