// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC"]/*' />
public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC
{
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.DestAccelerationStructureData"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong DestAccelerationStructureData;

    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.Inputs"]/*' />
    public D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS Inputs;

    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.SourceAccelerationStructureData"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong SourceAccelerationStructureData;

    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC.ScratchAccelerationStructureData"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong ScratchAccelerationStructureData;
}
