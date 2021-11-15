// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B238B6D5-F276-4C3D-A6C1-2974801C3CC2")]
    [NativeTypeName("struct ISpeechPhraseAlternates : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechPhraseAlternates : ISpeechPhraseAlternates.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, uint>)(lpVtbl[1]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, uint>)(lpVtbl[2]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, int*, int>)(lpVtbl[7]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Item([NativeTypeName("long")] int Index, ISpeechPhraseAlternate** PhraseAlternate)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, int, ISpeechPhraseAlternate**, int>)(lpVtbl[8]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), Index, PhraseAlternate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get__NewEnum(IUnknown** EnumVARIANT)
        {
            return ((delegate* unmanaged<ISpeechPhraseAlternates*, IUnknown**, int>)(lpVtbl[9]))((ISpeechPhraseAlternates*)Unsafe.AsPointer(ref this), EnumVARIANT);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_Count([NativeTypeName("long *")] int* Count);

            [VtblIndex(8)]
            HRESULT Item([NativeTypeName("long")] int Index, ISpeechPhraseAlternate** PhraseAlternate);

            [VtblIndex(9)]
            HRESULT get__NewEnum(IUnknown** EnumVARIANT);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, int*, int> get_Count;

            [NativeTypeName("HRESULT (long, ISpeechPhraseAlternate **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, int, ISpeechPhraseAlternate**, int> Item;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechPhraseAlternates*, IUnknown**, int> get__NewEnum;
        }
    }
}