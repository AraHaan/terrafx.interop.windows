// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_IPADDRROW_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("DWORD")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwBCastAddr;

        [NativeTypeName("DWORD")]
        public uint dwReasmSize;

        [NativeTypeName("unsigned short")]
        public ushort unused1;

        [NativeTypeName("unsigned short")]
        public ushort unused2;
    }
}