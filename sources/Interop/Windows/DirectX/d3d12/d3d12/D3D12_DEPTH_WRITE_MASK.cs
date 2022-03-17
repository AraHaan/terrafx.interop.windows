// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEPTH_WRITE_MASK.xml' path='doc/member[@name="D3D12_DEPTH_WRITE_MASK"]/*' />
public enum D3D12_DEPTH_WRITE_MASK
{
    /// <include file='D3D12_DEPTH_WRITE_MASK.xml' path='doc/member[@name="D3D12_DEPTH_WRITE_MASK.D3D12_DEPTH_WRITE_MASK_ZERO"]/*' />
    D3D12_DEPTH_WRITE_MASK_ZERO = 0,

    /// <include file='D3D12_DEPTH_WRITE_MASK.xml' path='doc/member[@name="D3D12_DEPTH_WRITE_MASK.D3D12_DEPTH_WRITE_MASK_ALL"]/*' />
    D3D12_DEPTH_WRITE_MASK_ALL = 1,
}
