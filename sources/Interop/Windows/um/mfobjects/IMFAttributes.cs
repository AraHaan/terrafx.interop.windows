// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
    [NativeTypeName("struct IMFAttributes : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFAttributes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, void**, int>)(lpVtbl[0]))((IMFAttributes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAttributes*, uint>)(lpVtbl[1]))((IMFAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAttributes*, uint>)(lpVtbl[2]))((IMFAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFAttributes*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFAttributes*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[7]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, double*, int>)(lpVtbl[9]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[11]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[14]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, int>)(lpVtbl[19]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[20]))((IMFAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, uint, int>)(lpVtbl[21]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, ulong, int>)(lpVtbl[22]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, double, int>)(lpVtbl[23]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFAttributes*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[28]))((IMFAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[29]))((IMFAttributes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFAttributes*, uint*, int>)(lpVtbl[30]))((IMFAttributes*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFAttributes*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFAttributes*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFAttributes*, IMFAttributes*, int>)(lpVtbl[32]))((IMFAttributes*)Unsafe.AsPointer(ref this), pDest);
        }
    }
}
