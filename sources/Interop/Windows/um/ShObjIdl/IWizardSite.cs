// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("88960F5B-422F-4E7B-8013-73415381C3C3")]
    [NativeTypeName("struct IWizardSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWizardSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWizardSite*, Guid*, void**, int>)(lpVtbl[0]))((IWizardSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWizardSite*, uint>)(lpVtbl[1]))((IWizardSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWizardSite*, uint>)(lpVtbl[2]))((IWizardSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPreviousPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IWizardSite*, IntPtr*, int>)(lpVtbl[3]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetNextPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IWizardSite*, IntPtr*, int>)(lpVtbl[4]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCancelledPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IWizardSite*, IntPtr*, int>)(lpVtbl[5]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
        }
    }
}
