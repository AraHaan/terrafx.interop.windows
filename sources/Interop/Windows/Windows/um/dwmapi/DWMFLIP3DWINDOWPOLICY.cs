// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DWMFLIP3DWINDOWPOLICY.xml' path='doc/member[@name="DWMFLIP3DWINDOWPOLICY"]/*' />
public enum DWMFLIP3DWINDOWPOLICY
{
    /// <include file='DWMFLIP3DWINDOWPOLICY.xml' path='doc/member[@name="DWMFLIP3DWINDOWPOLICY.DWMFLIP3D_DEFAULT"]/*' />
    DWMFLIP3D_DEFAULT,

    /// <include file='DWMFLIP3DWINDOWPOLICY.xml' path='doc/member[@name="DWMFLIP3DWINDOWPOLICY.DWMFLIP3D_EXCLUDEBELOW"]/*' />
    DWMFLIP3D_EXCLUDEBELOW,

    /// <include file='DWMFLIP3DWINDOWPOLICY.xml' path='doc/member[@name="DWMFLIP3DWINDOWPOLICY.DWMFLIP3D_EXCLUDEABOVE"]/*' />
    DWMFLIP3D_EXCLUDEABOVE,

    /// <include file='DWMFLIP3DWINDOWPOLICY.xml' path='doc/member[@name="DWMFLIP3DWINDOWPOLICY.DWMFLIP3D_LAST"]/*' />
    DWMFLIP3D_LAST,
}
