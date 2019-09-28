// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct RAWHID
    {
        [NativeTypeName("DWORD")]
        public uint dwSizeHid;

        [NativeTypeName("DWORD")]
        public uint dwCount;

        [NativeTypeName("BYTE [1]")]
        public fixed byte bRawData[1];
    }
}