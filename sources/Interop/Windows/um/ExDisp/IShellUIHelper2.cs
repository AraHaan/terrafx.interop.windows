// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7FE6EDA-1932-4281-B881-87B31B8BC52C")]
    [NativeTypeName("struct IShellUIHelper2 : IShellUIHelper")]
    [NativeInheritance("IShellUIHelper")]
    public unsafe partial struct IShellUIHelper2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, Guid*, void**, int>)(lpVtbl[0]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, uint>)(lpVtbl[1]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, uint>)(lpVtbl[2]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, uint*, int>)(lpVtbl[3]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResetFirstBootMode()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[7]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ResetSafeMode()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[8]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RefreshOfflineDesktop()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[9]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL, Title);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, int>)(lpVtbl[11]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddDesktopComponent([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Type, VARIANT* Left, VARIANT* Top, VARIANT* Width, VARIANT* Height)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL, Type, Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT IsSubscribed([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, short*, int>)(lpVtbl[13]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL, pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT NavigateAndFind([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* strQuery, VARIANT* varTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[14]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL, strQuery, varTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ImportExportFavorites([NativeTypeName("VARIANT_BOOL")] short fImport, [NativeTypeName("BSTR")] ushort* strImpExpPath)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short, ushort*, int>)(lpVtbl[15]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), fImport, strImpExpPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT AutoCompleteSaveForm(VARIANT* Form)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, VARIANT*, int>)(lpVtbl[16]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), Form);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT AutoScan([NativeTypeName("BSTR")] ushort* strSearch, [NativeTypeName("BSTR")] ushort* strFailureUrl, VARIANT* pvarTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[17]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), strSearch, strFailureUrl, pvarTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT AutoCompleteAttach(VARIANT* Reserved)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, VARIANT*, int>)(lpVtbl[18]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), Reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT ShowBrowserUI([NativeTypeName("BSTR")] ushort* bstrName, VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, VARIANT*, VARIANT*, int>)(lpVtbl[19]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), bstrName, pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, int>)(lpVtbl[20]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT RunOnceShown()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[21]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SkipRunOnce()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[22]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CustomizeSettings([NativeTypeName("VARIANT_BOOL")] short fSQM, [NativeTypeName("VARIANT_BOOL")] short fPhishing, [NativeTypeName("BSTR")] ushort* bstrLocale)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short, short, ushort*, int>)(lpVtbl[23]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), fSQM, fPhishing, bstrLocale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short*, int>)(lpVtbl[24]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short*, int>)(lpVtbl[25]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort**, int>)(lpVtbl[26]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pbstrUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SkipTabsWelcome()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[27]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT DiagnoseConnection()
        {
            return ((delegate* unmanaged<IShellUIHelper2*, int>)(lpVtbl[28]))((IShellUIHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short, int>)(lpVtbl[29]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), fSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsSearchProviderInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort*, uint*, int>)(lpVtbl[30]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), URL, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short*, int>)(lpVtbl[31]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pfMigrated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort**, int>)(lpVtbl[32]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short, int>)(lpVtbl[33]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), fComplete);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, short*, int>)(lpVtbl[34]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
        {
            return ((delegate* unmanaged<IShellUIHelper2*, ushort**, int>)(lpVtbl[35]))((IShellUIHelper2*)Unsafe.AsPointer(ref this), pbstrUrl);
        }
    }
}
