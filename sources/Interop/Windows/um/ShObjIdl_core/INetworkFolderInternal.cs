// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CEB38218-C971-47BB-A703-F0BC99CCDB81")]
    [NativeTypeName("struct INetworkFolderInternal : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INetworkFolderInternal
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, Guid*, void**, int>)(lpVtbl[0]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, uint>)(lpVtbl[1]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, uint>)(lpVtbl[2]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetResourceDisplayType([NativeTypeName("UINT *")] uint* displayType)
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, uint*, int>)(lpVtbl[3]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), displayType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** idList)
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, ITEMIDLIST**, int>)(lpVtbl[4]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), idList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetProvider([NativeTypeName("UINT")] uint itemIdCount, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** itemIds, [NativeTypeName("UINT")] uint providerMaxLength, [NativeTypeName("LPWSTR")] ushort* provider)
        {
            return ((delegate* unmanaged<INetworkFolderInternal*, uint, ITEMIDLIST**, uint, ushort*, int>)(lpVtbl[5]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), itemIdCount, itemIds, providerMaxLength, provider);
        }
    }
}
