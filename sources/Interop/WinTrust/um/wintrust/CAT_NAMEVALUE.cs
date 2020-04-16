// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CAT_NAMEVALUE
    {
        [NativeTypeName("LPWSTR")]
        public ushort* pwszTag;

        [NativeTypeName("DWORD")]
        public uint fdwFlags;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public _CRYPTOAPI_BLOB Value;
    }
}
