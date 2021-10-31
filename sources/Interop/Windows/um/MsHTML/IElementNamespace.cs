// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F671-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementNamespace : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementNamespace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementNamespace*, Guid*, void**, int>)(lpVtbl[0]))((IElementNamespace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementNamespace*, uint>)(lpVtbl[1]))((IElementNamespace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementNamespace*, uint>)(lpVtbl[2]))((IElementNamespace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddTag([NativeTypeName("BSTR")] ushort* bstrTagName, [NativeTypeName("LONG")] int lFlags)
        {
            return ((delegate* unmanaged<IElementNamespace*, ushort*, int, int>)(lpVtbl[3]))((IElementNamespace*)Unsafe.AsPointer(ref this), bstrTagName, lFlags);
        }
    }
}
