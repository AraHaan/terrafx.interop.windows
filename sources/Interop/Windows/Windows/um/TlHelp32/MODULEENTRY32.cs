// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MODULEENTRY32
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint th32ModuleID;

        [NativeTypeName("DWORD")]
        public uint th32ProcessID;

        [NativeTypeName("DWORD")]
        public uint GlblcntUsage;

        [NativeTypeName("DWORD")]
        public uint ProccntUsage;

        public byte* modBaseAddr;

        [NativeTypeName("DWORD")]
        public uint modBaseSize;

        public HMODULE hModule;

        [NativeTypeName("char [256]")]
        public fixed sbyte szModule[256];

        [NativeTypeName("char [260]")]
        public fixed sbyte szExePath[260];
    }
}