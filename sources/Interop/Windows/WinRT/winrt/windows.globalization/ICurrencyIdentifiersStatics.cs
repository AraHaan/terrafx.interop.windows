// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics"]/*' />
[Guid("9F1D091B-D586-4913-9B6A-A9BD2DC12874")]
[NativeTypeName("struct ICurrencyIdentifiersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICurrencyIdentifiersStatics : ICurrencyIdentifiersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrencyIdentifiersStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, uint>)(lpVtbl[1]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, uint>)(lpVtbl[2]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[4]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AED"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AED(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[6]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AFN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AFN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[7]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ALL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ALL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[8]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AMD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AMD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[9]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ANG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ANG(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[10]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AOA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AOA(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[11]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ARS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ARS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[12]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AUD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AUD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[13]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AWG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AWG(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[14]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_AZN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AZN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[15]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BAM"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BAM(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[16]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BBD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BBD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[17]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BDT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BDT(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[18]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BGN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BGN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[19]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BHD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_BHD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[20]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BIF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_BIF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[21]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BMD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_BMD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[22]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BND"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_BND(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[23]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BOB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_BOB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[24]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BRL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_BRL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[25]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BSD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_BSD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[26]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BTN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_BTN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[27]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BWP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_BWP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[28]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BYR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_BYR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[29]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_BZD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_BZD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[30]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CAD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_CAD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[31]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CDF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_CDF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[32]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CHF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_CHF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[33]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CLP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_CLP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[34]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CNY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_CNY(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[35]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_COP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_COP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[36]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CRC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_CRC(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[37]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CUP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_CUP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[38]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CVE"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_CVE(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[39]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_CZK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_CZK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[40]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_DJF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_DJF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[41]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_DKK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_DKK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[42]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_DOP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_DOP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[43]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_DZD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_DZD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[44]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_EGP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_EGP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[45]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ERN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_ERN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[46]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ETB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_ETB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[47]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_EUR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_EUR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[48]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_FJD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_FJD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[49]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_FKP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_FKP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[50]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GBP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_GBP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[51]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GEL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_GEL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[52]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GHS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_GHS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[53]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GIP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_GIP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[54]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GMD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_GMD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[55]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GNF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_GNF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[56]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GTQ"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_GTQ(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[57]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_GYD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_GYD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[58]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_HKD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_HKD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[59]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_HNL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_HNL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[60]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_HRK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_HRK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[61]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_HTG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_HTG(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[62]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_HUF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_HUF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[63]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_IDR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_IDR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[64]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ILS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_ILS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[65]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_INR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_INR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[66]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_IQD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_IQD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[67]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_IRR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_IRR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[68]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ISK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_ISK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[69]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_JMD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_JMD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[70]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_JOD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_JOD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[71]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_JPY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_JPY(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[72]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KES"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_KES(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[73]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KGS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_KGS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[74]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KHR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_KHR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[75]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KMF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_KMF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[76]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KPW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_KPW(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[77]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KRW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_KRW(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[78]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KWD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_KWD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[79]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KYD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_KYD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[80]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_KZT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_KZT(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[81]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LAK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_LAK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[82]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LBP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_LBP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[83]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LKR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_LKR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[84]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LRD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_LRD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[85]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LSL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_LSL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[86]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LTL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_LTL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[87]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LVL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_LVL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[88]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_LYD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_LYD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[89]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MAD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_MAD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[90]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MDL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_MDL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[91]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MGA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_MGA(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[92]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MKD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_MKD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[93]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MMK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_MMK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[94]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MNT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_MNT(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[95]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MOP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_MOP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[96]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MRO"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_MRO(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[97]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MUR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_MUR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[98]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MVR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_MVR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[99]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MWK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_MWK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[100]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MXN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_MXN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[101]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MYR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_MYR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[102]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_MZN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_MZN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[103]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NAD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_NAD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[104]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NGN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_NGN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[105]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NIO"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_NIO(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[106]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NOK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_NOK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[107]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NPR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_NPR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[108]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_NZD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_NZD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[109]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_OMR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_OMR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[110]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PAB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_PAB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[111]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PEN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_PEN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[112]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PGK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_PGK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[113]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PHP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_PHP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[114]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PKR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_PKR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[115]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PLN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_PLN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[116]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_PYG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_PYG(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[117]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_QAR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_QAR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[118]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_RON"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_RON(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[119]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_RSD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_RSD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[120]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_RUB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_RUB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[121]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_RWF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_RWF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[122]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SAR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_SAR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[123]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SBD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_SBD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[124]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SCR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_SCR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[125]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SDG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_SDG(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[126]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SEK"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT get_SEK(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[127]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SGD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_SGD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[128]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SHP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT get_SHP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[129]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SLL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_SLL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[130]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SOS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT get_SOS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[131]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SRD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_SRD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[132]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_STD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT get_STD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[133]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SYP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_SYP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[134]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_SZL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT get_SZL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[135]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_THB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_THB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[136]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TJS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT get_TJS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[137]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TMT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_TMT(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[138]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TND"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT get_TND(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[139]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TOP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_TOP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[140]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TRY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT get_TRY(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[141]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TTD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_TTD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[142]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TWD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT get_TWD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[143]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_TZS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_TZS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[144]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_UAH"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT get_UAH(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[145]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_UGX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_UGX(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[146]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_USD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(147)]
    public HRESULT get_USD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[147]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_UYU"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(148)]
    public HRESULT get_UYU(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[148]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_UZS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(149)]
    public HRESULT get_UZS(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[149]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_VEF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(150)]
    public HRESULT get_VEF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[150]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_VND"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(151)]
    public HRESULT get_VND(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[151]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_VUV"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(152)]
    public HRESULT get_VUV(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[152]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_WST"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(153)]
    public HRESULT get_WST(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[153]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_XAF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(154)]
    public HRESULT get_XAF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[154]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_XCD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(155)]
    public HRESULT get_XCD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[155]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_XOF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(156)]
    public HRESULT get_XOF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[156]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_XPF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(157)]
    public HRESULT get_XPF(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[157]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_XXX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(158)]
    public HRESULT get_XXX(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[158]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_YER"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(159)]
    public HRESULT get_YER(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[159]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ZAR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(160)]
    public HRESULT get_ZAR(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[160]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ZMW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(161)]
    public HRESULT get_ZMW(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[161]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics.xml' path='doc/member[@name="ICurrencyIdentifiersStatics.get_ZWL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(162)]
    public HRESULT get_ZWL(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics*, HSTRING*, int>)(lpVtbl[162]))((ICurrencyIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AED(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AFN(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ALL(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_AMD(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ANG(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_AOA(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_ARS(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_AUD(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_AWG(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_AZN(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_BAM(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_BBD(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_BDT(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_BGN(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_BHD(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_BIF(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_BMD(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_BND(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_BOB(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_BRL(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_BSD(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_BTN(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_BWP(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_BYR(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_BZD(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_CAD(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_CDF(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_CHF(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_CLP(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_CNY(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_COP(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_CRC(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_CUP(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_CVE(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_CZK(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_DJF(HSTRING* value);

        [VtblIndex(42)]
        HRESULT get_DKK(HSTRING* value);

        [VtblIndex(43)]
        HRESULT get_DOP(HSTRING* value);

        [VtblIndex(44)]
        HRESULT get_DZD(HSTRING* value);

        [VtblIndex(45)]
        HRESULT get_EGP(HSTRING* value);

        [VtblIndex(46)]
        HRESULT get_ERN(HSTRING* value);

        [VtblIndex(47)]
        HRESULT get_ETB(HSTRING* value);

        [VtblIndex(48)]
        HRESULT get_EUR(HSTRING* value);

        [VtblIndex(49)]
        HRESULT get_FJD(HSTRING* value);

        [VtblIndex(50)]
        HRESULT get_FKP(HSTRING* value);

        [VtblIndex(51)]
        HRESULT get_GBP(HSTRING* value);

        [VtblIndex(52)]
        HRESULT get_GEL(HSTRING* value);

        [VtblIndex(53)]
        HRESULT get_GHS(HSTRING* value);

        [VtblIndex(54)]
        HRESULT get_GIP(HSTRING* value);

        [VtblIndex(55)]
        HRESULT get_GMD(HSTRING* value);

        [VtblIndex(56)]
        HRESULT get_GNF(HSTRING* value);

        [VtblIndex(57)]
        HRESULT get_GTQ(HSTRING* value);

        [VtblIndex(58)]
        HRESULT get_GYD(HSTRING* value);

        [VtblIndex(59)]
        HRESULT get_HKD(HSTRING* value);

        [VtblIndex(60)]
        HRESULT get_HNL(HSTRING* value);

        [VtblIndex(61)]
        HRESULT get_HRK(HSTRING* value);

        [VtblIndex(62)]
        HRESULT get_HTG(HSTRING* value);

        [VtblIndex(63)]
        HRESULT get_HUF(HSTRING* value);

        [VtblIndex(64)]
        HRESULT get_IDR(HSTRING* value);

        [VtblIndex(65)]
        HRESULT get_ILS(HSTRING* value);

        [VtblIndex(66)]
        HRESULT get_INR(HSTRING* value);

        [VtblIndex(67)]
        HRESULT get_IQD(HSTRING* value);

        [VtblIndex(68)]
        HRESULT get_IRR(HSTRING* value);

        [VtblIndex(69)]
        HRESULT get_ISK(HSTRING* value);

        [VtblIndex(70)]
        HRESULT get_JMD(HSTRING* value);

        [VtblIndex(71)]
        HRESULT get_JOD(HSTRING* value);

        [VtblIndex(72)]
        HRESULT get_JPY(HSTRING* value);

        [VtblIndex(73)]
        HRESULT get_KES(HSTRING* value);

        [VtblIndex(74)]
        HRESULT get_KGS(HSTRING* value);

        [VtblIndex(75)]
        HRESULT get_KHR(HSTRING* value);

        [VtblIndex(76)]
        HRESULT get_KMF(HSTRING* value);

        [VtblIndex(77)]
        HRESULT get_KPW(HSTRING* value);

        [VtblIndex(78)]
        HRESULT get_KRW(HSTRING* value);

        [VtblIndex(79)]
        HRESULT get_KWD(HSTRING* value);

        [VtblIndex(80)]
        HRESULT get_KYD(HSTRING* value);

        [VtblIndex(81)]
        HRESULT get_KZT(HSTRING* value);

        [VtblIndex(82)]
        HRESULT get_LAK(HSTRING* value);

        [VtblIndex(83)]
        HRESULT get_LBP(HSTRING* value);

        [VtblIndex(84)]
        HRESULT get_LKR(HSTRING* value);

        [VtblIndex(85)]
        HRESULT get_LRD(HSTRING* value);

        [VtblIndex(86)]
        HRESULT get_LSL(HSTRING* value);

        [VtblIndex(87)]
        HRESULT get_LTL(HSTRING* value);

        [VtblIndex(88)]
        HRESULT get_LVL(HSTRING* value);

        [VtblIndex(89)]
        HRESULT get_LYD(HSTRING* value);

        [VtblIndex(90)]
        HRESULT get_MAD(HSTRING* value);

        [VtblIndex(91)]
        HRESULT get_MDL(HSTRING* value);

        [VtblIndex(92)]
        HRESULT get_MGA(HSTRING* value);

        [VtblIndex(93)]
        HRESULT get_MKD(HSTRING* value);

        [VtblIndex(94)]
        HRESULT get_MMK(HSTRING* value);

        [VtblIndex(95)]
        HRESULT get_MNT(HSTRING* value);

        [VtblIndex(96)]
        HRESULT get_MOP(HSTRING* value);

        [VtblIndex(97)]
        HRESULT get_MRO(HSTRING* value);

        [VtblIndex(98)]
        HRESULT get_MUR(HSTRING* value);

        [VtblIndex(99)]
        HRESULT get_MVR(HSTRING* value);

        [VtblIndex(100)]
        HRESULT get_MWK(HSTRING* value);

        [VtblIndex(101)]
        HRESULT get_MXN(HSTRING* value);

        [VtblIndex(102)]
        HRESULT get_MYR(HSTRING* value);

        [VtblIndex(103)]
        HRESULT get_MZN(HSTRING* value);

        [VtblIndex(104)]
        HRESULT get_NAD(HSTRING* value);

        [VtblIndex(105)]
        HRESULT get_NGN(HSTRING* value);

        [VtblIndex(106)]
        HRESULT get_NIO(HSTRING* value);

        [VtblIndex(107)]
        HRESULT get_NOK(HSTRING* value);

        [VtblIndex(108)]
        HRESULT get_NPR(HSTRING* value);

        [VtblIndex(109)]
        HRESULT get_NZD(HSTRING* value);

        [VtblIndex(110)]
        HRESULT get_OMR(HSTRING* value);

        [VtblIndex(111)]
        HRESULT get_PAB(HSTRING* value);

        [VtblIndex(112)]
        HRESULT get_PEN(HSTRING* value);

        [VtblIndex(113)]
        HRESULT get_PGK(HSTRING* value);

        [VtblIndex(114)]
        HRESULT get_PHP(HSTRING* value);

        [VtblIndex(115)]
        HRESULT get_PKR(HSTRING* value);

        [VtblIndex(116)]
        HRESULT get_PLN(HSTRING* value);

        [VtblIndex(117)]
        HRESULT get_PYG(HSTRING* value);

        [VtblIndex(118)]
        HRESULT get_QAR(HSTRING* value);

        [VtblIndex(119)]
        HRESULT get_RON(HSTRING* value);

        [VtblIndex(120)]
        HRESULT get_RSD(HSTRING* value);

        [VtblIndex(121)]
        HRESULT get_RUB(HSTRING* value);

        [VtblIndex(122)]
        HRESULT get_RWF(HSTRING* value);

        [VtblIndex(123)]
        HRESULT get_SAR(HSTRING* value);

        [VtblIndex(124)]
        HRESULT get_SBD(HSTRING* value);

        [VtblIndex(125)]
        HRESULT get_SCR(HSTRING* value);

        [VtblIndex(126)]
        HRESULT get_SDG(HSTRING* value);

        [VtblIndex(127)]
        HRESULT get_SEK(HSTRING* value);

        [VtblIndex(128)]
        HRESULT get_SGD(HSTRING* value);

        [VtblIndex(129)]
        HRESULT get_SHP(HSTRING* value);

        [VtblIndex(130)]
        HRESULT get_SLL(HSTRING* value);

        [VtblIndex(131)]
        HRESULT get_SOS(HSTRING* value);

        [VtblIndex(132)]
        HRESULT get_SRD(HSTRING* value);

        [VtblIndex(133)]
        HRESULT get_STD(HSTRING* value);

        [VtblIndex(134)]
        HRESULT get_SYP(HSTRING* value);

        [VtblIndex(135)]
        HRESULT get_SZL(HSTRING* value);

        [VtblIndex(136)]
        HRESULT get_THB(HSTRING* value);

        [VtblIndex(137)]
        HRESULT get_TJS(HSTRING* value);

        [VtblIndex(138)]
        HRESULT get_TMT(HSTRING* value);

        [VtblIndex(139)]
        HRESULT get_TND(HSTRING* value);

        [VtblIndex(140)]
        HRESULT get_TOP(HSTRING* value);

        [VtblIndex(141)]
        HRESULT get_TRY(HSTRING* value);

        [VtblIndex(142)]
        HRESULT get_TTD(HSTRING* value);

        [VtblIndex(143)]
        HRESULT get_TWD(HSTRING* value);

        [VtblIndex(144)]
        HRESULT get_TZS(HSTRING* value);

        [VtblIndex(145)]
        HRESULT get_UAH(HSTRING* value);

        [VtblIndex(146)]
        HRESULT get_UGX(HSTRING* value);

        [VtblIndex(147)]
        HRESULT get_USD(HSTRING* value);

        [VtblIndex(148)]
        HRESULT get_UYU(HSTRING* value);

        [VtblIndex(149)]
        HRESULT get_UZS(HSTRING* value);

        [VtblIndex(150)]
        HRESULT get_VEF(HSTRING* value);

        [VtblIndex(151)]
        HRESULT get_VND(HSTRING* value);

        [VtblIndex(152)]
        HRESULT get_VUV(HSTRING* value);

        [VtblIndex(153)]
        HRESULT get_WST(HSTRING* value);

        [VtblIndex(154)]
        HRESULT get_XAF(HSTRING* value);

        [VtblIndex(155)]
        HRESULT get_XCD(HSTRING* value);

        [VtblIndex(156)]
        HRESULT get_XOF(HSTRING* value);

        [VtblIndex(157)]
        HRESULT get_XPF(HSTRING* value);

        [VtblIndex(158)]
        HRESULT get_XXX(HSTRING* value);

        [VtblIndex(159)]
        HRESULT get_YER(HSTRING* value);

        [VtblIndex(160)]
        HRESULT get_ZAR(HSTRING* value);

        [VtblIndex(161)]
        HRESULT get_ZMW(HSTRING* value);

        [VtblIndex(162)]
        HRESULT get_ZWL(HSTRING* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AED;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AFN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ALL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AMD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ANG;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AOA;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ARS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AUD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AWG;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AZN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BAM;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BBD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BDT;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BGN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BHD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BIF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BMD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BND;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BOB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BRL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BSD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BTN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BWP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BYR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BZD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CAD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CDF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CHF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CLP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CNY;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_COP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CRC;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CUP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CVE;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CZK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DJF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DKK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DOP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DZD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EGP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ERN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ETB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EUR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FJD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FKP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GBP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GEL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GHS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GIP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GMD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GNF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GTQ;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_GYD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HKD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HNL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HRK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HTG;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HUF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IDR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ILS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_INR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IQD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IRR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ISK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_JMD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_JOD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_JPY;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KES;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KGS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KHR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KMF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KPW;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KRW;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KWD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KYD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KZT;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LAK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LBP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LKR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LRD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LSL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LTL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LVL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LYD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MAD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MDL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MGA;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MKD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MMK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MNT;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MOP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MRO;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MUR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MVR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MWK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MXN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MYR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MZN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NAD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NGN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NIO;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NOK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NPR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NZD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_OMR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PAB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PEN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PGK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PHP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PKR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PLN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PYG;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QAR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RON;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RSD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RUB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RWF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SAR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SBD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SCR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SDG;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SEK;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SGD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SHP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SLL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SOS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SRD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_STD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SYP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SZL;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_THB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TJS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TMT;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TND;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TOP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TRY;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TTD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TWD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TZS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UAH;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UGX;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_USD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UYU;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UZS;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VEF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VND;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VUV;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_WST;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XAF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XCD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XOF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XPF;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XXX;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_YER;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZAR;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZMW;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZWL;
    }
}
