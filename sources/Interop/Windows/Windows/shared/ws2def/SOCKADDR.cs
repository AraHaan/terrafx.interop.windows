// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SOCKADDR.xml' path='doc/member[@name="SOCKADDR"]/*' />
public partial struct SOCKADDR
{
    /// <include file='SOCKADDR.xml' path='doc/member[@name="SOCKADDR.sa_family"]/*' />
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sa_family;

    /// <include file='SOCKADDR.xml' path='doc/member[@name="SOCKADDR.sa_data"]/*' />
    [NativeTypeName("CHAR[14]")]
    public _sa_data_e__FixedBuffer sa_data;

    /// <include file='_sa_data_e__FixedBuffer.xml' path='doc/member[@name="_sa_data_e__FixedBuffer"]/*' />
    [InlineArray(14)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _sa_data_e__FixedBuffer
    {
        public sbyte e0;
    }
}
