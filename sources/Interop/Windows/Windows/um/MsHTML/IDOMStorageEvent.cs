// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("30510722-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMStorageEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMStorageEvent : IDOMStorageEvent.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, uint>)(lpVtbl[1]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, uint>)(lpVtbl[2]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, uint*, int>)(lpVtbl[3]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_key([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, ushort**, int>)(lpVtbl[7]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_oldValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, ushort**, int>)(lpVtbl[8]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, ushort**, int>)(lpVtbl[9]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_url([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, ushort**, int>)(lpVtbl[10]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_storageArea(IHTMLStorage** p)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, IHTMLStorage**, int>)(lpVtbl[11]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT initStorageEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, [NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("BSTR")] ushort* oldValueArg, [NativeTypeName("BSTR")] ushort* newValueArg, [NativeTypeName("BSTR")] ushort* urlArg, IHTMLStorage* storageAreaArg)
        {
            return ((delegate* unmanaged<IDOMStorageEvent*, ushort*, short, short, ushort*, ushort*, ushort*, ushort*, IHTMLStorage*, int>)(lpVtbl[12]))((IDOMStorageEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, keyArg, oldValueArg, newValueArg, urlArg, storageAreaArg);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_key([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(8)]
            HRESULT get_oldValue([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(9)]
            HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(10)]
            HRESULT get_url([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(11)]
            HRESULT get_storageArea(IHTMLStorage** p);

            [VtblIndex(12)]
            HRESULT initStorageEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, [NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("BSTR")] ushort* oldValueArg, [NativeTypeName("BSTR")] ushort* newValueArg, [NativeTypeName("BSTR")] ushort* urlArg, IHTMLStorage* storageAreaArg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, ushort**, int> get_key;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, ushort**, int> get_oldValue;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, ushort**, int> get_newValue;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, ushort**, int> get_url;

            [NativeTypeName("HRESULT (IHTMLStorage **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, IHTMLStorage**, int> get_storageArea;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, BSTR, BSTR, BSTR, BSTR, IHTMLStorage *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDOMStorageEvent*, ushort*, short, short, ushort*, ushort*, ushort*, ushort*, IHTMLStorage*, int> initStorageEvent;
        }
    }
}