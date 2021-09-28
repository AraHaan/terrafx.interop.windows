// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7690AA79-F8FC-4615-A327-36F7D18F5D91")]
    [NativeTypeName("struct IDefaultFolderMenuInitialize : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDefaultFolderMenuInitialize
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, Guid*, void**, int>)(lpVtbl[0]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, uint>)(lpVtbl[1]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, uint>)(lpVtbl[2]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("HWND")] IntPtr hwnd, IContextMenuCB* pcmcb, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IShellFolder* psf, [NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IUnknown* punkAssociation, [NativeTypeName("UINT")] uint cKeys, [NativeTypeName("const HKEY *")] IntPtr* aKeys)
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, IntPtr, IContextMenuCB*, ITEMIDLIST*, IShellFolder*, uint, ITEMIDLIST**, IUnknown*, uint, IntPtr*, int>)(lpVtbl[3]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), hwnd, pcmcb, pidlFolder, psf, cidl, apidl, punkAssociation, cKeys, aKeys);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrValues)
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, DEFAULT_FOLDER_MENU_RESTRICTIONS, int>)(lpVtbl[4]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), dfmrValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrMask, DEFAULT_FOLDER_MENU_RESTRICTIONS* pdfmrValues)
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, DEFAULT_FOLDER_MENU_RESTRICTIONS, DEFAULT_FOLDER_MENU_RESTRICTIONS*, int>)(lpVtbl[5]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), dfmrMask, pdfmrValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetHandlerClsid([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, Guid*, int>)(lpVtbl[6]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), rclsid);
        }
    }
}