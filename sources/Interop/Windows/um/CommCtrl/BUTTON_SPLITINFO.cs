// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct BUTTON_SPLITINFO
    {
        [NativeTypeName("UINT")]
        public uint mask;

        [NativeTypeName("HIMAGELIST")]
        public IntPtr himlGlyph;

        [NativeTypeName("UINT")]
        public uint uSplitStyle;

        public SIZE size;
    }
}