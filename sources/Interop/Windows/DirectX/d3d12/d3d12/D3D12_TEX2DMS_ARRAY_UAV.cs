// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEX2DMS_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX2DMS_ARRAY_UAV"]/*' />
public partial struct D3D12_TEX2DMS_ARRAY_UAV
{
    /// <include file='D3D12_TEX2DMS_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX2DMS_ARRAY_UAV.FirstArraySlice"]/*' />
    public uint FirstArraySlice;

    /// <include file='D3D12_TEX2DMS_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX2DMS_ARRAY_UAV.ArraySize"]/*' />
    public uint ArraySize;
}
