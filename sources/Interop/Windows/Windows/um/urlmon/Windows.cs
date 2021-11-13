// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.BINDF;
using static TerraFX.Interop.Windows.PARSEACTION;
using static TerraFX.Interop.Windows.PI_FLAGS;
using static TerraFX.Interop.Windows.Uri_PROPERTY;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetClassURL([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEFetc, IBindCtx** ppBC);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateAsyncBindCtxEx(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEnum, IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT MkParseDisplayNameEx(IBindCtx* pbc, [NativeTypeName("LPCWSTR")] ushort* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb, IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] ushort* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FaultInIEFeature(HWND hWnd, uCLSSPEC* pClassSpec, QUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetComponentIDFromCLSSPEC(uCLSSPEC* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT IsAsyncMoniker(IMoniker* pmk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterMediaTypes(uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateFormatEnumerator(uint cfmtetc, FORMATETC* rgfmtetc, IEnumFORMATETC** ppenumfmtetc);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] ushort* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CompareSecurityIds(byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT SetAccessForIEAppContainer(HANDLE hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUri([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUriWithFragment([NativeTypeName("LPCWSTR")] ushort* pwzURI, [NativeTypeName("LPCWSTR")] ushort* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppURI);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppUri);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CreateIUriBuilder(IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUriBuilder** ppIUriBuilder);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] ushort* szTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkSimpleNavigateToMoniker(IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] ushort* szLocation, [NativeTypeName("LPCWSTR")] ushort* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPCWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPWSTR")] ushort* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkGoBack(IUnknown* pUnk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkGoForward(IUnknown* pUnk);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkNavigateString(IUnknown* pUnk, [NativeTypeName("LPCWSTR")] ushort* szTarget);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT HlinkNavigateMoniker(IUnknown* pUnk, IMoniker* pmkTarget);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetParseUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetParseIUri(IUri* pIUri, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineUrl([NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] ushort* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineUrlEx(IUri* pBaseUri, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCombineIUri(IUri* pBaseUri, IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCompareUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl1, [NativeTypeName("LPCWSTR")] ushort* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] ushort* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetQueryInfo([NativeTypeName("LPCWSTR")] ushort* pwzUrl, QUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPWSTR *")] ushort** ppwszSecUrl, PSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPCWSTR")] ushort* szTYPE, [NativeTypeName("LPCWSTR")] ushort* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* szURL, IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetGetSecurityUrlEx(IUri* pUri, IUri** ppSecUri, PSUACTION psuAction, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, BOOL fEnable);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* szURL, IInternetSecurityManager* pSecMgr);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureEnabledForIUri(INTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, IUri* pIUri, IInternetSecurityManagerEx2* pSecMgr);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] ushort* szFromURL, [NativeTypeName("LPCWSTR")] ushort* szToURL, IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CopyStgMedium([NativeTypeName("const STGMEDIUM *")] STGMEDIUM* pcstgmedSrc, STGMEDIUM* pstgmedDest);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CopyBindInfo([NativeTypeName("const BINDINFO *")] BINDINFO* pcbiSrc, BINDINFO* pbiDest);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern void ReleaseBindInfo(BINDINFO* pbindinfo);

        [DllImport("urlmon", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* IEGetUserPrivateNamespaceName();

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCreateSecurityManager(IServiceProvider* pSP, IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT CoInternetCreateZoneManager(IServiceProvider* pSP, IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern HRESULT SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] ushort* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL IsLoggingEnabledW([NativeTypeName("LPCWSTR")] ushort* pwszUrl);

        [DllImport("urlmon", ExactSpelling = true)]
        public static extern BOOL WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] HIT_LOGGING_INFO* lpLogginginfo);

        [NativeTypeName("#define BINDF_DONTUSECACHE BINDF_GETNEWESTVERSION")]
        public const BINDF BINDF_DONTUSECACHE = BINDF_GETNEWESTVERSION;

        [NativeTypeName("#define BINDF_DONTPUTINCACHE BINDF_NOWRITECACHE")]
        public const BINDF BINDF_DONTPUTINCACHE = BINDF_NOWRITECACHE;

        [NativeTypeName("#define BINDF_NOCOPYDATA BINDF_PULLDATA")]
        public const BINDF BINDF_NOCOPYDATA = BINDF_PULLDATA;

        [NativeTypeName("#define INVALID_P_ROOT_SECURITY_ID ((BYTE*)-1)")]
        public static byte* INVALID_P_ROOT_SECURITY_ID => unchecked((byte*)(-1));

        [NativeTypeName("#define PI_DOCFILECLSIDLOOKUP PI_CLSIDLOOKUP")]
        public const PI_FLAGS PI_DOCFILECLSIDLOOKUP = PI_CLSIDLOOKUP;

        [NativeTypeName("#define SZ_URLCONTEXT OLESTR(\"URL Context\")")]
        public const string SZ_URLCONTEXT = "URL Context";

        [NativeTypeName("#define SZ_ASYNC_CALLEE OLESTR(\"AsyncCallee\")")]
        public const string SZ_ASYNC_CALLEE = "AsyncCallee";

        [NativeTypeName("#define MKSYS_URLMONIKER 6")]
        public const int MKSYS_URLMONIKER = 6;

        [NativeTypeName("#define URL_MK_LEGACY 0")]
        public const int URL_MK_LEGACY = 0;

        [NativeTypeName("#define URL_MK_UNIFORM 1")]
        public const int URL_MK_UNIFORM = 1;

        [NativeTypeName("#define URL_MK_NO_CANONICALIZE 2")]
        public const int URL_MK_NO_CANONICALIZE = 2;

        [NativeTypeName("#define FIEF_FLAG_FORCE_JITUI 0x1")]
        public const int FIEF_FLAG_FORCE_JITUI = 0x1;

        [NativeTypeName("#define FIEF_FLAG_PEEK 0x2")]
        public const int FIEF_FLAG_PEEK = 0x2;

        [NativeTypeName("#define FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK 0x4")]
        public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 0x4;

        [NativeTypeName("#define FIEF_FLAG_RESERVED_0 0x8")]
        public const int FIEF_FLAG_RESERVED_0 = 0x8;

        [NativeTypeName("#define FMFD_DEFAULT 0x00000000")]
        public const int FMFD_DEFAULT = 0x00000000;

        [NativeTypeName("#define FMFD_URLASFILENAME 0x00000001")]
        public const int FMFD_URLASFILENAME = 0x00000001;

        [NativeTypeName("#define FMFD_ENABLEMIMESNIFFING 0x00000002")]
        public const int FMFD_ENABLEMIMESNIFFING = 0x00000002;

        [NativeTypeName("#define FMFD_IGNOREMIMETEXTPLAIN 0x00000004")]
        public const int FMFD_IGNOREMIMETEXTPLAIN = 0x00000004;

        [NativeTypeName("#define FMFD_SERVERMIME 0x00000008")]
        public const int FMFD_SERVERMIME = 0x00000008;

        [NativeTypeName("#define FMFD_RESPECTTEXTPLAIN 0x00000010")]
        public const int FMFD_RESPECTTEXTPLAIN = 0x00000010;

        [NativeTypeName("#define FMFD_RETURNUPDATEDIMGMIMES 0x00000020")]
        public const int FMFD_RETURNUPDATEDIMGMIMES = 0x00000020;

        [NativeTypeName("#define FMFD_RESERVED_1 0x00000040")]
        public const int FMFD_RESERVED_1 = 0x00000040;

        [NativeTypeName("#define UAS_EXACTLEGACY 0x00001000")]
        public const int UAS_EXACTLEGACY = 0x00001000;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT 0x10000001")]
        public const int URLMON_OPTION_USERAGENT = 0x10000001;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT_REFRESH 0x10000002")]
        public const int URLMON_OPTION_USERAGENT_REFRESH = 0x10000002;

        [NativeTypeName("#define URLMON_OPTION_URL_ENCODING 0x10000004")]
        public const int URLMON_OPTION_URL_ENCODING = 0x10000004;

        [NativeTypeName("#define URLMON_OPTION_USE_BINDSTRINGCREDS 0x10000008")]
        public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 0x10000008;

        [NativeTypeName("#define URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS 0x10000010")]
        public const int URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS = 0x10000010;

        [NativeTypeName("#define CF_NULL 0")]
        public const int CF_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_NULL NULL")]
        public const int CFSTR_MIME_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_TEXT (TEXT(\"text/plain\"))")]
        public const string CFSTR_MIME_TEXT = ("text/plain");

        [NativeTypeName("#define CFSTR_MIME_RICHTEXT (TEXT(\"text/richtext\"))")]
        public const string CFSTR_MIME_RICHTEXT = ("text/richtext");

        [NativeTypeName("#define CFSTR_MIME_MANIFEST (TEXT(\"text/cache-manifest\"))")]
        public const string CFSTR_MIME_MANIFEST = ("text/cache-manifest");

        [NativeTypeName("#define CFSTR_MIME_WEBVTT (TEXT(\"text/vtt\"))")]
        public const string CFSTR_MIME_WEBVTT = ("text/vtt");

        [NativeTypeName("#define CFSTR_MIME_X_BITMAP (TEXT(\"image/x-xbitmap\"))")]
        public const string CFSTR_MIME_X_BITMAP = ("image/x-xbitmap");

        [NativeTypeName("#define CFSTR_MIME_POSTSCRIPT (TEXT(\"application/postscript\"))")]
        public const string CFSTR_MIME_POSTSCRIPT = ("application/postscript");

        [NativeTypeName("#define CFSTR_MIME_AIFF (TEXT(\"audio/aiff\"))")]
        public const string CFSTR_MIME_AIFF = ("audio/aiff");

        [NativeTypeName("#define CFSTR_MIME_BASICAUDIO (TEXT(\"audio/basic\"))")]
        public const string CFSTR_MIME_BASICAUDIO = ("audio/basic");

        [NativeTypeName("#define CFSTR_MIME_WAV (TEXT(\"audio/wav\"))")]
        public const string CFSTR_MIME_WAV = ("audio/wav");

        [NativeTypeName("#define CFSTR_MIME_X_WAV (TEXT(\"audio/x-wav\"))")]
        public const string CFSTR_MIME_X_WAV = ("audio/x-wav");

        [NativeTypeName("#define CFSTR_MIME_GIF (TEXT(\"image/gif\"))")]
        public const string CFSTR_MIME_GIF = ("image/gif");

        [NativeTypeName("#define CFSTR_MIME_PJPEG (TEXT(\"image/pjpeg\"))")]
        public const string CFSTR_MIME_PJPEG = ("image/pjpeg");

        [NativeTypeName("#define CFSTR_MIME_JPEG (TEXT(\"image/jpeg\"))")]
        public const string CFSTR_MIME_JPEG = ("image/jpeg");

        [NativeTypeName("#define CFSTR_MIME_TIFF (TEXT(\"image/tiff\"))")]
        public const string CFSTR_MIME_TIFF = ("image/tiff");

        [NativeTypeName("#define CFSTR_MIME_JPEG_XR (TEXT(\"image/vnd.ms-photo\"))")]
        public const string CFSTR_MIME_JPEG_XR = ("image/vnd.ms-photo");

        [NativeTypeName("#define CFSTR_MIME_PNG (TEXT(\"image/png\"))")]
        public const string CFSTR_MIME_PNG = ("image/png");

        [NativeTypeName("#define CFSTR_MIME_DDS (TEXT(\"image/vnd.ms-dds\"))")]
        public const string CFSTR_MIME_DDS = ("image/vnd.ms-dds");

        [NativeTypeName("#define CFSTR_MIME_X_PNG (TEXT(\"image/x-png\"))")]
        public const string CFSTR_MIME_X_PNG = ("image/x-png");

        [NativeTypeName("#define CFSTR_MIME_X_ICON (TEXT(\"image/x-icon\"))")]
        public const string CFSTR_MIME_X_ICON = ("image/x-icon");

        [NativeTypeName("#define CFSTR_MIME_SVG_XML (TEXT(\"image/svg+xml\"))")]
        public const string CFSTR_MIME_SVG_XML = ("image/svg+xml");

        [NativeTypeName("#define CFSTR_MIME_BMP (TEXT(\"image/bmp\"))")]
        public const string CFSTR_MIME_BMP = ("image/bmp");

        [NativeTypeName("#define CFSTR_MIME_X_EMF (TEXT(\"image/x-emf\"))")]
        public const string CFSTR_MIME_X_EMF = ("image/x-emf");

        [NativeTypeName("#define CFSTR_MIME_X_WMF (TEXT(\"image/x-wmf\"))")]
        public const string CFSTR_MIME_X_WMF = ("image/x-wmf");

        [NativeTypeName("#define CFSTR_MIME_AVI (TEXT(\"video/avi\"))")]
        public const string CFSTR_MIME_AVI = ("video/avi");

        [NativeTypeName("#define CFSTR_MIME_MPEG (TEXT(\"video/mpeg\"))")]
        public const string CFSTR_MIME_MPEG = ("video/mpeg");

        [NativeTypeName("#define CFSTR_MIME_FRACTALS (TEXT(\"application/fractals\"))")]
        public const string CFSTR_MIME_FRACTALS = ("application/fractals");

        [NativeTypeName("#define CFSTR_MIME_RAWDATA (TEXT(\"application/octet-stream\"))")]
        public const string CFSTR_MIME_RAWDATA = ("application/octet-stream");

        [NativeTypeName("#define CFSTR_MIME_RAWDATASTRM (TEXT(\"application/octet-stream\"))")]
        public const string CFSTR_MIME_RAWDATASTRM = ("application/octet-stream");

        [NativeTypeName("#define CFSTR_MIME_PDF (TEXT(\"application/pdf\"))")]
        public const string CFSTR_MIME_PDF = ("application/pdf");

        [NativeTypeName("#define CFSTR_MIME_HTA (TEXT(\"application/hta\"))")]
        public const string CFSTR_MIME_HTA = ("application/hta");

        [NativeTypeName("#define CFSTR_MIME_APP_XML (TEXT(\"application/xml\"))")]
        public const string CFSTR_MIME_APP_XML = ("application/xml");

        [NativeTypeName("#define CFSTR_MIME_XHTML (TEXT(\"application/xhtml+xml\"))")]
        public const string CFSTR_MIME_XHTML = ("application/xhtml+xml");

        [NativeTypeName("#define CFSTR_MIME_X_AIFF (TEXT(\"audio/x-aiff\"))")]
        public const string CFSTR_MIME_X_AIFF = ("audio/x-aiff");

        [NativeTypeName("#define CFSTR_MIME_X_REALAUDIO (TEXT(\"audio/x-pn-realaudio\"))")]
        public const string CFSTR_MIME_X_REALAUDIO = ("audio/x-pn-realaudio");

        [NativeTypeName("#define CFSTR_MIME_XBM (TEXT(\"image/xbm\"))")]
        public const string CFSTR_MIME_XBM = ("image/xbm");

        [NativeTypeName("#define CFSTR_MIME_QUICKTIME (TEXT(\"video/quicktime\"))")]
        public const string CFSTR_MIME_QUICKTIME = ("video/quicktime");

        [NativeTypeName("#define CFSTR_MIME_X_MSVIDEO (TEXT(\"video/x-msvideo\"))")]
        public const string CFSTR_MIME_X_MSVIDEO = ("video/x-msvideo");

        [NativeTypeName("#define CFSTR_MIME_X_SGI_MOVIE (TEXT(\"video/x-sgi-movie\"))")]
        public const string CFSTR_MIME_X_SGI_MOVIE = ("video/x-sgi-movie");

        [NativeTypeName("#define CFSTR_MIME_X_MIXED_REPLACE (TEXT(\"multipart/x-mixed-replace\"))")]
        public const string CFSTR_MIME_X_MIXED_REPLACE = ("multipart/x-mixed-replace");

        [NativeTypeName("#define CFSTR_MIME_HTML (TEXT(\"text/html\"))")]
        public const string CFSTR_MIME_HTML = ("text/html");

        [NativeTypeName("#define CFSTR_MIME_XML (TEXT(\"text/xml\"))")]
        public const string CFSTR_MIME_XML = ("text/xml");

        [NativeTypeName("#define CFSTR_MIME_TTML (TEXT(\"application/ttml+xml\"))")]
        public const string CFSTR_MIME_TTML = ("application/ttml+xml");

        [NativeTypeName("#define CFSTR_MIME_TTAF (TEXT(\"application/ttaf+xml\"))")]
        public const string CFSTR_MIME_TTAF = ("application/ttaf+xml");

        [NativeTypeName("#define CFSTR_MIME_X_JAVASCRIPT (TEXT(\"application/x-javascript\"))")]
        public const string CFSTR_MIME_X_JAVASCRIPT = ("application/x-javascript");

        [NativeTypeName("#define CFSTR_MIME_TEXT_JSON (TEXT(\"text/json\"))")]
        public const string CFSTR_MIME_TEXT_JSON = ("text/json");

        [NativeTypeName("#define CFSTR_MIME_APPLICATION_JAVASCRIPT (TEXT(\"application/javascript\"))")]
        public const string CFSTR_MIME_APPLICATION_JAVASCRIPT = ("application/javascript");

        [NativeTypeName("#define MK_S_ASYNCHRONOUS _HRESULT_TYPEDEF_(0x000401E8L)")]
        public const int MK_S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define S_ASYNCHRONOUS MK_S_ASYNCHRONOUS")]
        public const int S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define INET_E_INVALID_URL _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_INVALID_URL = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_NO_SESSION _HRESULT_TYPEDEF_(0x800C0003L)")]
        public const int INET_E_NO_SESSION = unchecked((int)(0x800C0003));

        [NativeTypeName("#define INET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x800C0004L)")]
        public const int INET_E_CANNOT_CONNECT = unchecked((int)(0x800C0004));

        [NativeTypeName("#define INET_E_RESOURCE_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0005L)")]
        public const int INET_E_RESOURCE_NOT_FOUND = unchecked((int)(0x800C0005));

        [NativeTypeName("#define INET_E_OBJECT_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0006L)")]
        public const int INET_E_OBJECT_NOT_FOUND = unchecked((int)(0x800C0006));

        [NativeTypeName("#define INET_E_DATA_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x800C0007L)")]
        public const int INET_E_DATA_NOT_AVAILABLE = unchecked((int)(0x800C0007));

        [NativeTypeName("#define INET_E_DOWNLOAD_FAILURE _HRESULT_TYPEDEF_(0x800C0008L)")]
        public const int INET_E_DOWNLOAD_FAILURE = unchecked((int)(0x800C0008));

        [NativeTypeName("#define INET_E_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x800C0009L)")]
        public const int INET_E_AUTHENTICATION_REQUIRED = unchecked((int)(0x800C0009));

        [NativeTypeName("#define INET_E_NO_VALID_MEDIA _HRESULT_TYPEDEF_(0x800C000AL)")]
        public const int INET_E_NO_VALID_MEDIA = unchecked((int)(0x800C000A));

        [NativeTypeName("#define INET_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x800C000BL)")]
        public const int INET_E_CONNECTION_TIMEOUT = unchecked((int)(0x800C000B));

        [NativeTypeName("#define INET_E_INVALID_REQUEST _HRESULT_TYPEDEF_(0x800C000CL)")]
        public const int INET_E_INVALID_REQUEST = unchecked((int)(0x800C000C));

        [NativeTypeName("#define INET_E_UNKNOWN_PROTOCOL _HRESULT_TYPEDEF_(0x800C000DL)")]
        public const int INET_E_UNKNOWN_PROTOCOL = unchecked((int)(0x800C000D));

        [NativeTypeName("#define INET_E_SECURITY_PROBLEM _HRESULT_TYPEDEF_(0x800C000EL)")]
        public const int INET_E_SECURITY_PROBLEM = unchecked((int)(0x800C000E));

        [NativeTypeName("#define INET_E_CANNOT_LOAD_DATA _HRESULT_TYPEDEF_(0x800C000FL)")]
        public const int INET_E_CANNOT_LOAD_DATA = unchecked((int)(0x800C000F));

        [NativeTypeName("#define INET_E_CANNOT_INSTANTIATE_OBJECT _HRESULT_TYPEDEF_(0x800C0010L)")]
        public const int INET_E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)(0x800C0010));

        [NativeTypeName("#define INET_E_INVALID_CERTIFICATE _HRESULT_TYPEDEF_(0x800C0019L)")]
        public const int INET_E_INVALID_CERTIFICATE = unchecked((int)(0x800C0019));

        [NativeTypeName("#define INET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECT_FAILED = unchecked((int)(0x800C0014));

        [NativeTypeName("#define INET_E_REDIRECT_TO_DIR _HRESULT_TYPEDEF_(0x800C0015L)")]
        public const int INET_E_REDIRECT_TO_DIR = unchecked((int)(0x800C0015));

        [NativeTypeName("#define INET_E_CANNOT_LOCK_REQUEST _HRESULT_TYPEDEF_(0x800C0016L)")]
        public const int INET_E_CANNOT_LOCK_REQUEST = unchecked((int)(0x800C0016));

        [NativeTypeName("#define INET_E_USE_EXTEND_BINDING _HRESULT_TYPEDEF_(0x800C0017L)")]
        public const int INET_E_USE_EXTEND_BINDING = unchecked((int)(0x800C0017));

        [NativeTypeName("#define INET_E_TERMINATED_BIND _HRESULT_TYPEDEF_(0x800C0018L)")]
        public const int INET_E_TERMINATED_BIND = unchecked((int)(0x800C0018));

        [NativeTypeName("#define INET_E_RESERVED_1 _HRESULT_TYPEDEF_(0x800C001AL)")]
        public const int INET_E_RESERVED_1 = unchecked((int)(0x800C001A));

        [NativeTypeName("#define INET_E_BLOCKED_REDIRECT_XSECURITYID _HRESULT_TYPEDEF_(0x800C001BL)")]
        public const int INET_E_BLOCKED_REDIRECT_XSECURITYID = unchecked((int)(0x800C001B));

        [NativeTypeName("#define INET_E_DOMINJECTIONVALIDATION _HRESULT_TYPEDEF_(0x800C001CL)")]
        public const int INET_E_DOMINJECTIONVALIDATION = unchecked((int)(0x800C001C));

        [NativeTypeName("#define INET_E_VTAB_SWITCH_FORCE_ENGINE _HRESULT_TYPEDEF_(0x800C001DL)")]
        public const int INET_E_VTAB_SWITCH_FORCE_ENGINE = unchecked((int)(0x800C001D));

        [NativeTypeName("#define INET_E_HSTS_CERTIFICATE_ERROR _HRESULT_TYPEDEF_(0x800C001EL)")]
        public const int INET_E_HSTS_CERTIFICATE_ERROR = unchecked((int)(0x800C001E));

        [NativeTypeName("#define INET_E_RESERVED_2 _HRESULT_TYPEDEF_(0x800C001FL)")]
        public const int INET_E_RESERVED_2 = unchecked((int)(0x800C001F));

        [NativeTypeName("#define INET_E_RESERVED_3 _HRESULT_TYPEDEF_(0x800C0020L)")]
        public const int INET_E_RESERVED_3 = unchecked((int)(0x800C0020));

        [NativeTypeName("#define INET_E_RESERVED_4 _HRESULT_TYPEDEF_(0x800C0021L)")]
        public const int INET_E_RESERVED_4 = unchecked((int)(0x800C0021));

        [NativeTypeName("#define INET_E_RESERVED_5 _HRESULT_TYPEDEF_(0x800C0022L)")]
        public const int INET_E_RESERVED_5 = unchecked((int)(0x800C0022));

        [NativeTypeName("#define INET_E_ERROR_FIRST _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_ERROR_FIRST = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_CODE_DOWNLOAD_DECLINED _HRESULT_TYPEDEF_(0x800C0100L)")]
        public const int INET_E_CODE_DOWNLOAD_DECLINED = unchecked((int)(0x800C0100));

        [NativeTypeName("#define INET_E_RESULT_DISPATCHED _HRESULT_TYPEDEF_(0x800C0200L)")]
        public const int INET_E_RESULT_DISPATCHED = unchecked((int)(0x800C0200));

        [NativeTypeName("#define INET_E_CANNOT_REPLACE_SFP_FILE _HRESULT_TYPEDEF_(0x800C0300L)")]
        public const int INET_E_CANNOT_REPLACE_SFP_FILE = unchecked((int)(0x800C0300));

        [NativeTypeName("#define INET_E_CODE_INSTALL_SUPPRESSED _HRESULT_TYPEDEF_(0x800C0400L)")]
        public const int INET_E_CODE_INSTALL_SUPPRESSED = unchecked((int)(0x800C0400));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY _HRESULT_TYPEDEF_(0x800C0500L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY = unchecked((int)(0x800C0500));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE _HRESULT_TYPEDEF_(0x800C0501L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE = unchecked((int)(0x800C0501));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE _HRESULT_TYPEDEF_(0x800C0502L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE = unchecked((int)(0x800C0502));

        [NativeTypeName("#define INET_E_FORBIDFRAMING _HRESULT_TYPEDEF_(0x800C0503L)")]
        public const int INET_E_FORBIDFRAMING = unchecked((int)(0x800C0503));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_ARM _HRESULT_TYPEDEF_(0x800C0504L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_ARM = unchecked((int)(0x800C0504));

        [NativeTypeName("#define INET_E_BLOCKED_PLUGGABLE_PROTOCOL _HRESULT_TYPEDEF_(0x800C0505L)")]
        public const int INET_E_BLOCKED_PLUGGABLE_PROTOCOL = unchecked((int)(0x800C0505));

        [NativeTypeName("#define INET_E_BLOCKED_ENHANCEDPROTECTEDMODE _HRESULT_TYPEDEF_(0x800C0506L)")]
        public const int INET_E_BLOCKED_ENHANCEDPROTECTEDMODE = unchecked((int)(0x800C0506));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BITNESS _HRESULT_TYPEDEF_(0x800C0507L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BITNESS = unchecked((int)(0x800C0507));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_CSP _HRESULT_TYPEDEF_(0x800C0508L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_CSP = unchecked((int)(0x800C0508));

        [NativeTypeName("#define INET_E_ERROR_LAST INET_E_DOWNLOAD_BLOCKED_BY_CSP")]
        public const int INET_E_ERROR_LAST = unchecked((int)(0x800C0508));

        [NativeTypeName("#define Uri_HAS_ABSOLUTE_URI (1 << Uri_PROPERTY_ABSOLUTE_URI)")]
        public const int Uri_HAS_ABSOLUTE_URI = (1 << (int)(Uri_PROPERTY_ABSOLUTE_URI));

        [NativeTypeName("#define Uri_HAS_AUTHORITY (1 << Uri_PROPERTY_AUTHORITY)")]
        public const int Uri_HAS_AUTHORITY = (1 << (int)(Uri_PROPERTY_AUTHORITY));

        [NativeTypeName("#define Uri_HAS_DISPLAY_URI (1 << Uri_PROPERTY_DISPLAY_URI)")]
        public const int Uri_HAS_DISPLAY_URI = (1 << (int)(Uri_PROPERTY_DISPLAY_URI));

        [NativeTypeName("#define Uri_HAS_DOMAIN (1 << Uri_PROPERTY_DOMAIN)")]
        public const int Uri_HAS_DOMAIN = (1 << (int)(Uri_PROPERTY_DOMAIN));

        [NativeTypeName("#define Uri_HAS_EXTENSION (1 << Uri_PROPERTY_EXTENSION)")]
        public const int Uri_HAS_EXTENSION = (1 << (int)(Uri_PROPERTY_EXTENSION));

        [NativeTypeName("#define Uri_HAS_FRAGMENT (1 << Uri_PROPERTY_FRAGMENT)")]
        public const int Uri_HAS_FRAGMENT = (1 << (int)(Uri_PROPERTY_FRAGMENT));

        [NativeTypeName("#define Uri_HAS_HOST (1 << Uri_PROPERTY_HOST)")]
        public const int Uri_HAS_HOST = (1 << (int)(Uri_PROPERTY_HOST));

        [NativeTypeName("#define Uri_HAS_PASSWORD (1 << Uri_PROPERTY_PASSWORD)")]
        public const int Uri_HAS_PASSWORD = (1 << (int)(Uri_PROPERTY_PASSWORD));

        [NativeTypeName("#define Uri_HAS_PATH (1 << Uri_PROPERTY_PATH)")]
        public const int Uri_HAS_PATH = (1 << (int)(Uri_PROPERTY_PATH));

        [NativeTypeName("#define Uri_HAS_QUERY (1 << Uri_PROPERTY_QUERY)")]
        public const int Uri_HAS_QUERY = (1 << (int)(Uri_PROPERTY_QUERY));

        [NativeTypeName("#define Uri_HAS_RAW_URI (1 << Uri_PROPERTY_RAW_URI)")]
        public const int Uri_HAS_RAW_URI = (1 << (int)(Uri_PROPERTY_RAW_URI));

        [NativeTypeName("#define Uri_HAS_SCHEME_NAME (1 << Uri_PROPERTY_SCHEME_NAME)")]
        public const int Uri_HAS_SCHEME_NAME = (1 << (int)(Uri_PROPERTY_SCHEME_NAME));

        [NativeTypeName("#define Uri_HAS_USER_NAME (1 << Uri_PROPERTY_USER_NAME)")]
        public const int Uri_HAS_USER_NAME = (1 << (int)(Uri_PROPERTY_USER_NAME));

        [NativeTypeName("#define Uri_HAS_PATH_AND_QUERY (1 << Uri_PROPERTY_PATH_AND_QUERY)")]
        public const int Uri_HAS_PATH_AND_QUERY = (1 << (int)(Uri_PROPERTY_PATH_AND_QUERY));

        [NativeTypeName("#define Uri_HAS_USER_INFO (1 << Uri_PROPERTY_USER_INFO)")]
        public const int Uri_HAS_USER_INFO = (1 << (int)(Uri_PROPERTY_USER_INFO));

        [NativeTypeName("#define Uri_HAS_HOST_TYPE (1 << Uri_PROPERTY_HOST_TYPE)")]
        public const int Uri_HAS_HOST_TYPE = (1 << (int)(Uri_PROPERTY_HOST_TYPE));

        [NativeTypeName("#define Uri_HAS_PORT (1 << Uri_PROPERTY_PORT)")]
        public const int Uri_HAS_PORT = (1 << (int)(Uri_PROPERTY_PORT));

        [NativeTypeName("#define Uri_HAS_SCHEME (1 << Uri_PROPERTY_SCHEME)")]
        public const int Uri_HAS_SCHEME = (1 << (int)(Uri_PROPERTY_SCHEME));

        [NativeTypeName("#define Uri_HAS_ZONE (1 << Uri_PROPERTY_ZONE)")]
        public const int Uri_HAS_ZONE = (1 << (int)(Uri_PROPERTY_ZONE));

        [NativeTypeName("#define Uri_CREATE_ALLOW_RELATIVE 0x00000001")]
        public const int Uri_CREATE_ALLOW_RELATIVE = 0x00000001;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME 0x00000002")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME = 0x00000002;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME 0x00000004")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME = 0x00000004;

        [NativeTypeName("#define Uri_CREATE_NOFRAG 0x00000008")]
        public const int Uri_CREATE_NOFRAG = 0x00000008;

        [NativeTypeName("#define Uri_CREATE_NO_CANONICALIZE 0x00000010")]
        public const int Uri_CREATE_NO_CANONICALIZE = 0x00000010;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE 0x00000100")]
        public const int Uri_CREATE_CANONICALIZE = 0x00000100;

        [NativeTypeName("#define Uri_CREATE_FILE_USE_DOS_PATH 0x00000020")]
        public const int Uri_CREATE_FILE_USE_DOS_PATH = 0x00000020;

        [NativeTypeName("#define Uri_CREATE_DECODE_EXTRA_INFO 0x00000040")]
        public const int Uri_CREATE_DECODE_EXTRA_INFO = 0x00000040;

        [NativeTypeName("#define Uri_CREATE_NO_DECODE_EXTRA_INFO 0x00000080")]
        public const int Uri_CREATE_NO_DECODE_EXTRA_INFO = 0x00000080;

        [NativeTypeName("#define Uri_CREATE_CRACK_UNKNOWN_SCHEMES 0x00000200")]
        public const int Uri_CREATE_CRACK_UNKNOWN_SCHEMES = 0x00000200;

        [NativeTypeName("#define Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES 0x00000400")]
        public const int Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES = 0x00000400;

        [NativeTypeName("#define Uri_CREATE_PRE_PROCESS_HTML_URI 0x00000800")]
        public const int Uri_CREATE_PRE_PROCESS_HTML_URI = 0x00000800;

        [NativeTypeName("#define Uri_CREATE_NO_PRE_PROCESS_HTML_URI 0x00001000")]
        public const int Uri_CREATE_NO_PRE_PROCESS_HTML_URI = 0x00001000;

        [NativeTypeName("#define Uri_CREATE_IE_SETTINGS 0x00002000")]
        public const int Uri_CREATE_IE_SETTINGS = 0x00002000;

        [NativeTypeName("#define Uri_CREATE_NO_IE_SETTINGS 0x00004000")]
        public const int Uri_CREATE_NO_IE_SETTINGS = 0x00004000;

        [NativeTypeName("#define Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS 0x00008000")]
        public const int Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS = 0x00008000;

        [NativeTypeName("#define Uri_CREATE_NORMALIZE_INTL_CHARACTERS 0x00010000")]
        public const int Uri_CREATE_NORMALIZE_INTL_CHARACTERS = 0x00010000;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE_ABSOLUTE 0x00020000")]
        public const int Uri_CREATE_CANONICALIZE_ABSOLUTE = 0x00020000;

        [NativeTypeName("#define Uri_DISPLAY_NO_FRAGMENT 0x00000001")]
        public const int Uri_DISPLAY_NO_FRAGMENT = 0x00000001;

        [NativeTypeName("#define Uri_PUNYCODE_IDN_HOST 0x00000002")]
        public const int Uri_PUNYCODE_IDN_HOST = 0x00000002;

        [NativeTypeName("#define Uri_DISPLAY_IDN_HOST 0x00000004")]
        public const int Uri_DISPLAY_IDN_HOST = 0x00000004;

        [NativeTypeName("#define Uri_DISPLAY_NO_PUNYCODE 0x00000008")]
        public const int Uri_DISPLAY_NO_PUNYCODE = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 0x00000001")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 = 0x00000001;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_CP 0x00000002")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_CP = 0x00000002;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_IDN 0x00000004")]
        public const int Uri_ENCODING_HOST_IS_IDN = 0x00000004;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 0x00000008")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP 0x00000010")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP = 0x00000010;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 0x00000020")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 = 0x00000020;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP 0x00000040")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP = 0x00000040;

        [NativeTypeName("#define Uri_ENCODING_RFC (Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8)")]
        public const int Uri_ENCODING_RFC = (0x00000001 | 0x00000008 | 0x00000020);

        [NativeTypeName("#define UriBuilder_USE_ORIGINAL_FLAGS 0x00000001")]
        public const int UriBuilder_USE_ORIGINAL_FLAGS = 0x00000001;

        [NativeTypeName("#define WININETINFO_OPTION_LOCK_HANDLE 65534")]
        public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

        [NativeTypeName("#define SID_IBindHost IID_IBindHost")]
        public static ref readonly Guid SID_IBindHost => ref IID_IBindHost;

        [NativeTypeName("#define SID_SBindHost IID_IBindHost")]
        public static ref readonly Guid SID_SBindHost => ref IID_IBindHost;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY_ONLY 0x1")]
        public const int URLOSTRM_USECACHEDCOPY_ONLY = 0x1;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY 0x2")]
        public const int URLOSTRM_USECACHEDCOPY = 0x2;

        [NativeTypeName("#define URLOSTRM_GETNEWESTVERSION 0x3")]
        public const int URLOSTRM_GETNEWESTVERSION = 0x3;

        [NativeTypeName("#define URLOpenStream URLOpenStreamW")]
        public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenStream => &URLOpenStreamW;

        [NativeTypeName("#define URLOpenPullStream URLOpenPullStreamW")]
        public static delegate*<IUnknown*, ushort*, uint, IBindStatusCallback*, HRESULT> URLOpenPullStream => &URLOpenPullStreamW;

        [NativeTypeName("#define URLDownloadToFile URLDownloadToFileW")]
        public static delegate*<IUnknown*, ushort*, ushort*, uint, IBindStatusCallback*, HRESULT> URLDownloadToFile => &URLDownloadToFileW;

        [NativeTypeName("#define URLDownloadToCacheFile URLDownloadToCacheFileW")]
        public static delegate*<IUnknown*, ushort*, ushort*, uint, uint, IBindStatusCallback*, HRESULT> URLDownloadToCacheFile => &URLDownloadToCacheFileW;

        [NativeTypeName("#define URLOpenBlockingStream URLOpenBlockingStreamW")]
        public static delegate*<IUnknown*, ushort*, IStream**, uint, IBindStatusCallback*, HRESULT> URLOpenBlockingStream => &URLOpenBlockingStreamW;

        [NativeTypeName("#define PARSE_ENCODE PARSE_ENCODE_IS_UNESCAPE")]
        public const PARSEACTION PARSE_ENCODE = PARSE_ENCODE_IS_UNESCAPE;

        [NativeTypeName("#define PARSE_DECODE PARSE_DECODE_IS_ESCAPE")]
        public const PARSEACTION PARSE_DECODE = PARSE_DECODE_IS_ESCAPE;

        [NativeTypeName("#define IID_IOInet IID_IInternet")]
        public static ref readonly Guid IID_IOInet => ref IID_IInternet;

        [NativeTypeName("#define IID_IOInetBindInfo IID_IInternetBindInfo")]
        public static ref readonly Guid IID_IOInetBindInfo => ref IID_IInternetBindInfo;

        [NativeTypeName("#define IID_IOInetBindInfoEx IID_IInternetBindInfoEx")]
        public static ref readonly Guid IID_IOInetBindInfoEx => ref IID_IInternetBindInfoEx;

        [NativeTypeName("#define IID_IOInetProtocolRoot IID_IInternetProtocolRoot")]
        public static ref readonly Guid IID_IOInetProtocolRoot => ref IID_IInternetProtocolRoot;

        [NativeTypeName("#define IID_IOInetProtocol IID_IInternetProtocol")]
        public static ref readonly Guid IID_IOInetProtocol => ref IID_IInternetProtocol;

        [NativeTypeName("#define IID_IOInetProtocolEx IID_IInternetProtocolEx")]
        public static ref readonly Guid IID_IOInetProtocolEx => ref IID_IInternetProtocolEx;

        [NativeTypeName("#define IID_IOInetProtocolSink IID_IInternetProtocolSink")]
        public static ref readonly Guid IID_IOInetProtocolSink => ref IID_IInternetProtocolSink;

        [NativeTypeName("#define IID_IOInetProtocolInfo IID_IInternetProtocolInfo")]
        public static ref readonly Guid IID_IOInetProtocolInfo => ref IID_IInternetProtocolInfo;

        [NativeTypeName("#define IID_IOInetSession IID_IInternetSession")]
        public static ref readonly Guid IID_IOInetSession => ref IID_IInternetSession;

        [NativeTypeName("#define IID_IOInetPriority IID_IInternetPriority")]
        public static ref readonly Guid IID_IOInetPriority => ref IID_IInternetPriority;

        [NativeTypeName("#define IID_IOInetThreadSwitch IID_IInternetThreadSwitch")]
        public static ref readonly Guid IID_IOInetThreadSwitch => ref IID_IInternetThreadSwitch;

        [NativeTypeName("#define IID_IOInetProtocolSinkStackable IID_IInternetProtocolSinkStackable")]
        public static ref readonly Guid IID_IOInetProtocolSinkStackable => ref IID_IInternetProtocolSinkStackable;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD 0x00000001")]
        public const int SET_FEATURE_ON_THREAD = 0x00000001;

        [NativeTypeName("#define SET_FEATURE_ON_PROCESS 0x00000002")]
        public const int SET_FEATURE_ON_PROCESS = 0x00000002;

        [NativeTypeName("#define SET_FEATURE_IN_REGISTRY 0x00000004")]
        public const int SET_FEATURE_IN_REGISTRY = 0x00000004;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_LOCALMACHINE 0x00000008")]
        public const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTRANET 0x00000010")]
        public const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_TRUSTED 0x00000020")]
        public const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTERNET 0x00000040")]
        public const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_RESTRICTED 0x00000080")]
        public const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD 0x00000001")]
        public const int GET_FEATURE_FROM_THREAD = 0x00000001;

        [NativeTypeName("#define GET_FEATURE_FROM_PROCESS 0x00000002")]
        public const int GET_FEATURE_FROM_PROCESS = 0x00000002;

        [NativeTypeName("#define GET_FEATURE_FROM_REGISTRY 0x00000004")]
        public const int GET_FEATURE_FROM_REGISTRY = 0x00000004;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_LOCALMACHINE 0x00000008")]
        public const int GET_FEATURE_FROM_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTRANET 0x00000010")]
        public const int GET_FEATURE_FROM_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_TRUSTED 0x00000020")]
        public const int GET_FEATURE_FROM_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTERNET 0x00000040")]
        public const int GET_FEATURE_FROM_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_RESTRICTED 0x00000080")]
        public const int GET_FEATURE_FROM_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define INET_E_USE_DEFAULT_PROTOCOLHANDLER _HRESULT_TYPEDEF_(0x800C0011L)")]
        public const int INET_E_USE_DEFAULT_PROTOCOLHANDLER = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_USE_DEFAULT_SETTING _HRESULT_TYPEDEF_(0x800C0012L)")]
        public const int INET_E_USE_DEFAULT_SETTING = unchecked((int)(0x800C0012));

        [NativeTypeName("#define INET_E_DEFAULT_ACTION INET_E_USE_DEFAULT_PROTOCOLHANDLER")]
        public const int INET_E_DEFAULT_ACTION = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_QUERYOPTION_UNKNOWN _HRESULT_TYPEDEF_(0x800C0013L)")]
        public const int INET_E_QUERYOPTION_UNKNOWN = unchecked((int)(0x800C0013));

        [NativeTypeName("#define INET_E_REDIRECTING _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECTING = unchecked((int)(0x800C0014));

        [NativeTypeName("#define OInetParseUrl CoInternetParseUrl")]
        public static delegate*<ushort*, PARSEACTION, uint, ushort*, uint, uint*, uint, HRESULT> OInetParseUrl => &CoInternetParseUrl;

        [NativeTypeName("#define OInetCombineUrl CoInternetCombineUrl")]
        public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint*, uint, HRESULT> OInetCombineUrl => &CoInternetCombineUrl;

        [NativeTypeName("#define OInetCombineUrlEx CoInternetCombineUrlEx")]
        public static delegate*<IUri*, ushort*, uint, IUri**, nuint, HRESULT> OInetCombineUrlEx => &CoInternetCombineUrlEx;

        [NativeTypeName("#define OInetCombineIUri CoInternetCombineIUri")]
        public static delegate*<IUri*, IUri*, uint, IUri**, nuint, HRESULT> OInetCombineIUri => &CoInternetCombineIUri;

        [NativeTypeName("#define OInetCompareUrl CoInternetCompareUrl")]
        public static delegate*<ushort*, ushort*, uint, HRESULT> OInetCompareUrl => &CoInternetCompareUrl;

        [NativeTypeName("#define OInetQueryInfo CoInternetQueryInfo")]
        public static delegate*<ushort*, QUERYOPTION, uint, void*, uint, uint*, uint, HRESULT> OInetQueryInfo => &CoInternetQueryInfo;

        [NativeTypeName("#define OInetGetSession CoInternetGetSession")]
        public static delegate*<uint, IInternetSession**, uint, HRESULT> OInetGetSession => &CoInternetGetSession;

        [NativeTypeName("#define PROTOCOLFLAG_NO_PICS_CHECK 0x00000001")]
        public const int PROTOCOLFLAG_NO_PICS_CHECK = 0x00000001;

        [NativeTypeName("#define SID_SInternetSecurityManager IID_IInternetSecurityManager")]
        public static ref readonly Guid SID_SInternetSecurityManager => ref IID_IInternetSecurityManager;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx IID_IInternetSecurityManagerEx")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx => ref IID_IInternetSecurityManagerEx;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx2 IID_IInternetSecurityManagerEx2")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx2 => ref IID_IInternetSecurityManagerEx2;

        [NativeTypeName("#define SID_SInternetHostSecurityManager IID_IInternetHostSecurityManager")]
        public static ref readonly Guid SID_SInternetHostSecurityManager => ref IID_IInternetHostSecurityManager;

        [NativeTypeName("#define MUTZ_NOSAVEDFILECHECK 0x00000001")]
        public const int MUTZ_NOSAVEDFILECHECK = 0x00000001;

        [NativeTypeName("#define MUTZ_ISFILE 0x00000002")]
        public const int MUTZ_ISFILE = 0x00000002;

        [NativeTypeName("#define MUTZ_ACCEPT_WILDCARD_SCHEME 0x00000080")]
        public const int MUTZ_ACCEPT_WILDCARD_SCHEME = 0x00000080;

        [NativeTypeName("#define MUTZ_ENFORCERESTRICTED 0x00000100")]
        public const int MUTZ_ENFORCERESTRICTED = 0x00000100;

        [NativeTypeName("#define MUTZ_RESERVED 0x00000200")]
        public const int MUTZ_RESERVED = 0x00000200;

        [NativeTypeName("#define MUTZ_REQUIRESAVEDFILECHECK 0x00000400")]
        public const int MUTZ_REQUIRESAVEDFILECHECK = 0x00000400;

        [NativeTypeName("#define MUTZ_DONT_UNESCAPE 0x00000800")]
        public const int MUTZ_DONT_UNESCAPE = 0x00000800;

        [NativeTypeName("#define MUTZ_DONT_USE_CACHE 0x00001000")]
        public const int MUTZ_DONT_USE_CACHE = 0x00001000;

        [NativeTypeName("#define MUTZ_FORCE_INTRANET_FLAGS 0x00002000")]
        public const int MUTZ_FORCE_INTRANET_FLAGS = 0x00002000;

        [NativeTypeName("#define MUTZ_IGNORE_ZONE_MAPPINGS 0x00004000")]
        public const int MUTZ_IGNORE_ZONE_MAPPINGS = 0x00004000;

        [NativeTypeName("#define MAX_SIZE_SECURITY_ID 512")]
        public const int MAX_SIZE_SECURITY_ID = 512;

        [NativeTypeName("#define URLACTION_MIN 0x00001000")]
        public const int URLACTION_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MIN 0x00001000")]
        public const int URLACTION_DOWNLOAD_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_SIGNED_ACTIVEX 0x00001001")]
        public const int URLACTION_DOWNLOAD_SIGNED_ACTIVEX = 0x00001001;

        [NativeTypeName("#define URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX 0x00001004")]
        public const int URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_CURR_MAX 0x00001004")]
        public const int URLACTION_DOWNLOAD_CURR_MAX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MAX 0x000011FF")]
        public const int URLACTION_DOWNLOAD_MAX = 0x000011FF;

        [NativeTypeName("#define URLACTION_ACTIVEX_MIN 0x00001200")]
        public const int URLACTION_ACTIVEX_MIN = 0x00001200;

        [NativeTypeName("#define URLACTION_ACTIVEX_RUN 0x00001200")]
        public const int URLACTION_ACTIVEX_RUN = 0x00001200;

        [NativeTypeName("#define URLPOLICY_ACTIVEX_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_ACTIVEX_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY 0x00001201")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY = 0x00001201;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY 0x00001202")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY = 0x00001202;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY 0x00001203")]
        public const int URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY = 0x00001203;

        [NativeTypeName("#define URLACTION_SCRIPT_OVERRIDE_SAFETY 0x00001401")]
        public const int URLACTION_SCRIPT_OVERRIDE_SAFETY = 0x00001401;

        [NativeTypeName("#define URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY 0x00001204")]
        public const int URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY = 0x00001204;

        [NativeTypeName("#define URLACTION_ACTIVEX_TREATASUNTRUSTED 0x00001205")]
        public const int URLACTION_ACTIVEX_TREATASUNTRUSTED = 0x00001205;

        [NativeTypeName("#define URLACTION_ACTIVEX_NO_WEBOC_SCRIPT 0x00001206")]
        public const int URLACTION_ACTIVEX_NO_WEBOC_SCRIPT = 0x00001206;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION 0x00001207")]
        public const int URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION = 0x00001207;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OPTIN 0x00001208")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OPTIN = 0x00001208;

        [NativeTypeName("#define URLACTION_ACTIVEX_SCRIPTLET_RUN 0x00001209")]
        public const int URLACTION_ACTIVEX_SCRIPTLET_RUN = 0x00001209;

        [NativeTypeName("#define URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION 0x0000120A")]
        public const int URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION = 0x0000120A;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST 0x0000120B")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST = 0x0000120B;

        [NativeTypeName("#define URLACTION_ACTIVEX_ALLOW_TDC 0x0000120C")]
        public const int URLACTION_ACTIVEX_ALLOW_TDC = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_CURR_MAX 0x0000120C")]
        public const int URLACTION_ACTIVEX_CURR_MAX = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_MAX 0x000013ff")]
        public const int URLACTION_ACTIVEX_MAX = 0x000013ff;

        [NativeTypeName("#define URLACTION_SCRIPT_MIN 0x00001400")]
        public const int URLACTION_SCRIPT_MIN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_RUN 0x00001400")]
        public const int URLACTION_SCRIPT_RUN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_JAVA_USE 0x00001402")]
        public const int URLACTION_SCRIPT_JAVA_USE = 0x00001402;

        [NativeTypeName("#define URLACTION_SCRIPT_SAFE_ACTIVEX 0x00001405")]
        public const int URLACTION_SCRIPT_SAFE_ACTIVEX = 0x00001405;

        [NativeTypeName("#define URLACTION_CROSS_DOMAIN_DATA 0x00001406")]
        public const int URLACTION_CROSS_DOMAIN_DATA = 0x00001406;

        [NativeTypeName("#define URLACTION_SCRIPT_PASTE 0x00001407")]
        public const int URLACTION_SCRIPT_PASTE = 0x00001407;

        [NativeTypeName("#define URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE 0x00001408")]
        public const int URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE = 0x00001408;

        [NativeTypeName("#define URLACTION_SCRIPT_XSSFILTER 0x00001409")]
        public const int URLACTION_SCRIPT_XSSFILTER = 0x00001409;

        [NativeTypeName("#define URLACTION_SCRIPT_NAVIGATE 0x0000140A")]
        public const int URLACTION_SCRIPT_NAVIGATE = 0x0000140A;

        [NativeTypeName("#define URLACTION_PLUGGABLE_PROTOCOL_XHR 0x0000140B")]
        public const int URLACTION_PLUGGABLE_PROTOCOL_XHR = 0x0000140B;

        [NativeTypeName("#define URLACTION_ALLOW_VBSCRIPT_IE 0x0000140C")]
        public const int URLACTION_ALLOW_VBSCRIPT_IE = 0x0000140C;

        [NativeTypeName("#define URLACTION_ALLOW_JSCRIPT_IE 0x0000140D")]
        public const int URLACTION_ALLOW_JSCRIPT_IE = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_CURR_MAX 0x0000140D")]
        public const int URLACTION_SCRIPT_CURR_MAX = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_MAX 0x000015ff")]
        public const int URLACTION_SCRIPT_MAX = 0x000015ff;

        [NativeTypeName("#define URLACTION_HTML_MIN 0x00001600")]
        public const int URLACTION_HTML_MIN = 0x00001600;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS 0x00001601")]
        public const int URLACTION_HTML_SUBMIT_FORMS = 0x00001601;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_FROM 0x00001602")]
        public const int URLACTION_HTML_SUBMIT_FORMS_FROM = 0x00001602;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_TO 0x00001603")]
        public const int URLACTION_HTML_SUBMIT_FORMS_TO = 0x00001603;

        [NativeTypeName("#define URLACTION_HTML_FONT_DOWNLOAD 0x00001604")]
        public const int URLACTION_HTML_FONT_DOWNLOAD = 0x00001604;

        [NativeTypeName("#define URLACTION_HTML_JAVA_RUN 0x00001605")]
        public const int URLACTION_HTML_JAVA_RUN = 0x00001605;

        [NativeTypeName("#define URLACTION_HTML_USERDATA_SAVE 0x00001606")]
        public const int URLACTION_HTML_USERDATA_SAVE = 0x00001606;

        [NativeTypeName("#define URLACTION_HTML_SUBFRAME_NAVIGATE 0x00001607")]
        public const int URLACTION_HTML_SUBFRAME_NAVIGATE = 0x00001607;

        [NativeTypeName("#define URLACTION_HTML_META_REFRESH 0x00001608")]
        public const int URLACTION_HTML_META_REFRESH = 0x00001608;

        [NativeTypeName("#define URLACTION_HTML_MIXED_CONTENT 0x00001609")]
        public const int URLACTION_HTML_MIXED_CONTENT = 0x00001609;

        [NativeTypeName("#define URLACTION_HTML_INCLUDE_FILE_PATH 0x0000160A")]
        public const int URLACTION_HTML_INCLUDE_FILE_PATH = 0x0000160A;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML 0x0000160B")]
        public const int URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML = 0x0000160B;

        [NativeTypeName("#define URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE 0x0000160C")]
        public const int URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE = 0x0000160C;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS 0x0000160D")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS = 0x0000160D;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_WINDOW_CLOSE 0x0000160E")]
        public const int URLACTION_HTML_ALLOW_WINDOW_CLOSE = 0x0000160E;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER 0x0000160F")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER = 0x0000160F;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK 0x00001610")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK = 0x00001610;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INDEXEDDB 0x00001611")]
        public const int URLACTION_HTML_ALLOW_INDEXEDDB = 0x00001611;

        [NativeTypeName("#define URLACTION_HTML_MAX 0x000017ff")]
        public const int URLACTION_HTML_MAX = 0x000017ff;

        [NativeTypeName("#define URLACTION_SHELL_MIN 0x00001800")]
        public const int URLACTION_SHELL_MIN = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_INSTALL_DTITEMS 0x00001800")]
        public const int URLACTION_SHELL_INSTALL_DTITEMS = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_MOVE_OR_COPY 0x00001802")]
        public const int URLACTION_SHELL_MOVE_OR_COPY = 0x00001802;

        [NativeTypeName("#define URLACTION_SHELL_FILE_DOWNLOAD 0x00001803")]
        public const int URLACTION_SHELL_FILE_DOWNLOAD = 0x00001803;

        [NativeTypeName("#define URLACTION_SHELL_VERB 0x00001804")]
        public const int URLACTION_SHELL_VERB = 0x00001804;

        [NativeTypeName("#define URLACTION_SHELL_WEBVIEW_VERB 0x00001805")]
        public const int URLACTION_SHELL_WEBVIEW_VERB = 0x00001805;

        [NativeTypeName("#define URLACTION_SHELL_SHELLEXECUTE 0x00001806")]
        public const int URLACTION_SHELL_SHELLEXECUTE = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_HIGHRISK 0x00001806")]
        public const int URLACTION_SHELL_EXECUTE_HIGHRISK = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_MODRISK 0x00001807")]
        public const int URLACTION_SHELL_EXECUTE_MODRISK = 0x00001807;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_LOWRISK 0x00001808")]
        public const int URLACTION_SHELL_EXECUTE_LOWRISK = 0x00001808;

        [NativeTypeName("#define URLACTION_SHELL_POPUPMGR 0x00001809")]
        public const int URLACTION_SHELL_POPUPMGR = 0x00001809;

        [NativeTypeName("#define URLACTION_SHELL_RTF_OBJECTS_LOAD 0x0000180A")]
        public const int URLACTION_SHELL_RTF_OBJECTS_LOAD = 0x0000180A;

        [NativeTypeName("#define URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY 0x0000180B")]
        public const int URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY = 0x0000180B;

        [NativeTypeName("#define URLACTION_SHELL_EXTENSIONSECURITY 0x0000180C")]
        public const int URLACTION_SHELL_EXTENSIONSECURITY = 0x0000180C;

        [NativeTypeName("#define URLACTION_SHELL_SECURE_DRAGSOURCE 0x0000180D")]
        public const int URLACTION_SHELL_SECURE_DRAGSOURCE = 0x0000180D;

        [NativeTypeName("#define URLACTION_SHELL_REMOTEQUERY 0x0000180E")]
        public const int URLACTION_SHELL_REMOTEQUERY = 0x0000180E;

        [NativeTypeName("#define URLACTION_SHELL_PREVIEW 0x0000180F")]
        public const int URLACTION_SHELL_PREVIEW = 0x0000180F;

        [NativeTypeName("#define URLACTION_SHELL_SHARE 0x00001810")]
        public const int URLACTION_SHELL_SHARE = 0x00001810;

        [NativeTypeName("#define URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE 0x00001811")]
        public const int URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE = 0x00001811;

        [NativeTypeName("#define URLACTION_SHELL_TOCTOU_RISK 0x00001812")]
        public const int URLACTION_SHELL_TOCTOU_RISK = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_CURR_MAX 0x00001812")]
        public const int URLACTION_SHELL_CURR_MAX = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_MAX 0x000019ff")]
        public const int URLACTION_SHELL_MAX = 0x000019ff;

        [NativeTypeName("#define URLACTION_NETWORK_MIN 0x00001A00")]
        public const int URLACTION_NETWORK_MIN = 0x00001A00;

        [NativeTypeName("#define URLACTION_CREDENTIALS_USE 0x00001A00")]
        public const int URLACTION_CREDENTIALS_USE = 0x00001A00;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_SILENT_LOGON_OK 0x00000000")]
        public const int URLPOLICY_CREDENTIALS_SILENT_LOGON_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_MUST_PROMPT_USER 0x00010000")]
        public const int URLPOLICY_CREDENTIALS_MUST_PROMPT_USER = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT 0x00020000")]
        public const int URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY 0x00030000")]
        public const int URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY = 0x00030000;

        [NativeTypeName("#define URLACTION_AUTHENTICATE_CLIENT 0x00001A01")]
        public const int URLACTION_AUTHENTICATE_CLIENT = 0x00001A01;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CLEARTEXT_OK 0x00000000")]
        public const int URLPOLICY_AUTHENTICATE_CLEARTEXT_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE 0x00010000")]
        public const int URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE = 0x00010000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_MUTUAL_ONLY 0x00030000")]
        public const int URLPOLICY_AUTHENTICATE_MUTUAL_ONLY = 0x00030000;

        [NativeTypeName("#define URLACTION_COOKIES 0x00001A02")]
        public const int URLACTION_COOKIES = 0x00001A02;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION 0x00001A03")]
        public const int URLACTION_COOKIES_SESSION = 0x00001A03;

        [NativeTypeName("#define URLACTION_CLIENT_CERT_PROMPT 0x00001A04")]
        public const int URLACTION_CLIENT_CERT_PROMPT = 0x00001A04;

        [NativeTypeName("#define URLACTION_COOKIES_THIRD_PARTY 0x00001A05")]
        public const int URLACTION_COOKIES_THIRD_PARTY = 0x00001A05;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION_THIRD_PARTY 0x00001A06")]
        public const int URLACTION_COOKIES_SESSION_THIRD_PARTY = 0x00001A06;

        [NativeTypeName("#define URLACTION_COOKIES_ENABLED 0x00001A10")]
        public const int URLACTION_COOKIES_ENABLED = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_CURR_MAX 0x00001A10")]
        public const int URLACTION_NETWORK_CURR_MAX = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_MAX 0x00001Bff")]
        public const int URLACTION_NETWORK_MAX = 0x00001Bff;

        [NativeTypeName("#define URLACTION_JAVA_MIN 0x00001C00")]
        public const int URLACTION_JAVA_MIN = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_PERMISSIONS 0x00001C00")]
        public const int URLACTION_JAVA_PERMISSIONS = 0x00001C00;

        [NativeTypeName("#define URLPOLICY_JAVA_PROHIBIT 0x00000000")]
        public const int URLPOLICY_JAVA_PROHIBIT = 0x00000000;

        [NativeTypeName("#define URLPOLICY_JAVA_HIGH 0x00010000")]
        public const int URLPOLICY_JAVA_HIGH = 0x00010000;

        [NativeTypeName("#define URLPOLICY_JAVA_MEDIUM 0x00020000")]
        public const int URLPOLICY_JAVA_MEDIUM = 0x00020000;

        [NativeTypeName("#define URLPOLICY_JAVA_LOW 0x00030000")]
        public const int URLPOLICY_JAVA_LOW = 0x00030000;

        [NativeTypeName("#define URLPOLICY_JAVA_CUSTOM 0x00800000")]
        public const int URLPOLICY_JAVA_CUSTOM = 0x00800000;

        [NativeTypeName("#define URLACTION_JAVA_CURR_MAX 0x00001C00")]
        public const int URLACTION_JAVA_CURR_MAX = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_MAX 0x00001Cff")]
        public const int URLACTION_JAVA_MAX = 0x00001Cff;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MIN 0x00001D00")]
        public const int URLACTION_INFODELIVERY_MIN = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_CHANNELS 0x00001D00")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_CHANNELS = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_CHANNELS 0x00001D01")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_CHANNELS = 0x00001D01;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS 0x00001D02")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS = 0x00001D02;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS 0x00001D03")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = 0x00001D03;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS 0x00001D04")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = 0x00001D04;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS 0x00001D05")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = 0x00001D05;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING 0x00001D06")]
        public const int URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_CURR_MAX 0x00001D06")]
        public const int URLACTION_INFODELIVERY_CURR_MAX = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MAX 0x00001Dff")]
        public const int URLACTION_INFODELIVERY_MAX = 0x00001Dff;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MIN 0x00001E00")]
        public const int URLACTION_CHANNEL_SOFTDIST_MIN = 0x00001E00;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_PERMISSIONS 0x00001E05")]
        public const int URLACTION_CHANNEL_SOFTDIST_PERMISSIONS = 0x00001E05;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT 0x00010000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PRECACHE 0x00020000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PRECACHE = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL 0x00030000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL = 0x00030000;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MAX 0x00001Eff")]
        public const int URLACTION_CHANNEL_SOFTDIST_MAX = 0x00001Eff;

        [NativeTypeName("#define URLACTION_DOTNET_USERCONTROLS 0x00002005")]
        public const int URLACTION_DOTNET_USERCONTROLS = 0x00002005;

        [NativeTypeName("#define URLACTION_BEHAVIOR_MIN 0x00002000")]
        public const int URLACTION_BEHAVIOR_MIN = 0x00002000;

        [NativeTypeName("#define URLACTION_BEHAVIOR_RUN 0x00002000")]
        public const int URLACTION_BEHAVIOR_RUN = 0x00002000;

        [NativeTypeName("#define URLPOLICY_BEHAVIOR_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_BEHAVIOR_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLACTION_FEATURE_MIN 0x00002100")]
        public const int URLACTION_FEATURE_MIN = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_MIME_SNIFFING 0x00002100")]
        public const int URLACTION_FEATURE_MIME_SNIFFING = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_ZONE_ELEVATION 0x00002101")]
        public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x00002101;

        [NativeTypeName("#define URLACTION_FEATURE_WINDOW_RESTRICTIONS 0x00002102")]
        public const int URLACTION_FEATURE_WINDOW_RESTRICTIONS = 0x00002102;

        [NativeTypeName("#define URLACTION_FEATURE_SCRIPT_STATUS_BAR 0x00002103")]
        public const int URLACTION_FEATURE_SCRIPT_STATUS_BAR = 0x00002103;

        [NativeTypeName("#define URLACTION_FEATURE_FORCE_ADDR_AND_STATUS 0x00002104")]
        public const int URLACTION_FEATURE_FORCE_ADDR_AND_STATUS = 0x00002104;

        [NativeTypeName("#define URLACTION_FEATURE_BLOCK_INPUT_PROMPTS 0x00002105")]
        public const int URLACTION_FEATURE_BLOCK_INPUT_PROMPTS = 0x00002105;

        [NativeTypeName("#define URLACTION_FEATURE_DATA_BINDING 0x00002106")]
        public const int URLACTION_FEATURE_DATA_BINDING = 0x00002106;

        [NativeTypeName("#define URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE 0x00002107")]
        public const int URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE = 0x00002107;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_ACTIVEX_UI 0x00002201")]
        public const int URLACTION_AUTOMATIC_ACTIVEX_UI = 0x00002201;

        [NativeTypeName("#define URLACTION_ALLOW_RESTRICTEDPROTOCOLS 0x00002300")]
        public const int URLACTION_ALLOW_RESTRICTEDPROTOCOLS = 0x00002300;

        [NativeTypeName("#define URLACTION_ALLOW_APEVALUATION 0x00002301")]
        public const int URLACTION_ALLOW_APEVALUATION = 0x00002301;

        [NativeTypeName("#define URLACTION_ALLOW_XHR_EVALUATION 0x00002302")]
        public const int URLACTION_ALLOW_XHR_EVALUATION = 0x00002302;

        [NativeTypeName("#define URLACTION_WINDOWS_BROWSER_APPLICATIONS 0x00002400")]
        public const int URLACTION_WINDOWS_BROWSER_APPLICATIONS = 0x00002400;

        [NativeTypeName("#define URLACTION_XPS_DOCUMENTS 0x00002401")]
        public const int URLACTION_XPS_DOCUMENTS = 0x00002401;

        [NativeTypeName("#define URLACTION_LOOSE_XAML 0x00002402")]
        public const int URLACTION_LOOSE_XAML = 0x00002402;

        [NativeTypeName("#define URLACTION_LOWRIGHTS 0x00002500")]
        public const int URLACTION_LOWRIGHTS = 0x00002500;

        [NativeTypeName("#define URLACTION_WINFX_SETUP 0x00002600")]
        public const int URLACTION_WINFX_SETUP = 0x00002600;

        [NativeTypeName("#define URLACTION_INPRIVATE_BLOCKING 0x00002700")]
        public const int URLACTION_INPRIVATE_BLOCKING = 0x00002700;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO 0x00002701")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO = 0x00002701;

        [NativeTypeName("#define URLACTION_ALLOW_ACTIVEX_FILTERING 0x00002702")]
        public const int URLACTION_ALLOW_ACTIVEX_FILTERING = 0x00002702;

        [NativeTypeName("#define URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING 0x00002703")]
        public const int URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING = 0x00002703;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS 0x00002704")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS = 0x00002704;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT 0x00002705")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT = 0x00002705;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION 0x00002706")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION = 0x00002706;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW 0x00002708")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW = 0x00002708;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS 0x00002709")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS = 0x00002709;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST 0x0000270A")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST = 0x0000270A;

        [NativeTypeName("#define URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS 0x0000270B")]
        public const int URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS = 0x0000270B;

        [NativeTypeName("#define URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX 0x0000270C")]
        public const int URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX = 0x0000270C;

        [NativeTypeName("#define URLACTION_ALLOW_CSS_EXPRESSIONS 0x0000270D")]
        public const int URLACTION_ALLOW_CSS_EXPRESSIONS = 0x0000270D;

        [NativeTypeName("#define URLPOLICY_ALLOW 0x00")]
        public const int URLPOLICY_ALLOW = 0x00;

        [NativeTypeName("#define URLPOLICY_QUERY 0x01")]
        public const int URLPOLICY_QUERY = 0x01;

        [NativeTypeName("#define URLPOLICY_DISALLOW 0x03")]
        public const int URLPOLICY_DISALLOW = 0x03;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_ALLOW 0x10")]
        public const int URLPOLICY_NOTIFY_ON_ALLOW = 0x10;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_DISALLOW 0x20")]
        public const int URLPOLICY_NOTIFY_ON_DISALLOW = 0x20;

        [NativeTypeName("#define URLPOLICY_LOG_ON_ALLOW 0x40")]
        public const int URLPOLICY_LOG_ON_ALLOW = 0x40;

        [NativeTypeName("#define URLPOLICY_LOG_ON_DISALLOW 0x80")]
        public const int URLPOLICY_LOG_ON_DISALLOW = 0x80;

        [NativeTypeName("#define URLPOLICY_MASK_PERMISSIONS 0x0f")]
        public const int URLPOLICY_MASK_PERMISSIONS = 0x0f;

        [NativeTypeName("#define URLPOLICY_DONTCHECKDLGBOX 0x100")]
        public const int URLPOLICY_DONTCHECKDLGBOX = 0x100;

        [NativeTypeName("#define URLZONE_ESC_FLAG 0x100")]
        public const int URLZONE_ESC_FLAG = 0x100;

        [NativeTypeName("#define SECURITY_IE_STATE_GREEN 0x00000000")]
        public const int SECURITY_IE_STATE_GREEN = 0x00000000;

        [NativeTypeName("#define SECURITY_IE_STATE_RED 0x00000001")]
        public const int SECURITY_IE_STATE_RED = 0x00000001;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_EMAIL 0x00000001")]
        public const int SOFTDIST_FLAG_USAGE_EMAIL = 0x00000001;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_PRECACHE 0x00000002")]
        public const int SOFTDIST_FLAG_USAGE_PRECACHE = 0x00000002;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_AUTOINSTALL 0x00000004")]
        public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 0x00000004;

        [NativeTypeName("#define SOFTDIST_FLAG_DELETE_SUBSCRIPTION 0x00000008")]
        public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 0x00000008;

        [NativeTypeName("#define SOFTDIST_ADSTATE_NONE 0x00000000")]
        public const int SOFTDIST_ADSTATE_NONE = 0x00000000;

        [NativeTypeName("#define SOFTDIST_ADSTATE_AVAILABLE 0x00000001")]
        public const int SOFTDIST_ADSTATE_AVAILABLE = 0x00000001;

        [NativeTypeName("#define SOFTDIST_ADSTATE_DOWNLOADED 0x00000002")]
        public const int SOFTDIST_ADSTATE_DOWNLOADED = 0x00000002;

        [NativeTypeName("#define SOFTDIST_ADSTATE_INSTALLED 0x00000003")]
        public const int SOFTDIST_ADSTATE_INSTALLED = 0x00000003;

        [NativeTypeName("#define IsLoggingEnabled IsLoggingEnabledW")]
        public static delegate*<ushort*, BOOL> IsLoggingEnabled => &IsLoggingEnabledW;

        [NativeTypeName("#define CONFIRMSAFETYACTION_LOADOBJECT 0x00000001")]
        public const int CONFIRMSAFETYACTION_LOADOBJECT = 0x00000001;

        public static ref readonly Guid IID_IPersistMoniker
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMonikerProp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x5F, 0xCA, 0xA5,
                    0x47, 0x18,
                    0x87, 0x4D,
                    0x9C,
                    0x5B,
                    0x91,
                    0x85,
                    0x09,
                    0xF7,
                    0x51,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBinding
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindStatusCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindStatusCallbackEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x4E, 0xA7, 0xAA,
                    0xE7, 0x8E,
                    0x59, 0x46,
                    0x88,
                    0xD9,
                    0xF8,
                    0xC5,
                    0x04,
                    0xDA,
                    0x73,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAuthenticate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAuthenticateEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xED, 0xD1, 0x2A,
                    0x3D, 0xD8,
                    0xB5, 0x48,
                    0x9A,
                    0xDF,
                    0x03,
                    0xDB,
                    0xE1,
                    0x9F,
                    0x53,
                    0xBD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x9F, 0x9F, 0x4F,
                    0xF4, 0xE0,
                    0xEB, 0x48,
                    0xB7,
                    0xAB,
                    0xFA,
                    0x2E,
                    0xA9,
                    0x36,
                    0x5C,
                    0xB4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0xC8, 0xB6, 0x57,
                    0xC2, 0x34,
                    0x02, 0x46,
                    0xBC,
                    0x26,
                    0x66,
                    0xA0,
                    0x2F,
                    0xC5,
                    0x71,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetFileStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0xC4, 0x34, 0xF1,
                    0xF8, 0xB1,
                    0x75, 0x4E,
                    0xB8,
                    0x86,
                    0x74,
                    0xB9,
                    0x09,
                    0x43,
                    0xBE,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWindowForBindingUI
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICodeInstall
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUri
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0xE7, 0x9E, 0xA3,
                    0x27, 0x6A,
                    0x17, 0x48,
                    0xA6,
                    0xF2,
                    0x13,
                    0x91,
                    0x4B,
                    0xEF,
                    0x58,
                    0x90
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriContainer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xA6, 0x58, 0xA1,
                    0x6F, 0xED,
                    0xFB, 0x45,
                    0xB9,
                    0x87,
                    0xF6,
                    0x86,
                    0x76,
                    0xF5,
                    0x77,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xB2, 0x21, 0x42,
                    0x55, 0x89,
                    0xC0, 0x46,
                    0xBD,
                    0x5B,
                    0xDE,
                    0x98,
                    0x97,
                    0x56,
                    0x5D,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriBuilderFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0xCE, 0x82, 0xE9,
                    0x96, 0x0B,
                    0x0C, 0x44,
                    0xBC,
                    0x37,
                    0x0C,
                    0x86,
                    0x9B,
                    0x27,
                    0xA2,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpSecurity
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetHttpInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetHttpTimeouts
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0xFA, 0x86, 0xF2,
                    0xFD, 0xC1,
                    0x70, 0x42,
                    0x8E,
                    0x67,
                    0xB3,
                    0xEB,
                    0x79,
                    0x0A,
                    0x81,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetCacheHints
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0xC3, 0x1E, 0xDD,
                    0x91, 0x83,
                    0xDB, 0x4F,
                    0xA9,
                    0xE6,
                    0x34,
                    0x7C,
                    0x3C,
                    0xAA,
                    0xA7,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetCacheHints2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xAE, 0x57, 0x78,
                    0x1F, 0xD3,
                    0xBF, 0x49,
                    0x88,
                    0x4E,
                    0xDD,
                    0x46,
                    0xDF,
                    0x36,
                    0x78,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindHost
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x01, 0x48, 0xFC,
                    0xA9, 0x2B,
                    0xCF, 0x11,
                    0xA2,
                    0x29,
                    0x00,
                    0xAA,
                    0x00,
                    0x3D,
                    0x73,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternet
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetBindInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetBindInfoEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x15, 0xE0, 0xA3,
                    0x2C, 0xA8,
                    0xCD, 0x4D,
                    0xA1,
                    0x50,
                    0x56,
                    0x9A,
                    0xEE,
                    0xED,
                    0x36,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolRoot
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x8E, 0xA9, 0xC7,
                    0x10, 0x10,
                    0x2C, 0x49,
                    0xA1,
                    0xC8,
                    0xC8,
                    0x09,
                    0xE1,
                    0xF7,
                    0x59,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolSinkStackable
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetThreadSwitch
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetPriority
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityMgrSite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xED, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManagerEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0xED, 0x64, 0xF1,
                    0x7C, 0xCC,
                    0x0D, 0x4F,
                    0x9A,
                    0x94,
                    0x34,
                    0x22,
                    0x26,
                    0x25,
                    0xC3,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManagerEx2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x02, 0xE5, 0xF1,
                    0x95, 0xA7,
                    0x17, 0x41,
                    0x8E,
                    0x09,
                    0x2B,
                    0x56,
                    0x0A,
                    0x72,
                    0xAC,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IZoneIdentifier
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xF1, 0x45, 0xCD,
                    0x21, 0x1B,
                    0xE2, 0x48,
                    0x96,
                    0x7B,
                    0xEA,
                    0xD7,
                    0x43,
                    0xA8,
                    0x91,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IZoneIdentifier2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x76, 0x5E, 0xEB,
                    0xEF, 0x09,
                    0xC0, 0x45,
                    0xB5,
                    0x10,
                    0x70,
                    0x83,
                    0x0C,
                    0xE3,
                    0x1E,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetHostSecurityManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x80, 0xF2, 0x3A,
                    0x3F, 0xCB,
                    0xD0, 0x11,
                    0x89,
                    0x1E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBF,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManagerEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x33, 0xC2, 0xA4,
                    0x06, 0x8E,
                    0x1E, 0x43,
                    0x9B,
                    0xF4,
                    0x7E,
                    0x71,
                    0x1C,
                    0x08,
                    0x56,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManagerEx2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x75, 0xC1, 0xED,
                    0x5D, 0xDD,
                    0x46, 0x48,
                    0x8E,
                    0xEF,
                    0x8B,
                    0xEC,
                    0xBA,
                    0x5A,
                    0x4A,
                    0xBF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISoftDistExt
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0x8D, 0x5B, 0xB1,
                    0xE1, 0xC7,
                    0xD0, 0x11,
                    0x86,
                    0x80,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0xCB,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICatalogFileInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x76, 0x1C, 0x71,
                    0x48, 0x6B,
                    0xD1, 0x11,
                    0xB4,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0xB9,
                    0x2A,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDataFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x4C, 0xD1, 0x69,
                    0x8E, 0xC1,
                    0xD0, 0x11,
                    0xA9,
                    0xCE,
                    0x00,
                    0x60,
                    0x97,
                    0x94,
                    0x23,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEncodingFilterFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xDE, 0xBD, 0x70,
                    0x8E, 0xC1,
                    0xD0, 0x11,
                    0xA9,
                    0xCE,
                    0x00,
                    0x60,
                    0x97,
                    0x94,
                    0x23,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWrappedProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x47, 0xC8, 0x53,
                    0x25, 0x84,
                    0xC5, 0x4D,
                    0x97,
                    0x1B,
                    0xE5,
                    0x8D,
                    0x9C,
                    0x19,
                    0xF9,
                    0xB6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGetBindHandle
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xF4, 0x0F, 0xAF,
                    0x9D, 0x12,
                    0x20, 0x4B,
                    0x91,
                    0xF0,
                    0x02,
                    0xBD,
                    0x23,
                    0xD8,
                    0x83,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindCallbackRedirect
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x1B, 0xC8, 0x11,
                    0x1E, 0x12,
                    0xD5, 0x4E,
                    0xB9,
                    0xC4,
                    0xB4,
                    0x30,
                    0xBD,
                    0x54,
                    0xF2,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindHttpSecurity
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0xA9, 0xED, 0xA9,
                    0x0E, 0xF5,
                    0x33, 0x4A,
                    0xB3,
                    0x58,
                    0x20,
                    0x6F,
                    0x6E,
                    0xF3,
                    0x08,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
