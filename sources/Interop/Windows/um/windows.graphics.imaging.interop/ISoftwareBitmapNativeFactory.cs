// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3C181EC-2914-4791-AF02-02D224A10B43")]
    [NativeTypeName("struct ISoftwareBitmapNativeFactory : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ISoftwareBitmapNativeFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint>)(lpVtbl[1]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint>)(lpVtbl[2]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, IntPtr*, int>)(lpVtbl[4]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateFromWICBitmap(IWICBitmap* data, BOOL forceReadOnly, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, IWICBitmap*, BOOL, Guid*, void**, int>)(lpVtbl[6]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), data, forceReadOnly, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateFromMF2DBuffer2(IMF2DBuffer2* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, BOOL forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, IMF2DBuffer2*, Guid*, uint, uint, BOOL, MFVideoArea*, Guid*, void**, int>)(lpVtbl[7]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), data, subtype, width, height, forceReadOnly, minDisplayAperture, riid, ppv);
        }
    }
}
