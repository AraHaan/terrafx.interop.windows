// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum ASSOCCLASS
    {
        ASSOCCLASS_SHELL_KEY = 0,
        ASSOCCLASS_PROGID_KEY,
        ASSOCCLASS_PROGID_STR,
        ASSOCCLASS_CLSID_KEY,
        ASSOCCLASS_CLSID_STR,
        ASSOCCLASS_APP_KEY,
        ASSOCCLASS_APP_STR,
        ASSOCCLASS_SYSTEM_STR,
        ASSOCCLASS_FOLDER,
        ASSOCCLASS_STAR,
        ASSOCCLASS_FIXED_PROGID_STR,
        ASSOCCLASS_PROTOCOL_STR,
    }
}