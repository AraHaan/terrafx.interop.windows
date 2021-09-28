// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MCGRIDINFO
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwPart;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public int iCalendar;

        public int iRow;

        public int iCol;

        [NativeTypeName("BOOL")]
        public int bSelected;

        public SYSTEMTIME stStart;

        public SYSTEMTIME stEnd;

        public RECT rc;

        [NativeTypeName("PWSTR")]
        public ushort* pszName;

        [NativeTypeName("size_t")]
        public nuint cchName;
    }
}