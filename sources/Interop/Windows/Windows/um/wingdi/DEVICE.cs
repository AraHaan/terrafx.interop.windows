// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class DEVICE
    {
        [NativeTypeName("#define DEVICE_FONTTYPE 0x0002")]
        public const int DEVICE_FONTTYPE = 0x0002;

        [NativeTypeName("#define DEVICE_DEFAULT_FONT 14")]
        public const int DEVICE_DEFAULT_FONT = 14;
    }
}
