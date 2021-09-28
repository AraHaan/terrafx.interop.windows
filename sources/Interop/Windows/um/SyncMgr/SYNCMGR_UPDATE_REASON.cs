// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SYNCMGR_UPDATE_REASON
    {
        SYNCMGR_UR_ADDED = 0,
        SYNCMGR_UR_CHANGED = 1,
        SYNCMGR_UR_REMOVED = 2,
        SYNCMGR_UR_MAX = SYNCMGR_UR_REMOVED,
    }
}