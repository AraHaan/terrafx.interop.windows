// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TC
{
    [NativeTypeName("#define TC_NORMAL 0")]
    public const int TC_NORMAL = 0;

    [NativeTypeName("#define TC_HARDERR 1")]
    public const int TC_HARDERR = 1;

    [NativeTypeName("#define TC_GP_TRAP 2")]
    public const int TC_GP_TRAP = 2;

    [NativeTypeName("#define TC_SIGNAL 3")]
    public const int TC_SIGNAL = 3;
}
