// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CCA920E4-52F0-492B-BFA8-29C72EE0A468")]
    [NativeTypeName("struct IDWriteFontCollectionLoader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontCollectionLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontCollectionLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontCollectionLoader*, uint>)(lpVtbl[1]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontCollectionLoader*, uint>)(lpVtbl[2]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateEnumeratorFromKey(IDWriteFactory* factory, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
        {
            return ((delegate* unmanaged<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)(lpVtbl[3]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), factory, collectionKey, collectionKeySize, fontFileEnumerator);
        }
    }
}
