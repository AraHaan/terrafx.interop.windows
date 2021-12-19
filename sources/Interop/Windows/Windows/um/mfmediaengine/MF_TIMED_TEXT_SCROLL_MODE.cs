// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MF_TIMED_TEXT_SCROLL_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_SCROLL_MODE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_SCROLL_MODE
{
    /// <include file='MF_TIMED_TEXT_SCROLL_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_SCROLL_MODE.MF_TIMED_TEXT_SCROLL_MODE_POP_ON"]/*' />
    MF_TIMED_TEXT_SCROLL_MODE_POP_ON = 0,

    /// <include file='MF_TIMED_TEXT_SCROLL_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_SCROLL_MODE.MF_TIMED_TEXT_SCROLL_MODE_ROLL_UP"]/*' />
    MF_TIMED_TEXT_SCROLL_MODE_ROLL_UP = 1,
}
