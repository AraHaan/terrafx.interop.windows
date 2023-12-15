// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='LITEM.xml' path='doc/member[@name="LITEM"]/*' />
public partial struct LITEM
{
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.mask"]/*' />
    public uint mask;

    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.iLink"]/*' />
    public int iLink;

    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.state"]/*' />
    public uint state;

    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.stateMask"]/*' />
    public uint stateMask;

    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.szID"]/*' />
    [NativeTypeName("WCHAR[48]")]
    public _szID_e__FixedBuffer szID;

    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.szUrl"]/*' />
    [NativeTypeName("WCHAR[2084]")]
    public _szUrl_e__FixedBuffer szUrl;

    /// <include file='_szID_e__FixedBuffer.xml' path='doc/member[@name="_szID_e__FixedBuffer"]/*' />
    [InlineArray(48)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szID_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szUrl_e__FixedBuffer.xml' path='doc/member[@name="_szUrl_e__FixedBuffer"]/*' />
    [InlineArray(2084)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szUrl_e__FixedBuffer
    {
        public char e0;
    }
}
