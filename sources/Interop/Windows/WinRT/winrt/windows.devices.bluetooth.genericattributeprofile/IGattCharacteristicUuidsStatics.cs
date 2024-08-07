// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics"]/*' />
[Guid("58FA4586-B1DE-470C-B7DE-0D11FF44F4B7")]
[NativeTypeName("struct IGattCharacteristicUuidsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicUuidsStatics : IGattCharacteristicUuidsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattCharacteristicUuidsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, uint>)(lpVtbl[1]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, uint>)(lpVtbl[2]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_BatteryLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BatteryLevel(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[6]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_BloodPressureFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BloodPressureFeature(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[7]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_BloodPressureMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BloodPressureMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[8]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_BodySensorLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BodySensorLocation(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[9]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_CscFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CscFeature(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[10]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_CscMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CscMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[11]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_GlucoseFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_GlucoseFeature(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[12]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_GlucoseMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GlucoseMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[13]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_GlucoseMeasurementContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_GlucoseMeasurementContext(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[14]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_HeartRateControlPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_HeartRateControlPoint(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[15]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_HeartRateMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_HeartRateMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[16]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_IntermediateCuffPressure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IntermediateCuffPressure(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[17]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_IntermediateTemperature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IntermediateTemperature(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[18]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_MeasurementInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MeasurementInterval(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[19]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_RecordAccessControlPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RecordAccessControlPoint(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[20]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_RscFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RscFeature(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[21]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_RscMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_RscMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[22]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_SCControlPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SCControlPoint(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[23]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_SensorLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_SensorLocation(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[24]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_TemperatureMeasurement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_TemperatureMeasurement(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[25]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristicUuidsStatics.xml' path='doc/member[@name="IGattCharacteristicUuidsStatics.get_TemperatureType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_TemperatureType(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicUuidsStatics*, Guid*, int>)(lpVtbl[26]))((IGattCharacteristicUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BatteryLevel(Guid* value);

        [VtblIndex(7)]
        HRESULT get_BloodPressureFeature(Guid* value);

        [VtblIndex(8)]
        HRESULT get_BloodPressureMeasurement(Guid* value);

        [VtblIndex(9)]
        HRESULT get_BodySensorLocation(Guid* value);

        [VtblIndex(10)]
        HRESULT get_CscFeature(Guid* value);

        [VtblIndex(11)]
        HRESULT get_CscMeasurement(Guid* value);

        [VtblIndex(12)]
        HRESULT get_GlucoseFeature(Guid* value);

        [VtblIndex(13)]
        HRESULT get_GlucoseMeasurement(Guid* value);

        [VtblIndex(14)]
        HRESULT get_GlucoseMeasurementContext(Guid* value);

        [VtblIndex(15)]
        HRESULT get_HeartRateControlPoint(Guid* value);

        [VtblIndex(16)]
        HRESULT get_HeartRateMeasurement(Guid* value);

        [VtblIndex(17)]
        HRESULT get_IntermediateCuffPressure(Guid* value);

        [VtblIndex(18)]
        HRESULT get_IntermediateTemperature(Guid* value);

        [VtblIndex(19)]
        HRESULT get_MeasurementInterval(Guid* value);

        [VtblIndex(20)]
        HRESULT get_RecordAccessControlPoint(Guid* value);

        [VtblIndex(21)]
        HRESULT get_RscFeature(Guid* value);

        [VtblIndex(22)]
        HRESULT get_RscMeasurement(Guid* value);

        [VtblIndex(23)]
        HRESULT get_SCControlPoint(Guid* value);

        [VtblIndex(24)]
        HRESULT get_SensorLocation(Guid* value);

        [VtblIndex(25)]
        HRESULT get_TemperatureMeasurement(Guid* value);

        [VtblIndex(26)]
        HRESULT get_TemperatureType(Guid* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BatteryLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BloodPressureFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BloodPressureMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BodySensorLocation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CscFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CscMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GlucoseFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GlucoseMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GlucoseMeasurementContext;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_HeartRateControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_HeartRateMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_IntermediateCuffPressure;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_IntermediateTemperature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_MeasurementInterval;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_RecordAccessControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_RscFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_RscMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_SCControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_SensorLocation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TemperatureMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TemperatureType;
    }
}
