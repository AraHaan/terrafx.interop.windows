// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54C39221-8380-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMAudioInputMixer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMAudioInputMixer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, Guid*, void**, int>)(lpVtbl[0]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, uint>)(lpVtbl[1]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, uint>)(lpVtbl[2]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT put_Enable(BOOL fEnable)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL, int>)(lpVtbl[3]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Enable(BOOL* pfEnable)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL*, int>)(lpVtbl[4]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT put_Mono(BOOL fMono)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL, int>)(lpVtbl[5]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_Mono(BOOL* pfMono)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL*, int>)(lpVtbl[6]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_MixLevel(double Level)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[7]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_MixLevel(double* pLevel)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[8]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_Pan(double Pan)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[9]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Pan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_Pan(double* pPan)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[10]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pPan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_Loudness(BOOL fLoudness)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL, int>)(lpVtbl[11]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_Loudness(BOOL* pfLoudness)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, BOOL*, int>)(lpVtbl[12]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_Treble(double Treble)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[13]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Treble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Treble(double* pTreble)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[14]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pTreble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_TrebleRange(double* pRange)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[15]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_Bass(double Bass)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[16]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Bass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_Bass(double* pBass)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[17]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pBass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_BassRange(double* pRange)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[18]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
