// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DICD
{
    [NativeTypeName("#define DICD_GENERATE_ID 0x00000001")]
    public const int DICD_GENERATE_ID = 0x00000001;

    [NativeTypeName("#define DICD_INHERIT_CLASSDRVS 0x00000002")]
    public const int DICD_INHERIT_CLASSDRVS = 0x00000002;
}
