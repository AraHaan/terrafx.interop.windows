// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SYNCMGR_CANCEL_REQUEST
    {
        SYNCMGR_CR_NONE = 0,
        SYNCMGR_CR_CANCEL_ITEM = 1,
        SYNCMGR_CR_CANCEL_ALL = 2,
        SYNCMGR_CR_MAX = SYNCMGR_CR_CANCEL_ALL,
    }
}