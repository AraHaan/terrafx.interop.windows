// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIPROPAUTOCENTER
{
    [NativeTypeName("#define DIPROPAUTOCENTER_OFF 0")]
    public const int DIPROPAUTOCENTER_OFF = 0;

    [NativeTypeName("#define DIPROPAUTOCENTER_ON 1")]
    public const int DIPROPAUTOCENTER_ON = 1;
}
