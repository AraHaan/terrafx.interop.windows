// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TYPE"]/*' />
public enum D3D12_RAYTRACING_GEOMETRY_TYPE
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TYPE.D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES"]/*' />
    D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES = 0,

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TYPE.D3D12_RAYTRACING_GEOMETRY_TYPE_PROCEDURAL_PRIMITIVE_AABBS"]/*' />
    D3D12_RAYTRACING_GEOMETRY_TYPE_PROCEDURAL_PRIMITIVE_AABBS = (D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES + 1),
}
