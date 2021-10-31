// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6403497-7493-4F09-8016-54B03E9BDA69")]
    [NativeTypeName("struct IPrintManagerTemplatePrinter2 : IPrintManagerTemplatePrinter")]
    [NativeInheritance("IPrintManagerTemplatePrinter")]
    public unsafe partial struct IPrintManagerTemplatePrinter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, uint>)(lpVtbl[1]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, uint>)(lpVtbl[2]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, uint*, int>)(lpVtbl[3]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int startPrint()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, int>)(lpVtbl[7]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int drawPreviewPage(IDispatch* pElemDisp, [NativeTypeName("long")] int nPage)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, IDispatch*, int, int>)(lpVtbl[8]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), pElemDisp, nPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int setPageCount([NativeTypeName("long")] int nPage)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, int, int>)(lpVtbl[9]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), nPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int invalidatePreview()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, int>)(lpVtbl[10]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int getPrintTaskOptionValue([NativeTypeName("BSTR")] ushort* bstrKey, VARIANT* pvarin)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), bstrKey, pvarin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int endPrint()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, int>)(lpVtbl[12]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_showHeaderFooter([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, short*, int>)(lpVtbl[13]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_shrinkToFit([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, short*, int>)(lpVtbl[14]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_percentScale(float* p)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter2*, float*, int>)(lpVtbl[15]))((IPrintManagerTemplatePrinter2*)Unsafe.AsPointer(ref this), p);
        }
    }
}