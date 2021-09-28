// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum NSTCSTYLE
    {
        NSTCS_HASEXPANDOS = 0x1,
        NSTCS_HASLINES = 0x2,
        NSTCS_SINGLECLICKEXPAND = 0x4,
        NSTCS_FULLROWSELECT = 0x8,
        NSTCS_SPRINGEXPAND = 0x10,
        NSTCS_HORIZONTALSCROLL = 0x20,
        NSTCS_ROOTHASEXPANDO = 0x40,
        NSTCS_SHOWSELECTIONALWAYS = 0x80,
        NSTCS_NOINFOTIP = 0x200,
        NSTCS_EVENHEIGHT = 0x400,
        NSTCS_NOREPLACEOPEN = 0x800,
        NSTCS_DISABLEDRAGDROP = 0x1000,
        NSTCS_NOORDERSTREAM = 0x2000,
        NSTCS_RICHTOOLTIP = 0x4000,
        NSTCS_BORDER = 0x8000,
        NSTCS_NOEDITLABELS = 0x10000,
        NSTCS_TABSTOP = 0x20000,
        NSTCS_FAVORITESMODE = 0x80000,
        NSTCS_AUTOHSCROLL = 0x100000,
        NSTCS_FADEINOUTEXPANDOS = 0x200000,
        NSTCS_EMPTYTEXT = 0x400000,
        NSTCS_CHECKBOXES = 0x800000,
        NSTCS_PARTIALCHECKBOXES = 0x1000000,
        NSTCS_EXCLUSIONCHECKBOXES = 0x2000000,
        NSTCS_DIMMEDCHECKBOXES = 0x4000000,
        NSTCS_NOINDENTCHECKS = 0x8000000,
        NSTCS_ALLOWJUNCTIONS = 0x10000000,
        NSTCS_SHOWTABSBUTTON = 0x20000000,
        NSTCS_SHOWDELETEBUTTON = 0x40000000,
        NSTCS_SHOWREFRESHBUTTON = unchecked((int)(0x80000000)),
    }
}