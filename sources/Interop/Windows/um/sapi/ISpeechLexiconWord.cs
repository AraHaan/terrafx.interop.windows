// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E5B933C-C9BE-48ED-8842-1EE51BB1D4FF")]
    [NativeTypeName("struct ISpeechLexiconWord : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechLexiconWord
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, uint>)(lpVtbl[1]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, uint>)(lpVtbl[2]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, uint*, int>)(lpVtbl[3]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, int*, int>)(lpVtbl[7]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), LangId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Type(SpeechWordType* WordType)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, SpeechWordType*, int>)(lpVtbl[8]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), WordType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Word([NativeTypeName("BSTR *")] ushort** Word)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, ushort**, int>)(lpVtbl[9]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Word);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_Pronunciations(ISpeechLexiconPronunciations** Pronunciations)
        {
            return ((delegate* unmanaged<ISpeechLexiconWord*, ISpeechLexiconPronunciations**, int>)(lpVtbl[10]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Pronunciations);
        }
    }
}
