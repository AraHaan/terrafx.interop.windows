// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6B8-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLNamespaceCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLNamespaceCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, uint>)(lpVtbl[1]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, uint>)(lpVtbl[2]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, uint*, int>)(lpVtbl[3]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, int*, int>)(lpVtbl[7]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT item(VARIANT index, IDispatch** ppNamespace)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, VARIANT, IDispatch**, int>)(lpVtbl[8]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), index, ppNamespace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT add([NativeTypeName("BSTR")] ushort* bstrNamespace, [NativeTypeName("BSTR")] ushort* bstrUrn, VARIANT implementationUrl, IDispatch** ppNamespace)
        {
            return ((delegate* unmanaged<IHTMLNamespaceCollection*, ushort*, ushort*, VARIANT, IDispatch**, int>)(lpVtbl[9]))((IHTMLNamespaceCollection*)Unsafe.AsPointer(ref this), bstrNamespace, bstrUrn, implementationUrl, ppNamespace);
        }
    }
}
