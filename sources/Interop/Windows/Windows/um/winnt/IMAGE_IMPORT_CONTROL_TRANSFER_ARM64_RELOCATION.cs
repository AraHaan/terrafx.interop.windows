// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION
{
    public uint _bitfield;

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.PageRelativeOffset"]/*' />
    [NativeTypeName("DWORD : 10")]
    public uint PageRelativeOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0x3FFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x3FFu) | (value & 0x3FFu);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.IndirectCall"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint IndirectCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 10) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.RegisterIndex"]/*' />
    [NativeTypeName("DWORD : 5")]
    public uint RegisterIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 11) & 0x1Fu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1Fu << 11)) | ((value & 0x1Fu) << 11);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.ImportType"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint ImportType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 16) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_ARM64_RELOCATION.IATIndex"]/*' />
    [NativeTypeName("DWORD : 15")]
    public uint IATIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 17) & 0x7FFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7FFFu << 17)) | ((value & 0x7FFFu) << 17);
        }
    }
}
