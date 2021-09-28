// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C857801-7381-11CF-884D-00AA004B2E24")]
    [NativeTypeName("struct IWbemObjectSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemObjectSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemObjectSink*, Guid*, void**, int>)(lpVtbl[0]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemObjectSink*, uint>)(lpVtbl[1]))((IWbemObjectSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemObjectSink*, uint>)(lpVtbl[2]))((IWbemObjectSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject** apObjArray)
        {
            return ((delegate* unmanaged<IWbemObjectSink*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), lObjectCount, apObjArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("long")] int lFlags, [NativeTypeName("HRESULT")] int hResult, [NativeTypeName("BSTR")] ushort* strParam, IWbemClassObject* pObjParam)
        {
            return ((delegate* unmanaged<IWbemObjectSink*, int, int, ushort*, IWbemClassObject*, int>)(lpVtbl[4]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), lFlags, hResult, strParam, pObjParam);
        }
    }
}