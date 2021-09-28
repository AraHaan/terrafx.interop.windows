// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NSTCCUSTOMDRAW
    {
        public IShellItem* psi;

        [NativeTypeName("UINT")]
        public uint uItemState;

        [NativeTypeName("NSTCITEMSTATE")]
        public uint nstcis;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszText;

        public int iImage;

        [NativeTypeName("HIMAGELIST")]
        public IntPtr himl;

        public int iLevel;

        public int iIndent;
    }
}