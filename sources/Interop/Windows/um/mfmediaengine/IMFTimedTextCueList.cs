// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD128745-211B-40A0-9981-FE65F166D0FD")]
    [NativeTypeName("struct IMFTimedTextCueList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextCueList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[1]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[2]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[3]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCueByIndex([NativeTypeName("DWORD")] uint index, IMFTimedTextCue** cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[4]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), index, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCueById([NativeTypeName("DWORD")] uint id, IMFTimedTextCue** cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[5]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), id, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCueByOriginalId([NativeTypeName("LPCWSTR")] ushort* originalId, IMFTimedTextCue** cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, ushort*, IMFTimedTextCue**, int>)(lpVtbl[6]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), originalId, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddTextCue(double start, double duration, [NativeTypeName("LPCWSTR")] ushort* text, IMFTimedTextCue** cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, double, double, ushort*, IMFTimedTextCue**, int>)(lpVtbl[7]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, text, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddDataCue(double start, double duration, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("DWORD")] uint dataSize, IMFTimedTextCue** cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)(lpVtbl[8]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, data, dataSize, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RemoveCue(IMFTimedTextCue* cue)
        {
            return ((delegate* unmanaged<IMFTimedTextCueList*, IMFTimedTextCue*, int>)(lpVtbl[9]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), cue);
        }
    }
}
