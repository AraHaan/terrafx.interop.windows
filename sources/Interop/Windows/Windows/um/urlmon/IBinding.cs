// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IBinding.xml' path='doc/member[@name="IBinding"]/*' />
[Guid("79EAC9C0-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IBinding : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBinding : IBinding.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBinding));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, Guid*, void**, int>)(lpVtbl[0]))((IBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, uint>)(lpVtbl[1]))((IBinding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, uint>)(lpVtbl[2]))((IBinding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.Abort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, int>)(lpVtbl[3]))((IBinding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.Suspend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, int>)(lpVtbl[4]))((IBinding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, int>)(lpVtbl[5]))((IBinding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.SetPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPriority([NativeTypeName("LONG")] int nPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, int, int>)(lpVtbl[6]))((IBinding*)Unsafe.AsPointer(ref this), nPriority);
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.GetPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, int*, int>)(lpVtbl[7]))((IBinding*)Unsafe.AsPointer(ref this), pnPriority);
    }

    /// <include file='IBinding.xml' path='doc/member[@name="IBinding.GetBindResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] char** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IBinding*, Guid*, uint*, char**, uint*, int>)(lpVtbl[8]))((IBinding*)Unsafe.AsPointer(ref this), pclsidProtocol, pdwResult, pszResult, pdwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Abort();

        [VtblIndex(4)]
        HRESULT Suspend();

        [VtblIndex(5)]
        HRESULT Resume();

        [VtblIndex(6)]
        HRESULT SetPriority([NativeTypeName("LONG")] int nPriority);

        [VtblIndex(7)]
        HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority);

        [VtblIndex(8)]
        HRESULT GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] char** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Abort;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Suspend;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> SetPriority;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;

        [NativeTypeName("HRESULT (CLSID *, DWORD *, LPOLESTR *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, char**, uint*, int> GetBindResult;
    }
}
