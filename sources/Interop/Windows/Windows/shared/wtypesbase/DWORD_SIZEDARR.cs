// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DWORD_SIZEDARR.xml' path='doc/member[@name="DWORD_SIZEDARR"]/*' />
public unsafe partial struct DWORD_SIZEDARR
{
    /// <include file='DWORD_SIZEDARR.xml' path='doc/member[@name="DWORD_SIZEDARR.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='DWORD_SIZEDARR.xml' path='doc/member[@name="DWORD_SIZEDARR.pData"]/*' />
    [NativeTypeName("ULONG *")]
    public uint* pData;
}
