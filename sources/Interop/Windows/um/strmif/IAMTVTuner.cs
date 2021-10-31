// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("211A8766-03AC-11D1-8D13-00AA00BD8339")]
    [NativeTypeName("struct IAMTVTuner : IAMTuner")]
    [NativeInheritance("IAMTuner")]
    public unsafe partial struct IAMTVTuner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTVTuner*, Guid*, void**, int>)(lpVtbl[0]))((IAMTVTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTVTuner*, uint>)(lpVtbl[1]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTVTuner*, uint>)(lpVtbl[2]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, int, int, int>)(lpVtbl[3]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int*, int>)(lpVtbl[5]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[6]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[7]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[8]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[9]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Logon([NativeTypeName("HANDLE")] IntPtr hCurrentUser)
        {
            return ((delegate* unmanaged<IAMTVTuner*, IntPtr, int>)(lpVtbl[10]))((IAMTVTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Logout()
        {
            return ((delegate* unmanaged<IAMTVTuner*, int>)(lpVtbl[11]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[12]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_Mode(AMTunerModeType lMode)
        {
            return ((delegate* unmanaged<IAMTVTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Mode(AMTunerModeType* plMode)
        {
            return ((delegate* unmanaged<IAMTVTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[15]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
        {
            return ((delegate* unmanaged<IAMTVTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IAMTVTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify)
        {
            return ((delegate* unmanaged<IAMTVTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IAMTVTuner*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[18]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[19]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT AutoTune([NativeTypeName("long")] int lChannel, [NativeTypeName("long *")] int* plFoundSignal)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, int*, int>)(lpVtbl[20]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannel, plFoundSignal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT StoreAutoTune()
        {
            return ((delegate* unmanaged<IAMTVTuner*, int>)(lpVtbl[21]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_NumInputConnections([NativeTypeName("long *")] int* plNumInputConnections)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[22]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plNumInputConnections);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_InputType([NativeTypeName("long")] int lIndex, TunerInputType InputType)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, TunerInputType, int>)(lpVtbl[23]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex, InputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_InputType([NativeTypeName("long")] int lIndex, TunerInputType* pInputType)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, TunerInputType*, int>)(lpVtbl[24]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex, pInputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_ConnectInput([NativeTypeName("long")] int lIndex)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[25]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_ConnectInput([NativeTypeName("long *")] int* plIndex)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[26]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_VideoFrequency([NativeTypeName("long *")] int* lFreq)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[27]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lFreq);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_AudioFrequency([NativeTypeName("long *")] int* lFreq)
        {
            return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[28]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lFreq);
        }
    }
}
