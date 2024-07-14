// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ZoomTransitionMode.xml' path='doc/member[@name="ZoomTransitionMode"]/*' />
public enum ZoomTransitionMode
{
    /// <include file='ZoomTransitionMode.xml' path='doc/member[@name="ZoomTransitionMode.ZoomTransitionMode_Auto"]/*' />
    ZoomTransitionMode_Auto = 0,

    /// <include file='ZoomTransitionMode.xml' path='doc/member[@name="ZoomTransitionMode.ZoomTransitionMode_Direct"]/*' />
    ZoomTransitionMode_Direct = 1,

    /// <include file='ZoomTransitionMode.xml' path='doc/member[@name="ZoomTransitionMode.ZoomTransitionMode_Smooth"]/*' />
    ZoomTransitionMode_Smooth = 2,
}
