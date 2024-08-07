// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING"]/*' />
public enum DISPLAYCONFIG_SCANLINE_ORDERING
{
    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,

    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,

    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,

    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED,

    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,

    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32"]/*' />
    DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}
