// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F1F7-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLFormElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLFormElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLFormElement*, uint>)(lpVtbl[1]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLFormElement*, uint>)(lpVtbl[2]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, uint*, int>)(lpVtbl[3]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_action([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[7]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_action([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[8]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_dir([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[9]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_dir([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[10]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_encoding([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[11]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_encoding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[12]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_method([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[13]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_method([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[14]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_elements(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, IDispatch**, int>)(lpVtbl[15]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_target([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[16]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_target([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[17]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort*, int>)(lpVtbl[18]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, ushort**, int>)(lpVtbl[19]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsubmit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, int>)(lpVtbl[20]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsubmit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT*, int>)(lpVtbl[21]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, int>)(lpVtbl[22]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT*, int>)(lpVtbl[23]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int submit()
        {
            return ((delegate* unmanaged<IHTMLFormElement*, int>)(lpVtbl[24]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return ((delegate* unmanaged<IHTMLFormElement*, int>)(lpVtbl[25]))((IHTMLFormElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_length([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, int, int>)(lpVtbl[26]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, int*, int>)(lpVtbl[27]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** p)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, IUnknown**, int>)(lpVtbl[28]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int item(VARIANT name, VARIANT index, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[29]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), name, index, pdisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int tags(VARIANT tagName, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLFormElement*, VARIANT, IDispatch**, int>)(lpVtbl[30]))((IHTMLFormElement*)Unsafe.AsPointer(ref this), tagName, pdisp);
        }
    }
}
