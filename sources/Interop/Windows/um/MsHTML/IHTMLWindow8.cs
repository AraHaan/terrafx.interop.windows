// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107AB-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLWindow8 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLWindow8
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLWindow8*, uint>)(lpVtbl[1]))((IHTMLWindow8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLWindow8*, uint>)(lpVtbl[2]))((IHTMLWindow8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, uint*, int>)(lpVtbl[3]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_onmspointerdown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[7]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_onmspointerdown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[8]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_onmspointermove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[9]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_onmspointermove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[10]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_onmspointerup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[11]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_onmspointerup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[12]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_onmspointerover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[13]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_onmspointerover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[14]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_onmspointerout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[15]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_onmspointerout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[16]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_onmspointercancel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[17]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_onmspointercancel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[18]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_onmspointerhover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[19]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_onmspointerhover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[20]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_onmsgesturestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[21]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_onmsgesturestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[22]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_onmsgesturechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[23]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_onmsgesturechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[24]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_onmsgestureend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[25]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_onmsgestureend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[26]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_onmsgesturehold(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[27]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_onmsgesturehold(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[28]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_onmsgesturetap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[29]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_onmsgesturetap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[30]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_onmsgesturedoubletap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[31]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_onmsgesturedoubletap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[32]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_onmsinertiastart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[33]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_onmsinertiastart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[34]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_applicationCache(IHTMLApplicationCache** p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, IHTMLApplicationCache**, int>)(lpVtbl[35]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_onpopstate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int>)(lpVtbl[36]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_onpopstate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int>)(lpVtbl[37]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
        }
    }
}
