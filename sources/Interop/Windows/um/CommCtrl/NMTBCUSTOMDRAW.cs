// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct NMTBCUSTOMDRAW
    {
        [NativeTypeName("NMCUSTOMDRAW")]
        public NMCUSTOMDRAWINFO nmcd;

        [NativeTypeName("HBRUSH")]
        public IntPtr hbrMonoDither;

        [NativeTypeName("HBRUSH")]
        public IntPtr hbrLines;

        [NativeTypeName("HPEN")]
        public IntPtr hpenLines;

        [NativeTypeName("COLORREF")]
        public uint clrText;

        [NativeTypeName("COLORREF")]
        public uint clrMark;

        [NativeTypeName("COLORREF")]
        public uint clrTextHighlight;

        [NativeTypeName("COLORREF")]
        public uint clrBtnFace;

        [NativeTypeName("COLORREF")]
        public uint clrBtnHighlight;

        [NativeTypeName("COLORREF")]
        public uint clrHighlightHotTrack;

        public RECT rcText;

        public int nStringBkMode;

        public int nHLStringBkMode;

        public int iListGap;
    }
}