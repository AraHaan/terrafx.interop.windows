// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MULTI_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_GPU_INPUT"]/*' />
public partial struct D3D12_MULTI_NODE_GPU_INPUT
{
    /// <include file='D3D12_MULTI_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_GPU_INPUT.NumNodeInputs"]/*' />
    public uint NumNodeInputs;

    /// <include file='D3D12_MULTI_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_GPU_INPUT.NodeInputs"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE NodeInputs;
}
