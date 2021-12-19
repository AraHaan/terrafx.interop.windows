// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY"]/*' />
public unsafe partial struct LOOKUP_STREAM_FROM_CLUSTER_ENTRY
{
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.OffsetToNext"]/*' />
    [NativeTypeName("DWORD")]
    public uint OffsetToNext;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Reserved"]/*' />
    public LARGE_INTEGER Reserved;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.Cluster"]/*' />
    public LARGE_INTEGER Cluster;

    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_ENTRY.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_ENTRY.FileName"]/*' />
    [NativeTypeName("WCHAR [1]")]
    public fixed ushort FileName[1];
}
