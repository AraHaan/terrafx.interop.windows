// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("3D8B0590-F691-11D2-8EA9-006097DF5BD4")]
    [NativeTypeName("struct IDataObjectAsyncCapability : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataObjectAsyncCapability : IDataObjectAsyncCapability.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, Guid*, void**, int>)(lpVtbl[0]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, uint>)(lpVtbl[1]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, uint>)(lpVtbl[2]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAsyncMode(BOOL fDoOpAsync)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL, int>)(lpVtbl[3]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), fDoOpAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAsyncMode(BOOL* pfIsOpAsync)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int>)(lpVtbl[4]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pfIsOpAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT StartOperation(IBindCtx* pbcReserved)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, IBindCtx*, int>)(lpVtbl[5]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pbcReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT InOperation(BOOL* pfInAsyncOp)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int>)(lpVtbl[6]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pfInAsyncOp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EndOperation(HRESULT hResult, IBindCtx* pbcReserved, [NativeTypeName("DWORD")] uint dwEffects)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, HRESULT, IBindCtx*, uint, int>)(lpVtbl[7]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), hResult, pbcReserved, dwEffects);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAsyncMode(BOOL fDoOpAsync);

            [VtblIndex(4)]
            HRESULT GetAsyncMode(BOOL* pfIsOpAsync);

            [VtblIndex(5)]
            HRESULT StartOperation(IBindCtx* pbcReserved);

            [VtblIndex(6)]
            HRESULT InOperation(BOOL* pfInAsyncOp);

            [VtblIndex(7)]
            HRESULT EndOperation(HRESULT hResult, IBindCtx* pbcReserved, [NativeTypeName("DWORD")] uint dwEffects);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, uint> Release;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, BOOL, int> SetAsyncMode;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int> GetAsyncMode;

            [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, IBindCtx*, int> StartOperation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int> InOperation;

            [NativeTypeName("HRESULT (HRESULT, IBindCtx *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataObjectAsyncCapability*, HRESULT, IBindCtx*, uint, int> EndOperation;
        }
    }
}