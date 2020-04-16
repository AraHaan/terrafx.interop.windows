// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WINTRUST_FILE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("LPCWSTR")]
        public ushort* pcwszFilePath;

        [NativeTypeName("HANDLE")]
        public void* hFile;

        [NativeTypeName("GUID *")]
        public _GUID* pgKnownSubject;
    }
}
