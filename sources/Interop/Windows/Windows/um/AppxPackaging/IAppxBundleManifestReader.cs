// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("CF0EBBC1-CC99-4106-91EB-E67462E04FB0")]
    [NativeTypeName("struct IAppxBundleManifestReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleManifestReader : IAppxBundleManifestReader.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, uint>)(lpVtbl[1]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, uint>)(lpVtbl[2]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator** packageInfoItems)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IAppxBundleManifestPackageInfoEnumerator**, int>)(lpVtbl[4]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), packageInfoItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStream(IStream** manifestStream)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IStream**, int>)(lpVtbl[5]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), manifestStream);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPackageId(IAppxManifestPackageId** packageId);

            [VtblIndex(4)]
            HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator** packageInfoItems);

            [VtblIndex(5)]
            HRESULT GetStream(IStream** manifestStream);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, uint> Release;

            [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, IAppxManifestPackageId**, int> GetPackageId;

            [NativeTypeName("HRESULT (IAppxBundleManifestPackageInfoEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, IAppxBundleManifestPackageInfoEnumerator**, int> GetPackageInfoItems;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestReader*, IStream**, int> GetStream;
        }
    }
}