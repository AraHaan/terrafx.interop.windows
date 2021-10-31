// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("913C24A0-20AB-11D2-9038-00A0C9697298")]
    [NativeTypeName("struct IDDrawExclModeVideoCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDDrawExclModeVideoCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[1]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[2]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnUpdateOverlay(BOOL bBefore, [NativeTypeName("DWORD")] uint dwFlags, BOOL bOldVisible, [NativeTypeName("const RECT *")] RECT* prcOldSrc, [NativeTypeName("const RECT *")] RECT* prcOldDest, BOOL bNewVisible, [NativeTypeName("const RECT *")] RECT* prcNewSrc, [NativeTypeName("const RECT *")] RECT* prcNewDest)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, BOOL, uint, BOOL, RECT*, RECT*, BOOL, RECT*, RECT*, int>)(lpVtbl[3]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), bBefore, dwFlags, bOldVisible, prcOldSrc, prcOldDest, bNewVisible, prcNewSrc, prcNewDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnUpdateColorKey([NativeTypeName("const COLORKEY *")] COLORKEY* pKey, [NativeTypeName("DWORD")] uint dwColor)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, COLORKEY*, uint, int>)(lpVtbl[4]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), pKey, dwColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnUpdateSize([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwARWidth, [NativeTypeName("DWORD")] uint dwARHeight)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideoCallback*, uint, uint, uint, uint, int>)(lpVtbl[5]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), dwWidth, dwHeight, dwARWidth, dwARHeight);
        }
    }
}
