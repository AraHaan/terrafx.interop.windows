// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MERGE_UPDATE_STATUS
    {
        MUS_COMPLETE = 0,
        MUS_USERINPUTNEEDED = (MUS_COMPLETE + 1),
        MUS_FAILED = (MUS_USERINPUTNEEDED + 1),
    }
}