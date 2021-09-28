// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BF992A9-AF7A-4DBA-B2E5-4D080B1ECBC6")]
    [NativeTypeName("struct IStorageProviderCopyHook : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IStorageProviderCopyHook
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageProviderCopyHook*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageProviderCopyHook*, uint>)(lpVtbl[1]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageProviderCopyHook*, uint>)(lpVtbl[2]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CopyCallback([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint operation, [NativeTypeName("UINT")] uint flags, [NativeTypeName("LPCWSTR")] ushort* srcFile, [NativeTypeName("DWORD")] uint srcAttribs, [NativeTypeName("LPCWSTR")] ushort* destFile, [NativeTypeName("DWORD")] uint destAttribs, [NativeTypeName("UINT *")] uint* result)
        {
            return ((delegate* unmanaged<IStorageProviderCopyHook*, IntPtr, uint, uint, ushort*, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this), hwnd, operation, flags, srcFile, srcAttribs, destFile, destAttribs, result);
        }
    }
}