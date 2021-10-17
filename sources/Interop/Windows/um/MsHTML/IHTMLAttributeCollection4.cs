// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106FA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLAttributeCollection4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLAttributeCollection4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint>)(lpVtbl[1]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint>)(lpVtbl[2]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint*, int>)(lpVtbl[3]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[7]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pvarNS, bstrName, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setNamedItemNS(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[8]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pNodeIn, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[9]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pvarNS, bstrName, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[10]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int setNamedItem(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[11]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pNodeIn, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[12]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int item([NativeTypeName("long")] int index, IHTMLDOMAttribute2** ppNodeOut)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, int, IHTMLDOMAttribute2**, int>)(lpVtbl[13]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), index, ppNodeOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection4*, int*, int>)(lpVtbl[14]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), p);
        }
    }
}
