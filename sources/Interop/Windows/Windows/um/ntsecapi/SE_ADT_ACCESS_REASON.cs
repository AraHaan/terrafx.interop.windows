// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON"]/*' />
public unsafe partial struct SE_ADT_ACCESS_REASON
{
    /// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON.AccessMask"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint AccessMask;

    /// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON.AccessReasons"]/*' />
    [NativeTypeName("ULONG[32]")]
    public _AccessReasons_e__FixedBuffer AccessReasons;

    /// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON.ObjectTypeIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint ObjectTypeIndex;

    /// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON.AccessGranted"]/*' />
    [NativeTypeName("ULONG")]
    public uint AccessGranted;

    /// <include file='SE_ADT_ACCESS_REASON.xml' path='doc/member[@name="SE_ADT_ACCESS_REASON.SecurityDescriptor"]/*' />
    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* SecurityDescriptor;

    /// <include file='_AccessReasons_e__FixedBuffer.xml' path='doc/member[@name="_AccessReasons_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _AccessReasons_e__FixedBuffer
    {
        public uint e0;
    }
}
