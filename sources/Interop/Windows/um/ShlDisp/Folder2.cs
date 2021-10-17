// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0D2D8EF-3890-11D2-BF8B-00C04FB93661")]
    [NativeTypeName("struct Folder2 : Folder")]
    [NativeInheritance("Folder")]
    public unsafe partial struct Folder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<Folder2*, Guid*, void**, int>)(lpVtbl[0]))((Folder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<Folder2*, uint>)(lpVtbl[1]))((Folder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<Folder2*, uint>)(lpVtbl[2]))((Folder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<Folder2*, uint*, int>)(lpVtbl[3]))((Folder2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<Folder2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((Folder2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<Folder2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((Folder2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<Folder2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((Folder2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<Folder2*, ushort**, int>)(lpVtbl[7]))((Folder2*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<Folder2*, IDispatch**, int>)(lpVtbl[8]))((Folder2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<Folder2*, IDispatch**, int>)(lpVtbl[9]))((Folder2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_ParentFolder(Folder** ppsf)
        {
            return ((delegate* unmanaged<Folder2*, Folder**, int>)(lpVtbl[10]))((Folder2*)Unsafe.AsPointer(ref this), ppsf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Items(FolderItems** ppid)
        {
            return ((delegate* unmanaged<Folder2*, FolderItems**, int>)(lpVtbl[11]))((Folder2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ParseName([NativeTypeName("BSTR")] ushort* bName, FolderItem** ppid)
        {
            return ((delegate* unmanaged<Folder2*, ushort*, FolderItem**, int>)(lpVtbl[12]))((Folder2*)Unsafe.AsPointer(ref this), bName, ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int NewFolder([NativeTypeName("BSTR")] ushort* bName, VARIANT vOptions)
        {
            return ((delegate* unmanaged<Folder2*, ushort*, VARIANT, int>)(lpVtbl[13]))((Folder2*)Unsafe.AsPointer(ref this), bName, vOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int MoveHere(VARIANT vItem, VARIANT vOptions)
        {
            return ((delegate* unmanaged<Folder2*, VARIANT, VARIANT, int>)(lpVtbl[14]))((Folder2*)Unsafe.AsPointer(ref this), vItem, vOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CopyHere(VARIANT vItem, VARIANT vOptions)
        {
            return ((delegate* unmanaged<Folder2*, VARIANT, VARIANT, int>)(lpVtbl[15]))((Folder2*)Unsafe.AsPointer(ref this), vItem, vOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetDetailsOf(VARIANT vItem, int iColumn, [NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<Folder2*, VARIANT, int, ushort**, int>)(lpVtbl[16]))((Folder2*)Unsafe.AsPointer(ref this), vItem, iColumn, pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_Self(FolderItem** ppfi)
        {
            return ((delegate* unmanaged<Folder2*, FolderItem**, int>)(lpVtbl[17]))((Folder2*)Unsafe.AsPointer(ref this), ppfi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_OfflineStatus([NativeTypeName("LONG *")] int* pul)
        {
            return ((delegate* unmanaged<Folder2*, int*, int>)(lpVtbl[18]))((Folder2*)Unsafe.AsPointer(ref this), pul);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int Synchronize()
        {
            return ((delegate* unmanaged<Folder2*, int>)(lpVtbl[19]))((Folder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_HaveToShowWebViewBarricade([NativeTypeName("VARIANT_BOOL *")] short* pbHaveToShowWebViewBarricade)
        {
            return ((delegate* unmanaged<Folder2*, short*, int>)(lpVtbl[20]))((Folder2*)Unsafe.AsPointer(ref this), pbHaveToShowWebViewBarricade);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int DismissedWebViewBarricade()
        {
            return ((delegate* unmanaged<Folder2*, int>)(lpVtbl[21]))((Folder2*)Unsafe.AsPointer(ref this));
        }
    }
}
