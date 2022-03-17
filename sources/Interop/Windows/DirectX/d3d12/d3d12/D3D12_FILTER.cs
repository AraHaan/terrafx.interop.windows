// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER"]/*' />
public enum D3D12_FILTER
{
    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MIN_MAG_MIP_POINT = 0,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x1,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x4,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x5,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MIN_MAG_MIP_LINEAR = 0x15,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_ANISOTROPIC"]/*' />
    D3D12_FILTER_ANISOTROPIC = 0x55,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 0x80,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x81,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x84,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x85,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x90,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x91,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x94,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 0x95,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_ANISOTROPIC"]/*' />
    D3D12_FILTER_COMPARISON_ANISOTROPIC = 0xd5,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT = 0x100,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x101,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x104,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x105,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x110,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x111,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x114,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR = 0x115,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_ANISOTROPIC"]/*' />
    D3D12_FILTER_MINIMUM_ANISOTROPIC = 0x155,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT = 0x180,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x181,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x184,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x185,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x190,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x191,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x194,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR"]/*' />
    D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR = 0x195,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_ANISOTROPIC"]/*' />
    D3D12_FILTER_MAXIMUM_ANISOTROPIC = 0x1d5,
}
