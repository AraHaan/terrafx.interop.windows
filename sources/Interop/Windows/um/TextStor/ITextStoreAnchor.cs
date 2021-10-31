// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B2077B0-5F18-4DEC-BEE9-3CC722F5DFE0")]
    [NativeTypeName("struct ITextStoreAnchor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITextStoreAnchor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint>)(lpVtbl[1]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint>)(lpVtbl[2]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, IUnknown*, uint, int>)(lpVtbl[3]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), riid, punk, dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseSink(IUnknown* punk)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IUnknown*, int>)(lpVtbl[4]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, HRESULT* phrSession)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, HRESULT*, int>)(lpVtbl[5]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwLockFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetStatus(TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, TS_STATUS*, int>)(lpVtbl[6]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT QueryInsert(IAnchor* paTestStart, IAnchor* paTestEnd, [NativeTypeName("ULONG")] uint cch, IAnchor** ppaResultStart, IAnchor** ppaResultEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, uint, IAnchor**, IAnchor**, int>)(lpVtbl[7]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paTestStart, paTestEnd, cch, ppaResultStart, ppaResultEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TS_SELECTION_ANCHOR* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, uint, TS_SELECTION_ANCHOR*, uint*, int>)(lpVtbl[8]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ANCHOR *")] TS_SELECTION_ANCHOR* pSelection)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, TS_SELECTION_ANCHOR*, int>)(lpVtbl[9]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetText([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchReq, [NativeTypeName("ULONG *")] uint* pcch, BOOL fUpdateAnchor)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, ushort*, uint, uint*, BOOL, int>)(lpVtbl[10]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pchText, cchReq, pcch, fUpdateAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetText([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, ushort*, uint, int>)(lpVtbl[11]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFormattedText(IAnchor* paStart, IAnchor* paEnd, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, IDataObject**, int>)(lpVtbl[12]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paStart, paEnd, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetEmbedded([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[13]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paPos, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, IDataObject*, int>)(lpVtbl[14]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, uint, Guid*, int>)(lpVtbl[15]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, cFilterAttrs, paFilterAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT RequestAttrsAtPosition(IAnchor* paPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, uint, Guid*, uint, int>)(lpVtbl[16]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT RequestAttrsTransitioningAtPosition(IAnchor* paPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, uint, Guid*, uint, int>)(lpVtbl[17]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT FindNextAttrTransition(IAnchor* paStart, IAnchor* paHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, BOOL* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, uint, Guid*, uint, BOOL*, int*, int>)(lpVtbl[18]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paStart, paHalt, cFilterAttrs, paFilterAttrs, dwFlags, pfFound, plFoundOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, TS_ATTRVAL*, uint*, int>)(lpVtbl[19]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulCount, paAttrVals, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetStart(IAnchor** ppaStart)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor**, int>)(lpVtbl[20]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ppaStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetEnd(IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor**, int>)(lpVtbl[21]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ppaEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint*, int>)(lpVtbl[22]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pvcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetAnchorFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, IAnchor** ppaSite)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, POINT*, uint, IAnchor**, int>)(lpVtbl[23]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, ptScreen, dwFlags, ppaSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, IAnchor* paStart, IAnchor* paEnd, RECT* prc, BOOL* pfClipped)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, RECT*, BOOL*, int>)(lpVtbl[24]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, paStart, paEnd, prc, pfClipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, RECT*, int>)(lpVtbl[25]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetWnd([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IntPtr*, int>)(lpVtbl[26]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, BOOL* pfInsertable)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, FORMATETC*, BOOL*, int>)(lpVtbl[27]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, IAnchor** ppaStart, IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, ushort*, uint, IAnchor**, IAnchor**, int>)(lpVtbl[28]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, pchText, cch, ppaStart, ppaEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject, IAnchor** ppaStart, IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IDataObject*, IAnchor**, IAnchor**, int>)(lpVtbl[29]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, pDataObject, ppaStart, ppaEnd);
        }
    }
}
