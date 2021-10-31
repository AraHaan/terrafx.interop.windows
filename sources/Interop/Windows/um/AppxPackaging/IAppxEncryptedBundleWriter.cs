// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80B0902F-7BF0-4117-B8C6-4279EF81EE77")]
    [NativeTypeName("struct IAppxEncryptedBundleWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptedBundleWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedBundleWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter*, uint>)(lpVtbl[1]))((IAppxEncryptedBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter*, uint>)(lpVtbl[2]))((IAppxEncryptedBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadPackageEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxEncryptedBundleWriter*)Unsafe.AsPointer(ref this), fileName, packageStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter*, int>)(lpVtbl[4]))((IAppxEncryptedBundleWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
