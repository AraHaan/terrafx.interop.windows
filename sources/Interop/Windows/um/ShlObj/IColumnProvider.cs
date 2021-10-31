// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E8025004-1C42-11D2-BE2C-00A0C9A83DA1")]
    [NativeTypeName("struct IColumnProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IColumnProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IColumnProvider*, Guid*, void**, int>)(lpVtbl[0]))((IColumnProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IColumnProvider*, uint>)(lpVtbl[1]))((IColumnProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IColumnProvider*, uint>)(lpVtbl[2]))((IColumnProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCSHCOLUMNINIT")] SHCOLUMNINIT* psci)
        {
            return ((delegate* unmanaged<IColumnProvider*, SHCOLUMNINIT*, int>)(lpVtbl[3]))((IColumnProvider*)Unsafe.AsPointer(ref this), psci);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnInfo([NativeTypeName("DWORD")] uint dwIndex, SHCOLUMNINFO* psci)
        {
            return ((delegate* unmanaged<IColumnProvider*, uint, SHCOLUMNINFO*, int>)(lpVtbl[4]))((IColumnProvider*)Unsafe.AsPointer(ref this), dwIndex, psci);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemData([NativeTypeName("LPCSHCOLUMNID")] PROPERTYKEY* pscid, [NativeTypeName("LPCSHCOLUMNDATA")] SHCOLUMNDATA* pscd, VARIANT* pvarData)
        {
            return ((delegate* unmanaged<IColumnProvider*, PROPERTYKEY*, SHCOLUMNDATA*, VARIANT*, int>)(lpVtbl[5]))((IColumnProvider*)Unsafe.AsPointer(ref this), pscid, pscd, pvarData);
        }
    }
}