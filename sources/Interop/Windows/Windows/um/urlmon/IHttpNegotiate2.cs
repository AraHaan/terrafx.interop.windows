// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpNegotiate2.xml' path='doc/member[@name="IHttpNegotiate2"]/*' />
[Guid("4F9F9FCB-E0F4-48EB-B7AB-FA2EA9365CB4")]
[NativeTypeName("struct IHttpNegotiate2 : IHttpNegotiate")]
[NativeInheritance("IHttpNegotiate")]
public unsafe partial struct IHttpNegotiate2 : IHttpNegotiate2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, Guid*, void**, int>)(lpVtbl[0]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, uint>)(lpVtbl[1]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, uint>)(lpVtbl[2]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpNegotiate.BeginningTransaction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginningTransaction([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPCWSTR")] char* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] char** pszAdditionalHeaders)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, char*, char*, uint, char**, int>)(lpVtbl[3]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
    }

    /// <inheritdoc cref="IHttpNegotiate.OnResponse" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] char* szResponseHeaders, [NativeTypeName("LPCWSTR")] char* szRequestHeaders, [NativeTypeName("LPWSTR *")] char** pszAdditionalRequestHeaders)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, uint, char*, char*, char**, int>)(lpVtbl[4]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
    }

    /// <include file='IHttpNegotiate2.xml' path='doc/member[@name="IHttpNegotiate2.GetRootSecurityId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpNegotiate2*, byte*, uint*, nuint, int>)(lpVtbl[5]))((IHttpNegotiate2*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
    }

    public interface Interface : IHttpNegotiate.Interface
    {
        [VtblIndex(5)]
        HRESULT GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char**, int> BeginningTransaction;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, char**, int> OnResponse;

        [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, nuint, int> GetRootSecurityId;
    }
}
