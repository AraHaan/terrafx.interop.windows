// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("C2B5F241-DAA0-4507-9E16-5A1EAA2B7A5C")]
    [NativeTypeName("struct ISpRecognizer : ISpProperties")]
    [NativeInheritance("ISpProperties")]
    public unsafe partial struct ISpRecognizer : ISpRecognizer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecognizer*, uint>)(lpVtbl[1]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecognizer*, uint>)(lpVtbl[2]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int lValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, int, int>)(lpVtbl[3]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, lValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG *")] int* plValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, int*, int>)(lpVtbl[4]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, plValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPCWSTR")] ushort* pValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, ppCoMemValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetRecognizer(ISpObjectToken* pRecognizer)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[7]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pRecognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetRecognizer(ISpObjectToken** ppRecognizer)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[8]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppRecognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetInput(IUnknown* pUnkInput, BOOL fAllowFormatChanges)
        {
            return ((delegate* unmanaged<ISpRecognizer*, IUnknown*, BOOL, int>)(lpVtbl[9]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pUnkInput, fAllowFormatChanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetInputObjectToken(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[10]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetInputStream(ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpStreamFormat**, int>)(lpVtbl[11]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateRecoContext(ISpRecoContext** ppNewCtxt)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpRecoContext**, int>)(lpVtbl[12]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppNewCtxt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetRecoProfile(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[13]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetRecoProfile(ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[14]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsSharedInstance()
        {
            return ((delegate* unmanaged<ISpRecognizer*, int>)(lpVtbl[15]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetRecoState(SPRECOSTATE* pState)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOSTATE*, int>)(lpVtbl[16]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetRecoState(SPRECOSTATE NewState)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOSTATE, int>)(lpVtbl[17]))((ISpRecognizer*)Unsafe.AsPointer(ref this), NewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetStatus(SPRECOGNIZERSTATUS* pStatus)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOGNIZERSTATUS*, int>)(lpVtbl[18]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, Guid* pFormatId, WAVEFORMATEX** ppCoMemWFEX)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPSTREAMFORMATTYPE, Guid*, WAVEFORMATEX**, int>)(lpVtbl[19]))((ISpRecognizer*)Unsafe.AsPointer(ref this), WaveFormatType, pFormatId, ppCoMemWFEX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, void*, uint, BOOL*, int>)(lpVtbl[20]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
        {
            return ((delegate* unmanaged<ISpRecognizer*, HWND, ushort*, ushort*, void*, uint, int>)(lpVtbl[21]))((ISpRecognizer*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT EmulateRecognition(ISpPhrase* pPhrase)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpPhrase*, int>)(lpVtbl[22]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pPhrase);
        }

        public interface Interface : ISpProperties.Interface
        {
            [VtblIndex(7)]
            HRESULT SetRecognizer(ISpObjectToken* pRecognizer);

            [VtblIndex(8)]
            HRESULT GetRecognizer(ISpObjectToken** ppRecognizer);

            [VtblIndex(9)]
            HRESULT SetInput(IUnknown* pUnkInput, BOOL fAllowFormatChanges);

            [VtblIndex(10)]
            HRESULT GetInputObjectToken(ISpObjectToken** ppToken);

            [VtblIndex(11)]
            HRESULT GetInputStream(ISpStreamFormat** ppStream);

            [VtblIndex(12)]
            HRESULT CreateRecoContext(ISpRecoContext** ppNewCtxt);

            [VtblIndex(13)]
            HRESULT GetRecoProfile(ISpObjectToken** ppToken);

            [VtblIndex(14)]
            HRESULT SetRecoProfile(ISpObjectToken* pToken);

            [VtblIndex(15)]
            HRESULT IsSharedInstance();

            [VtblIndex(16)]
            HRESULT GetRecoState(SPRECOSTATE* pState);

            [VtblIndex(17)]
            HRESULT SetRecoState(SPRECOSTATE NewState);

            [VtblIndex(18)]
            HRESULT GetStatus(SPRECOGNIZERSTATUS* pStatus);

            [VtblIndex(19)]
            HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, Guid* pFormatId, WAVEFORMATEX** ppCoMemWFEX);

            [VtblIndex(20)]
            HRESULT IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported);

            [VtblIndex(21)]
            HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData);

            [VtblIndex(22)]
            HRESULT EmulateRecognition(ISpPhrase* pPhrase);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ushort*, int, int> SetPropertyNum;

            [NativeTypeName("HRESULT (LPCWSTR, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ushort*, int*, int> GetPropertyNum;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ushort*, ushort*, int> SetPropertyString;

            [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ushort*, ushort**, int> GetPropertyString;

            [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int> SetRecognizer;

            [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int> GetRecognizer;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, IUnknown*, BOOL, int> SetInput;

            [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int> GetInputObjectToken;

            [NativeTypeName("HRESULT (ISpStreamFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpStreamFormat**, int> GetInputStream;

            [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpRecoContext**, int> CreateRecoContext;

            [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int> GetRecoProfile;

            [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int> SetRecoProfile;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, int> IsSharedInstance;

            [NativeTypeName("HRESULT (SPRECOSTATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, SPRECOSTATE*, int> GetRecoState;

            [NativeTypeName("HRESULT (SPRECOSTATE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, SPRECOSTATE, int> SetRecoState;

            [NativeTypeName("HRESULT (SPRECOGNIZERSTATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, SPRECOGNIZERSTATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (SPSTREAMFORMATTYPE, GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, SPSTREAMFORMATTYPE, Guid*, WAVEFORMATEX**, int> GetFormat;

            [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ushort*, void*, uint, BOOL*, int> IsUISupported;

            [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, HWND, ushort*, ushort*, void*, uint, int> DisplayUI;

            [NativeTypeName("HRESULT (ISpPhrase *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecognizer*, ISpPhrase*, int> EmulateRecognition;
        }
    }
}