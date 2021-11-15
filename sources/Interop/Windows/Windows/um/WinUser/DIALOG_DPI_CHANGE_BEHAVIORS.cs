// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [Flags]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public enum DIALOG_DPI_CHANGE_BEHAVIORS
    {
        DDC_DEFAULT = 0x0000,
        DDC_DISABLE_ALL = 0x0001,
        DDC_DISABLE_RESIZE = 0x0002,
        DDC_DISABLE_CONTROL_RELAYOUT = 0x0004,
    }
}