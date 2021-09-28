// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2E941141-7F97-4756-BA1D-9DECDE894A3D")]
    [NativeTypeName("struct IApplicationActivationManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IApplicationActivationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, uint>)(lpVtbl[1]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, uint>)(lpVtbl[2]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateApplication([NativeTypeName("LPCWSTR")] ushort* appUserModelId, [NativeTypeName("LPCWSTR")] ushort* arguments, ACTIVATEOPTIONS options, [NativeTypeName("DWORD *")] uint* processId)
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, ushort*, ACTIVATEOPTIONS, uint*, int>)(lpVtbl[3]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, arguments, options, processId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateForFile([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("LPCWSTR")] ushort* verb, [NativeTypeName("DWORD *")] uint* processId)
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, IShellItemArray*, ushort*, uint*, int>)(lpVtbl[4]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, itemArray, verb, processId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateForProtocol([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("DWORD *")] uint* processId)
        {
            return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, IShellItemArray*, uint*, int>)(lpVtbl[5]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, itemArray, processId);
        }
    }
}