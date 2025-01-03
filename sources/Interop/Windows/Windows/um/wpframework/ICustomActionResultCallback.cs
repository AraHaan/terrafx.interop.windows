// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ICustomActionResultCallback.xml' path='doc/member[@name="ICustomActionResultCallback"]/*' />
[NativeTypeName("struct ICustomActionResultCallback : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct ICustomActionResultCallback : ICustomActionResultCallback.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IWpfReferencedObject.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomActionResultCallback*, uint>)(lpVtbl[0]))((ICustomActionResultCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWpfReferencedObject.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomActionResultCallback*, uint>)(lpVtbl[1]))((ICustomActionResultCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICustomActionResultCallback.xml' path='doc/member[@name="ICustomActionResultCallback.ReportResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ReportResult(HRESULT hrStatus, [NativeTypeName("PBYTE")] byte* pbResponse, [NativeTypeName("DWORD")] uint cbResponse)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomActionResultCallback*, HRESULT, byte*, uint, int>)(lpVtbl[2]))((ICustomActionResultCallback*)Unsafe.AsPointer(ref this), hrStatus, pbResponse, cbResponse);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT ReportResult(HRESULT hrStatus, [NativeTypeName("PBYTE")] byte* pbResponse, [NativeTypeName("DWORD")] uint cbResponse);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT, PBYTE, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, byte*, uint, int> ReportResult;
    }
}
