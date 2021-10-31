// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEB5A271-A6CD-45CE-880A-696706BADC65")]
    [NativeTypeName("struct ILanguageExceptionTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILanguageExceptionTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILanguageExceptionTransform*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILanguageExceptionTransform*, uint>)(lpVtbl[1]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILanguageExceptionTransform*, uint>)(lpVtbl[2]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTransformedRestrictedErrorInfo(IRestrictedErrorInfo** restrictedErrorInfo)
        {
            return ((delegate* unmanaged<ILanguageExceptionTransform*, IRestrictedErrorInfo**, int>)(lpVtbl[3]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this), restrictedErrorInfo);
        }
    }
}
