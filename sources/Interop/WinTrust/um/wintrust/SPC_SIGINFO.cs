// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SPC_SIGINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwSipVersion;

        [NativeTypeName("GUID")]
        public _GUID gSIPGuid;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;

        [NativeTypeName("DWORD")]
        public uint dwReserved3;

        [NativeTypeName("DWORD")]
        public uint dwReserved4;

        [NativeTypeName("DWORD")]
        public uint dwReserved5;
    }
}
