// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("192B9D83-50FC-457B-90A0-2B82A8B5DAE1")]
    [NativeTypeName("struct IImageList2 : IImageList")]
    [NativeInheritance("IImageList")]
    public unsafe partial struct IImageList2 : IImageList2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[0]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageList2*, uint>)(lpVtbl[1]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageList2*, uint>)(lpVtbl[2]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Add(HBITMAP hbmImage, HBITMAP hbmMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, HBITMAP, HBITMAP, int*, int>)(lpVtbl[3]))((IImageList2*)Unsafe.AsPointer(ref this), hbmImage, hbmMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReplaceIcon(int i, HICON hicon, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, int, HICON, int*, int>)(lpVtbl[4]))((IImageList2*)Unsafe.AsPointer(ref this), i, hicon, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOverlayImage(int iImage, int iOverlay)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[5]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, iOverlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Replace(int i, HBITMAP hbmImage, HBITMAP hbmMask)
        {
            return ((delegate* unmanaged<IImageList2*, int, HBITMAP, HBITMAP, int>)(lpVtbl[6]))((IImageList2*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddMasked(HBITMAP hbmImage, COLORREF crMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, HBITMAP, COLORREF, int*, int>)(lpVtbl[7]))((IImageList2*)Unsafe.AsPointer(ref this), hbmImage, crMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Draw(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[8]))((IImageList2*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Remove(int i)
        {
            return ((delegate* unmanaged<IImageList2*, int, int>)(lpVtbl[9]))((IImageList2*)Unsafe.AsPointer(ref this), i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetIcon(int i, uint flags, HICON* picon)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, HICON*, int>)(lpVtbl[10]))((IImageList2*)Unsafe.AsPointer(ref this), i, flags, picon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetImageInfo(int i, IMAGEINFO* pImageInfo)
        {
            return ((delegate* unmanaged<IImageList2*, int, IMAGEINFO*, int>)(lpVtbl[11]))((IImageList2*)Unsafe.AsPointer(ref this), i, pImageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Copy(int iDst, IUnknown* punkSrc, int iSrc, uint uFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, IUnknown*, int, uint, int>)(lpVtbl[12]))((IImageList2*)Unsafe.AsPointer(ref this), iDst, punkSrc, iSrc, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, int, IUnknown*, int, int, int, Guid*, void**, int>)(lpVtbl[13]))((IImageList2*)Unsafe.AsPointer(ref this), i1, punk2, i2, dx, dy, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[14]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetImageRect(int i, RECT* prc)
        {
            return ((delegate* unmanaged<IImageList2*, int, RECT*, int>)(lpVtbl[15]))((IImageList2*)Unsafe.AsPointer(ref this), i, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetIconSize(int* cx, int* cy)
        {
            return ((delegate* unmanaged<IImageList2*, int*, int*, int>)(lpVtbl[16]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetIconSize(int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[17]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetImageCount(int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, int*, int>)(lpVtbl[18]))((IImageList2*)Unsafe.AsPointer(ref this), pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetImageCount(uint uNewCount)
        {
            return ((delegate* unmanaged<IImageList2*, uint, int>)(lpVtbl[19]))((IImageList2*)Unsafe.AsPointer(ref this), uNewCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetBkColor(COLORREF clrBk, COLORREF* pclr)
        {
            return ((delegate* unmanaged<IImageList2*, COLORREF, COLORREF*, int>)(lpVtbl[20]))((IImageList2*)Unsafe.AsPointer(ref this), clrBk, pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetBkColor(COLORREF* pclr)
        {
            return ((delegate* unmanaged<IImageList2*, COLORREF*, int>)(lpVtbl[21]))((IImageList2*)Unsafe.AsPointer(ref this), pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT BeginDrag(int iTrack, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int, int>)(lpVtbl[22]))((IImageList2*)Unsafe.AsPointer(ref this), iTrack, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT EndDrag()
        {
            return ((delegate* unmanaged<IImageList2*, int>)(lpVtbl[23]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT DragEnter(HWND hwndLock, int x, int y)
        {
            return ((delegate* unmanaged<IImageList2*, HWND, int, int, int>)(lpVtbl[24]))((IImageList2*)Unsafe.AsPointer(ref this), hwndLock, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT DragLeave(HWND hwndLock)
        {
            return ((delegate* unmanaged<IImageList2*, HWND, int>)(lpVtbl[25]))((IImageList2*)Unsafe.AsPointer(ref this), hwndLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT DragMove(int x, int y)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[26]))((IImageList2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList2*, IUnknown*, int, int, int, int>)(lpVtbl[27]))((IImageList2*)Unsafe.AsPointer(ref this), punk, iDrag, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT DragShowNolock(BOOL fShow)
        {
            return ((delegate* unmanaged<IImageList2*, BOOL, int>)(lpVtbl[28]))((IImageList2*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, POINT*, POINT*, Guid*, void**, int>)(lpVtbl[29]))((IImageList2*)Unsafe.AsPointer(ref this), ppt, pptHotspot, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint*, int>)(lpVtbl[30]))((IImageList2*)Unsafe.AsPointer(ref this), i, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetOverlayImage(int iOverlay, int* piIndex)
        {
            return ((delegate* unmanaged<IImageList2*, int, int*, int>)(lpVtbl[31]))((IImageList2*)Unsafe.AsPointer(ref this), iOverlay, piIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Resize(int cxNewIconSize, int cyNewIconSize)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[32]))((IImageList2*)Unsafe.AsPointer(ref this), cxNewIconSize, cyNewIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetOriginalSize(int iImage, [NativeTypeName("DWORD")] uint dwFlags, int* pcx, int* pcy)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, int*, int*, int>)(lpVtbl[33]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, dwFlags, pcx, pcy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetOriginalSize(int iImage, int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int, int>)(lpVtbl[34]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SetCallback(IUnknown* punk)
        {
            return ((delegate* unmanaged<IImageList2*, IUnknown*, int>)(lpVtbl[35]))((IImageList2*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetCallback([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[36]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT ForceImagePresent(int iImage, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, int>)(lpVtbl[37]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT DiscardImages(int iFirstImage, int iLastImage, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, uint, int>)(lpVtbl[38]))((IImageList2*)Unsafe.AsPointer(ref this), iFirstImage, iLastImage, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT PreloadImages(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[39]))((IImageList2*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetStatistics(IMAGELISTSTATS* pils)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTSTATS*, int>)(lpVtbl[40]))((IImageList2*)Unsafe.AsPointer(ref this), pils);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT Initialize(int cx, int cy, uint flags, int cInitial, int cGrow)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, uint, int, int, int>)(lpVtbl[41]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy, flags, cInitial, cGrow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT Replace2(int i, HBITMAP hbmImage, HBITMAP hbmMask, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, HBITMAP, HBITMAP, IUnknown*, uint, int>)(lpVtbl[42]))((IImageList2*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask, punk, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT ReplaceFromImageList(int i, IImageList* pil, int iSrc, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, IImageList*, int, IUnknown*, uint, int>)(lpVtbl[43]))((IImageList2*)Unsafe.AsPointer(ref this), i, pil, iSrc, punk, dwFlags);
        }

        public interface Interface : IImageList.Interface
        {
            [VtblIndex(32)]
            HRESULT Resize(int cxNewIconSize, int cyNewIconSize);

            [VtblIndex(33)]
            HRESULT GetOriginalSize(int iImage, [NativeTypeName("DWORD")] uint dwFlags, int* pcx, int* pcy);

            [VtblIndex(34)]
            HRESULT SetOriginalSize(int iImage, int cx, int cy);

            [VtblIndex(35)]
            HRESULT SetCallback(IUnknown* punk);

            [VtblIndex(36)]
            HRESULT GetCallback([NativeTypeName("const IID &")] Guid* riid, void** ppv);

            [VtblIndex(37)]
            HRESULT ForceImagePresent(int iImage, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(38)]
            HRESULT DiscardImages(int iFirstImage, int iLastImage, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(39)]
            HRESULT PreloadImages(IMAGELISTDRAWPARAMS* pimldp);

            [VtblIndex(40)]
            HRESULT GetStatistics(IMAGELISTSTATS* pils);

            [VtblIndex(41)]
            HRESULT Initialize(int cx, int cy, uint flags, int cInitial, int cGrow);

            [VtblIndex(42)]
            HRESULT Replace2(int i, HBITMAP hbmImage, HBITMAP hbmMask, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(43)]
            HRESULT ReplaceFromImageList(int i, IImageList* pil, int iSrc, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, uint> Release;

            [NativeTypeName("HRESULT (HBITMAP, HBITMAP, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, HBITMAP, HBITMAP, int*, int> Add;

            [NativeTypeName("HRESULT (int, HICON, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, HICON, int*, int> ReplaceIcon;

            [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int> SetOverlayImage;

            [NativeTypeName("HRESULT (int, HBITMAP, HBITMAP) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, HBITMAP, HBITMAP, int> Replace;

            [NativeTypeName("HRESULT (HBITMAP, COLORREF, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, HBITMAP, COLORREF, int*, int> AddMasked;

            [NativeTypeName("HRESULT (IMAGELISTDRAWPARAMS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int> Draw;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int> Remove;

            [NativeTypeName("HRESULT (int, UINT, HICON *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, uint, HICON*, int> GetIcon;

            [NativeTypeName("HRESULT (int, IMAGEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, IMAGEINFO*, int> GetImageInfo;

            [NativeTypeName("HRESULT (int, IUnknown *, int, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, IUnknown*, int, uint, int> Copy;

            [NativeTypeName("HRESULT (int, IUnknown *, int, int, int, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, IUnknown*, int, int, int, Guid*, void**, int> Merge;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, Guid*, void**, int> Clone;

            [NativeTypeName("HRESULT (int, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, RECT*, int> GetImageRect;

            [NativeTypeName("HRESULT (int *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int*, int*, int> GetIconSize;

            [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int> SetIconSize;

            [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int*, int> GetImageCount;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, uint, int> SetImageCount;

            [NativeTypeName("HRESULT (COLORREF, COLORREF *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, COLORREF, COLORREF*, int> SetBkColor;

            [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, COLORREF*, int> GetBkColor;

            [NativeTypeName("HRESULT (int, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int, int> BeginDrag;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int> EndDrag;

            [NativeTypeName("HRESULT (HWND, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, HWND, int, int, int> DragEnter;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, HWND, int> DragLeave;

            [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int> DragMove;

            [NativeTypeName("HRESULT (IUnknown *, int, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, IUnknown*, int, int, int, int> SetDragCursorImage;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, BOOL, int> DragShowNolock;

            [NativeTypeName("HRESULT (POINT *, POINT *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, POINT*, POINT*, Guid*, void**, int> GetDragImage;

            [NativeTypeName("HRESULT (int, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, uint*, int> GetItemFlags;

            [NativeTypeName("HRESULT (int, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int*, int> GetOverlayImage;

            [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int> Resize;

            [NativeTypeName("HRESULT (int, DWORD, int *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, uint, int*, int*, int> GetOriginalSize;

            [NativeTypeName("HRESULT (int, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, int, int> SetOriginalSize;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, IUnknown*, int> SetCallback;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, Guid*, void**, int> GetCallback;

            [NativeTypeName("HRESULT (int, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, uint, int> ForceImagePresent;

            [NativeTypeName("HRESULT (int, int, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, uint, int> DiscardImages;

            [NativeTypeName("HRESULT (IMAGELISTDRAWPARAMS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int> PreloadImages;

            [NativeTypeName("HRESULT (IMAGELISTSTATS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, IMAGELISTSTATS*, int> GetStatistics;

            [NativeTypeName("HRESULT (int, int, UINT, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, int, uint, int, int, int> Initialize;

            [NativeTypeName("HRESULT (int, HBITMAP, HBITMAP, IUnknown *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, HBITMAP, HBITMAP, IUnknown*, uint, int> Replace2;

            [NativeTypeName("HRESULT (int, IImageList *, int, IUnknown *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IImageList2*, int, IImageList*, int, IUnknown*, uint, int> ReplaceFromImageList;
        }
    }
}