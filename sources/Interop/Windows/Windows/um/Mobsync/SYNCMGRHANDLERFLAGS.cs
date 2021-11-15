// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SYNCMGRHANDLERFLAGS
    {
        SYNCMGRHANDLER_HASPROPERTIES = 0x1,
        SYNCMGRHANDLER_MAYESTABLISHCONNECTION = 0x2,
        SYNCMGRHANDLER_ALWAYSLISTHANDLER = 0x4,
        SYNCMGRHANDLER_HIDDEN = 0x8,
    }
}