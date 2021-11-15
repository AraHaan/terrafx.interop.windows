// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SHCOLUMNDATA
    {
        [NativeTypeName("ULONG")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        [NativeTypeName("ULONG")]
        public uint dwReserved;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszExt;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszFile[260];
    }
}