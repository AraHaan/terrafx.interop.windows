// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO"]/*' />
public enum BEHAVIOR_RENDER_INFO
{
    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_BEFOREBACKGROUND"]/*' />
    BEHAVIORRENDERINFO_BEFOREBACKGROUND = 0x1,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_AFTERBACKGROUND"]/*' />
    BEHAVIORRENDERINFO_AFTERBACKGROUND = 0x2,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_BEFORECONTENT"]/*' />
    BEHAVIORRENDERINFO_BEFORECONTENT = 0x4,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_AFTERCONTENT"]/*' />
    BEHAVIORRENDERINFO_AFTERCONTENT = 0x8,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_AFTERFOREGROUND"]/*' />
    BEHAVIORRENDERINFO_AFTERFOREGROUND = 0x20,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_ABOVECONTENT"]/*' />
    BEHAVIORRENDERINFO_ABOVECONTENT = 0x28,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_ALLLAYERS"]/*' />
    BEHAVIORRENDERINFO_ALLLAYERS = 0xff,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_DISABLEBACKGROUND"]/*' />
    BEHAVIORRENDERINFO_DISABLEBACKGROUND = 0x100,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_DISABLENEGATIVEZ"]/*' />
    BEHAVIORRENDERINFO_DISABLENEGATIVEZ = 0x200,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_DISABLECONTENT"]/*' />
    BEHAVIORRENDERINFO_DISABLECONTENT = 0x400,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_DISABLEPOSITIVEZ"]/*' />
    BEHAVIORRENDERINFO_DISABLEPOSITIVEZ = 0x800,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_DISABLEALLLAYERS"]/*' />
    BEHAVIORRENDERINFO_DISABLEALLLAYERS = 0xf00,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_HITTESTING"]/*' />
    BEHAVIORRENDERINFO_HITTESTING = 0x1000,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_SURFACE"]/*' />
    BEHAVIORRENDERINFO_SURFACE = 0x100000,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIORRENDERINFO_3DSURFACE"]/*' />
    BEHAVIORRENDERINFO_3DSURFACE = 0x200000,

    /// <include file='BEHAVIOR_RENDER_INFO.xml' path='doc/member[@name="BEHAVIOR_RENDER_INFO.BEHAVIOR_RENDER_INFO_Max"]/*' />
    BEHAVIOR_RENDER_INFO_Max = 2147483647,
}
