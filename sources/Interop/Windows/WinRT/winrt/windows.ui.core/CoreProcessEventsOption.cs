// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreProcessEventsOption.xml' path='doc/member[@name="CoreProcessEventsOption"]/*' />
public enum CoreProcessEventsOption
{
    /// <include file='CoreProcessEventsOption.xml' path='doc/member[@name="CoreProcessEventsOption.CoreProcessEventsOption_ProcessOneAndAllPending"]/*' />
    CoreProcessEventsOption_ProcessOneAndAllPending = 0,

    /// <include file='CoreProcessEventsOption.xml' path='doc/member[@name="CoreProcessEventsOption.CoreProcessEventsOption_ProcessOneIfPresent"]/*' />
    CoreProcessEventsOption_ProcessOneIfPresent = 1,

    /// <include file='CoreProcessEventsOption.xml' path='doc/member[@name="CoreProcessEventsOption.CoreProcessEventsOption_ProcessUntilQuit"]/*' />
    CoreProcessEventsOption_ProcessUntilQuit = 2,

    /// <include file='CoreProcessEventsOption.xml' path='doc/member[@name="CoreProcessEventsOption.CoreProcessEventsOption_ProcessAllIfPresent"]/*' />
    CoreProcessEventsOption_ProcessAllIfPresent = 3,
}
