// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("C3E4F353-433F-43D6-89A1-6A62A7054C3D")]
    [NativeTypeName("struct ISpeechPhoneConverter : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechPhoneConverter : ISpeechPhoneConverter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint>)(lpVtbl[1]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint>)(lpVtbl[2]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint*, int>)(lpVtbl[3]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_LanguageId([NativeTypeName("SpeechLanguageId *")] int* LanguageId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int*, int>)(lpVtbl[7]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_LanguageId([NativeTypeName("SpeechLanguageId")] int LanguageId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int, int>)(lpVtbl[8]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PhoneToId([NativeTypeName("const BSTR")] ushort* Phonemes, VARIANT* IdArray)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, ushort*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), Phonemes, IdArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IdToPhone([NativeTypeName("const VARIANT")] VARIANT IdArray, [NativeTypeName("BSTR *")] ushort** Phonemes)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, VARIANT, ushort**, int>)(lpVtbl[10]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), IdArray, Phonemes);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_LanguageId([NativeTypeName("SpeechLanguageId *")] int* LanguageId);

            [VtblIndex(8)]
            HRESULT put_LanguageId([NativeTypeName("SpeechLanguageId")] int LanguageId);

            [VtblIndex(9)]
            HRESULT PhoneToId([NativeTypeName("const BSTR")] ushort* Phonemes, VARIANT* IdArray);

            [VtblIndex(10)]
            HRESULT IdToPhone([NativeTypeName("const VARIANT")] VARIANT IdArray, [NativeTypeName("BSTR *")] ushort** Phonemes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (SpeechLanguageId *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, int*, int> get_LanguageId;

            [NativeTypeName("HRESULT (SpeechLanguageId) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, int, int> put_LanguageId;

            [NativeTypeName("HRESULT (const BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, ushort*, VARIANT*, int> PhoneToId;

            [NativeTypeName("HRESULT (const VARIANT, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhoneConverter*, VARIANT, ushort**, int> IdToPhone;
        }
    }
}