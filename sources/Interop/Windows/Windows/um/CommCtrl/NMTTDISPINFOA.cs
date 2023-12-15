// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA"]/*' />
public unsafe partial struct NMTTDISPINFOA
{
    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.lpszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpszText;

    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.szText"]/*' />
    [NativeTypeName("char[80]")]
    public _szText_e__FixedBuffer szText;

    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.hinst"]/*' />
    public HINSTANCE hinst;

    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.uFlags"]/*' />
    public uint uFlags;

    /// <include file='NMTTDISPINFOA.xml' path='doc/member[@name="NMTTDISPINFOA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='_szText_e__FixedBuffer.xml' path='doc/member[@name="_szText_e__FixedBuffer"]/*' />
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szText_e__FixedBuffer
    {
        public sbyte e0;
    }
}
