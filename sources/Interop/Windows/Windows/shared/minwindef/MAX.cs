// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_PATH 260")]
    public const int MAX_PATH = 260;
}
