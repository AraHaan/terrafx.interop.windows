// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT
{
    [SupportedOSPlatform("windows10.0")]
    public enum HANDLE_CREATION_OPTIONS
    {
        HCO_CREATE_NEW = 0x1,
        HCO_CREATE_ALWAYS = 0x2,
        HCO_OPEN_EXISTING = 0x3,
        HCO_OPEN_ALWAYS = 0x4,
        HCO_TRUNCATE_EXISTING = 0x5,
    }
}