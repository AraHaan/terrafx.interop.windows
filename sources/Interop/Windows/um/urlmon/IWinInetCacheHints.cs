// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD1EC3B3-8391-4FDB-A9E6-347C3CAAA7DD")]
    public unsafe partial struct IWinInetCacheHints
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWinInetCacheHints* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWinInetCacheHints* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWinInetCacheHints* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCacheExtension(IWinInetCacheHints* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWinInetCacheHints*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCacheExtension>(lpVtbl->SetCacheExtension)((IWinInetCacheHints*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public IntPtr SetCacheExtension;
        }
    }
}