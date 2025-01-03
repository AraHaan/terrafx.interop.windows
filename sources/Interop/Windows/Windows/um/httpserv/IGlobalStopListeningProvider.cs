// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalStopListeningProvider.xml' path='doc/member[@name="IGlobalStopListeningProvider"]/*' />
[Guid("41F9A601-E25D-4AC8-8A1F-635698A30AB9")]
[NativeTypeName("struct IGlobalStopListeningProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalStopListeningProvider : IGlobalStopListeningProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalStopListeningProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalStopListeningProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalStopListeningProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalStopListeningProvider.xml' path='doc/member[@name="IGlobalStopListeningProvider.DrainRequestsGracefully"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public BOOL DrainRequestsGracefully()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalStopListeningProvider*, int>)(lpVtbl[1]))((IGlobalStopListeningProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        BOOL DrainRequestsGracefully();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DrainRequestsGracefully;
    }
}
