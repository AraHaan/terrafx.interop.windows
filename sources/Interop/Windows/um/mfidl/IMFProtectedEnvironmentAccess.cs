// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EF5DC845-F0D9-4EC9-B00C-CB5183D38434")]
    [NativeTypeName("struct IMFProtectedEnvironmentAccess : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFProtectedEnvironmentAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, Guid*, void**, int>)(lpVtbl[0]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint>)(lpVtbl[1]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint>)(lpVtbl[2]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Call([NativeTypeName("UINT32")] uint inputLength, [NativeTypeName("const BYTE *")] byte* input, [NativeTypeName("UINT32")] uint outputLength, [NativeTypeName("BYTE *")] byte* output)
        {
            return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint, byte*, uint, byte*, int>)(lpVtbl[3]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), inputLength, input, outputLength, output);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReadGRL([NativeTypeName("UINT32 *")] uint* outputLength, [NativeTypeName("BYTE **")] byte** output)
        {
            return ((delegate* unmanaged<IMFProtectedEnvironmentAccess*, uint*, byte**, int>)(lpVtbl[4]))((IMFProtectedEnvironmentAccess*)Unsafe.AsPointer(ref this), outputLength, output);
        }
    }
}
