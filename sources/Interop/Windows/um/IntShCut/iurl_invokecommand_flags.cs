// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum iurl_invokecommand_flags
    {
        IURL_INVOKECOMMAND_FL_ALLOW_UI = 0x0001,
        IURL_INVOKECOMMAND_FL_USE_DEFAULT_VERB = 0x0002,
        IURL_INVOKECOMMAND_FL_DDEWAIT = 0x0004,
        IURL_INVOKECOMMAND_FL_ASYNCOK = 0x0008,
        IURL_INVOKECOMMAND_FL_LOG_USAGE = 0x0010,
    }
}