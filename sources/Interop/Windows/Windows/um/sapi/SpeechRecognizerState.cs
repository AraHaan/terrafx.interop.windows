// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPRECOSTATE;

namespace TerraFX.Interop.Windows
{
    public enum SpeechRecognizerState
    {
        SRSInactive = SPRST_INACTIVE,
        SRSActive = SPRST_ACTIVE,
        SRSActiveAlways = SPRST_ACTIVE_ALWAYS,
        SRSInactiveWithPurge = SPRST_INACTIVE_WITH_PURGE,
    }
}