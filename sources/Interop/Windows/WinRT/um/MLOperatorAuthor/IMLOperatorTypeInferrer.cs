// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMLOperatorTypeInferrer.xml' path='doc/member[@name="IMLOperatorTypeInferrer"]/*' />
[Guid("781AEB48-9BCB-4797-BF77-8BF455217BEB")]
[NativeTypeName("struct IMLOperatorTypeInferrer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorTypeInferrer : IMLOperatorTypeInferrer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorTypeInferrer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMLOperatorTypeInferrer*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMLOperatorTypeInferrer*, uint>)(lpVtbl[1]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMLOperatorTypeInferrer*, uint>)(lpVtbl[2]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTypeInferrer.xml' path='doc/member[@name="IMLOperatorTypeInferrer.InferOutputTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InferOutputTypes(IMLOperatorTypeInferenceContext* context)
    {
        return ((delegate* unmanaged[MemberFunction]<IMLOperatorTypeInferrer*, IMLOperatorTypeInferenceContext*, int>)(lpVtbl[3]))((IMLOperatorTypeInferrer*)Unsafe.AsPointer(ref this), context);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InferOutputTypes(IMLOperatorTypeInferenceContext* context);
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

        [NativeTypeName("HRESULT (IMLOperatorTypeInferenceContext *) noexcept __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMLOperatorTypeInferenceContext*, int> InferOutputTypes;
    }
}
