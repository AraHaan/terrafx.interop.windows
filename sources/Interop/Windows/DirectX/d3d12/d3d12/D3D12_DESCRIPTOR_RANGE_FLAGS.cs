// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS"]/*' />
[Flags]
public enum D3D12_DESCRIPTOR_RANGE_FLAGS
{
    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_NONE"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_NONE = 0,

    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_VOLATILE"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_VOLATILE = 0x1,

    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_DATA_VOLATILE"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_DATA_VOLATILE = 0x2,

    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE = 0x4,

    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC = 0x8,

    /// <include file='D3D12_DESCRIPTOR_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_FLAGS.D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS"]/*' />
    D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS = 0x10000,
}
