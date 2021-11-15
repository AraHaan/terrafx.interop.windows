// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("37A378C0-F82D-11CE-AE65-08002B2E1262")]
    [NativeTypeName("struct IShellFolderView : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellFolderView : IShellFolderView.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderView*, uint>)(lpVtbl[1]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderView*, uint>)(lpVtbl[2]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Rearrange(LPARAM lParamSort)
        {
            return ((delegate* unmanaged<IShellFolderView*, LPARAM, int>)(lpVtbl[3]))((IShellFolderView*)Unsafe.AsPointer(ref this), lParamSort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetArrangeParam(LPARAM* plParamSort)
        {
            return ((delegate* unmanaged<IShellFolderView*, LPARAM*, int>)(lpVtbl[4]))((IShellFolderView*)Unsafe.AsPointer(ref this), plParamSort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ArrangeGrid()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[5]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AutoArrange()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[6]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetAutoArrange()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[7]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[8]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetObjectW([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, uint uItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST**, uint, int>)(lpVtbl[9]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppidl, uItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RemoveObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[10]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetObjectCount(uint* puCount)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[11]))((IShellFolderView*)Unsafe.AsPointer(ref this), puCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetObjectCount(uint uCount, uint dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint, uint, int>)(lpVtbl[12]))((IShellFolderView*)Unsafe.AsPointer(ref this), uCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT UpdateObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlOld, [NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlNew, uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, ITEMIDLIST*, uint*, int>)(lpVtbl[13]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidlOld, pidlNew, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT RefreshObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[14]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetRedraw(BOOL bRedraw)
        {
            return ((delegate* unmanaged<IShellFolderView*, BOOL, int>)(lpVtbl[15]))((IShellFolderView*)Unsafe.AsPointer(ref this), bRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetSelectedCount(uint* puSelected)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[16]))((IShellFolderView*)Unsafe.AsPointer(ref this), puSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetSelectedObjects([NativeTypeName("LPCITEMIDLIST **")] ITEMIDLIST*** pppidl, uint* puItems)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST***, uint*, int>)(lpVtbl[17]))((IShellFolderView*)Unsafe.AsPointer(ref this), pppidl, puItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT IsDropOnSource(IDropTarget* pDropTarget)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDropTarget*, int>)(lpVtbl[18]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDropTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetDragPoint(POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, POINT*, int>)(lpVtbl[19]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetDropPoint(POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, POINT*, int>)(lpVtbl[20]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT MoveIcons(IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDataObject*, int>)(lpVtbl[21]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetItemPos([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, POINT*, int>)(lpVtbl[22]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT IsBkDropTarget(IDropTarget* pDropTarget)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDropTarget*, int>)(lpVtbl[23]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDropTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetClipboard(BOOL bMove)
        {
            return ((delegate* unmanaged<IShellFolderView*, BOOL, int>)(lpVtbl[24]))((IShellFolderView*)Unsafe.AsPointer(ref this), bMove);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetPoints(IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDataObject*, int>)(lpVtbl[25]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetItemSpacing(ITEMSPACING* pSpacing)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMSPACING*, int>)(lpVtbl[26]))((IShellFolderView*)Unsafe.AsPointer(ref this), pSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetCallback(IShellFolderViewCB* pNewCB, IShellFolderViewCB** ppOldCB)
        {
            return ((delegate* unmanaged<IShellFolderView*, IShellFolderViewCB*, IShellFolderViewCB**, int>)(lpVtbl[27]))((IShellFolderView*)Unsafe.AsPointer(ref this), pNewCB, ppOldCB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT Select(uint dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint, int>)(lpVtbl[28]))((IShellFolderView*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT QuerySupport(uint* pdwSupport)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[29]))((IShellFolderView*)Unsafe.AsPointer(ref this), pdwSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetAutomationObject(IDispatch* pdisp)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDispatch*, int>)(lpVtbl[30]))((IShellFolderView*)Unsafe.AsPointer(ref this), pdisp);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Rearrange(LPARAM lParamSort);

            [VtblIndex(4)]
            HRESULT GetArrangeParam(LPARAM* plParamSort);

            [VtblIndex(5)]
            HRESULT ArrangeGrid();

            [VtblIndex(6)]
            HRESULT AutoArrange();

            [VtblIndex(7)]
            HRESULT GetAutoArrange();

            [VtblIndex(8)]
            HRESULT AddObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem);

            [VtblIndex(9)]
            HRESULT GetObjectW([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, uint uItem);

            [VtblIndex(10)]
            HRESULT RemoveObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem);

            [VtblIndex(11)]
            HRESULT GetObjectCount(uint* puCount);

            [VtblIndex(12)]
            HRESULT SetObjectCount(uint uCount, uint dwFlags);

            [VtblIndex(13)]
            HRESULT UpdateObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlOld, [NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlNew, uint* puItem);

            [VtblIndex(14)]
            HRESULT RefreshObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, uint* puItem);

            [VtblIndex(15)]
            HRESULT SetRedraw(BOOL bRedraw);

            [VtblIndex(16)]
            HRESULT GetSelectedCount(uint* puSelected);

            [VtblIndex(17)]
            HRESULT GetSelectedObjects([NativeTypeName("LPCITEMIDLIST **")] ITEMIDLIST*** pppidl, uint* puItems);

            [VtblIndex(18)]
            HRESULT IsDropOnSource(IDropTarget* pDropTarget);

            [VtblIndex(19)]
            HRESULT GetDragPoint(POINT* ppt);

            [VtblIndex(20)]
            HRESULT GetDropPoint(POINT* ppt);

            [VtblIndex(21)]
            HRESULT MoveIcons(IDataObject* pDataObject);

            [VtblIndex(22)]
            HRESULT SetItemPos([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt);

            [VtblIndex(23)]
            HRESULT IsBkDropTarget(IDropTarget* pDropTarget);

            [VtblIndex(24)]
            HRESULT SetClipboard(BOOL bMove);

            [VtblIndex(25)]
            HRESULT SetPoints(IDataObject* pDataObject);

            [VtblIndex(26)]
            HRESULT GetItemSpacing(ITEMSPACING* pSpacing);

            [VtblIndex(27)]
            HRESULT SetCallback(IShellFolderViewCB* pNewCB, IShellFolderViewCB** ppOldCB);

            [VtblIndex(28)]
            HRESULT Select(uint dwFlags);

            [VtblIndex(29)]
            HRESULT QuerySupport(uint* pdwSupport);

            [VtblIndex(30)]
            HRESULT SetAutomationObject(IDispatch* pdisp);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint> Release;

            [NativeTypeName("HRESULT (LPARAM) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, LPARAM, int> Rearrange;

            [NativeTypeName("HRESULT (LPARAM *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, LPARAM*, int> GetArrangeParam;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, int> ArrangeGrid;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, int> AutoArrange;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, int> GetAutoArrange;

            [NativeTypeName("HRESULT (LPITEMIDLIST, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int> AddObject;

            [NativeTypeName("HRESULT (LPITEMIDLIST *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST**, uint, int> GetObjectW;

            [NativeTypeName("HRESULT (LPITEMIDLIST, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int> RemoveObject;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint*, int> GetObjectCount;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint, uint, int> SetObjectCount;

            [NativeTypeName("HRESULT (LPITEMIDLIST, LPITEMIDLIST, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, ITEMIDLIST*, uint*, int> UpdateObject;

            [NativeTypeName("HRESULT (LPITEMIDLIST, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int> RefreshObject;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, BOOL, int> SetRedraw;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint*, int> GetSelectedCount;

            [NativeTypeName("HRESULT (LPCITEMIDLIST **, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST***, uint*, int> GetSelectedObjects;

            [NativeTypeName("HRESULT (IDropTarget *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IDropTarget*, int> IsDropOnSource;

            [NativeTypeName("HRESULT (POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, POINT*, int> GetDragPoint;

            [NativeTypeName("HRESULT (POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, POINT*, int> GetDropPoint;

            [NativeTypeName("HRESULT (IDataObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IDataObject*, int> MoveIcons;

            [NativeTypeName("HRESULT (LPCITEMIDLIST, POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, POINT*, int> SetItemPos;

            [NativeTypeName("HRESULT (IDropTarget *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IDropTarget*, int> IsBkDropTarget;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, BOOL, int> SetClipboard;

            [NativeTypeName("HRESULT (IDataObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IDataObject*, int> SetPoints;

            [NativeTypeName("HRESULT (ITEMSPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, ITEMSPACING*, int> GetItemSpacing;

            [NativeTypeName("HRESULT (IShellFolderViewCB *, IShellFolderViewCB **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IShellFolderViewCB*, IShellFolderViewCB**, int> SetCallback;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint, int> Select;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, uint*, int> QuerySupport;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFolderView*, IDispatch*, int> SetAutomationObject;
        }
    }
}