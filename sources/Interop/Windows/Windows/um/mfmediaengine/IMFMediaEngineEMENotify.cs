// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9E184D15-CDB7-4F86-B49E-566689F4A601")]
    [NativeTypeName("struct IMFMediaEngineEMENotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineEMENotify : IMFMediaEngineEMENotify.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineEMENotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineEMENotify*, uint>)(lpVtbl[1]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineEMENotify*, uint>)(lpVtbl[2]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Encrypted([NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("BSTR")] ushort* bstrInitDataType)
        {
            ((delegate* unmanaged<IMFMediaEngineEMENotify*, byte*, uint, ushort*, void>)(lpVtbl[3]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), pbInitData, cb, bstrInitDataType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void WaitingForKey()
        {
            ((delegate* unmanaged<IMFMediaEngineEMENotify*, void>)(lpVtbl[4]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            void Encrypted([NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("BSTR")] ushort* bstrInitDataType);

            [VtblIndex(4)]
            void WaitingForKey();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEMENotify*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEMENotify*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEMENotify*, uint> Release;

            [NativeTypeName("void (const BYTE *, DWORD, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEMENotify*, byte*, uint, ushort*, void> Encrypted;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEMENotify*, void> WaitingForKey;
        }
    }
}