// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_REGISTER_CONTROL_STATUS64A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCSTR")]
        public sbyte* FileName;

        [NativeTypeName("DWORD")]
        public uint Win32Error;

        [NativeTypeName("DWORD")]
        public uint FailureCode;
    }
}