// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F185FE76-E64E-11D2-B76E-00C04FB6BD3D")]
    [NativeTypeName("struct IAMPushSource : IAMLatency")]
    [NativeInheritance("IAMLatency")]
    public unsafe partial struct IAMPushSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMPushSource*, Guid*, void**, int>)(lpVtbl[0]))((IAMPushSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMPushSource*, uint>)(lpVtbl[1]))((IAMPushSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMPushSource*, uint>)(lpVtbl[2]))((IAMPushSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
        {
            return ((delegate* unmanaged<IAMPushSource*, long*, int>)(lpVtbl[3]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IAMPushSource*, uint*, int>)(lpVtbl[4]))((IAMPushSource*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags)
        {
            return ((delegate* unmanaged<IAMPushSource*, uint, int>)(lpVtbl[5]))((IAMPushSource*)Unsafe.AsPointer(ref this), Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset)
        {
            return ((delegate* unmanaged<IAMPushSource*, long, int>)(lpVtbl[6]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset)
        {
            return ((delegate* unmanaged<IAMPushSource*, long*, int>)(lpVtbl[7]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset)
        {
            return ((delegate* unmanaged<IAMPushSource*, long*, int>)(lpVtbl[8]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtMaxOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset)
        {
            return ((delegate* unmanaged<IAMPushSource*, long, int>)(lpVtbl[9]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtMaxOffset);
        }
    }
}
