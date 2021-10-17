// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SFVM_PROPPAGE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("LPFNADDPROPSHEETPAGE")]
        public delegate* unmanaged<IntPtr, nint, int> pfn;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
