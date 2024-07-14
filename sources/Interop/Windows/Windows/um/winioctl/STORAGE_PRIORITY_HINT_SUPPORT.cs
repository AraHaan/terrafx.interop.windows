// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PRIORITY_HINT_SUPPORT.xml' path='doc/member[@name="STORAGE_PRIORITY_HINT_SUPPORT"]/*' />
public partial struct STORAGE_PRIORITY_HINT_SUPPORT
{
    /// <include file='STORAGE_PRIORITY_HINT_SUPPORT.xml' path='doc/member[@name="STORAGE_PRIORITY_HINT_SUPPORT.SupportFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint SupportFlags;
}
