// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("C62D9C91-7458-47F6-862D-1EF86FB0B278")]
    [NativeTypeName("struct ISpeechAudioStatus : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechAudioStatus : ISpeechAudioStatus.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, uint>)(lpVtbl[1]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, uint>)(lpVtbl[2]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, uint*, int>)(lpVtbl[3]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_FreeBufferSpace([NativeTypeName("long *")] int* FreeBufferSpace)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, int*, int>)(lpVtbl[7]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), FreeBufferSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_NonBlockingIO([NativeTypeName("long *")] int* NonBlockingIO)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, int*, int>)(lpVtbl[8]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), NonBlockingIO);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_State(SpeechAudioState* State)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, SpeechAudioState*, int>)(lpVtbl[9]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_CurrentSeekPosition(VARIANT* CurrentSeekPosition)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, VARIANT*, int>)(lpVtbl[10]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), CurrentSeekPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_CurrentDevicePosition(VARIANT* CurrentDevicePosition)
        {
            return ((delegate* unmanaged<ISpeechAudioStatus*, VARIANT*, int>)(lpVtbl[11]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), CurrentDevicePosition);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_FreeBufferSpace([NativeTypeName("long *")] int* FreeBufferSpace);

            [VtblIndex(8)]
            HRESULT get_NonBlockingIO([NativeTypeName("long *")] int* NonBlockingIO);

            [VtblIndex(9)]
            HRESULT get_State(SpeechAudioState* State);

            [VtblIndex(10)]
            HRESULT get_CurrentSeekPosition(VARIANT* CurrentSeekPosition);

            [VtblIndex(11)]
            HRESULT get_CurrentDevicePosition(VARIANT* CurrentDevicePosition);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, int*, int> get_FreeBufferSpace;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, int*, int> get_NonBlockingIO;

            [NativeTypeName("HRESULT (SpeechAudioState *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, SpeechAudioState*, int> get_State;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, VARIANT*, int> get_CurrentSeekPosition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechAudioStatus*, VARIANT*, int> get_CurrentDevicePosition;
        }
    }
}