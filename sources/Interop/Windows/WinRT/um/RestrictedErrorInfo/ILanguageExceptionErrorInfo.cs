// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("04A2DBF3-DF83-116C-0946-0812ABF6E07D")]
    [NativeTypeName("struct ILanguageExceptionErrorInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILanguageExceptionErrorInfo : ILanguageExceptionErrorInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, uint>)(lpVtbl[1]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, uint>)(lpVtbl[2]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLanguageException(IUnknown** languageException)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, IUnknown**, int>)(lpVtbl[3]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this), languageException);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetLanguageException(IUnknown** languageException);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ILanguageExceptionErrorInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILanguageExceptionErrorInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILanguageExceptionErrorInfo*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ILanguageExceptionErrorInfo*, IUnknown**, int> GetLanguageException;
        }
    }
}