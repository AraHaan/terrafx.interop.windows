// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TBBUTTON
    {
        public int iBitmap;

        public int idCommand;

        [NativeTypeName("BYTE")]
        public byte fsState;

        [NativeTypeName("BYTE")]
        public byte fsStyle;

        [NativeTypeName("BYTE [2]")]
        public fixed byte bReserved[2];

        [NativeTypeName("DWORD_PTR")]
        public nuint dwData;

        [NativeTypeName("INT_PTR")]
        public nint iString;
    }
}