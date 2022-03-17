// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_BYTECODE.xml' path='doc/member[@name="D3D12_SHADER_BYTECODE"]/*' />
public unsafe partial struct D3D12_SHADER_BYTECODE
{
    /// <include file='D3D12_SHADER_BYTECODE.xml' path='doc/member[@name="D3D12_SHADER_BYTECODE.pShaderBytecode"]/*' />
    [NativeTypeName("const void *")]
    public void* pShaderBytecode;

    /// <include file='D3D12_SHADER_BYTECODE.xml' path='doc/member[@name="D3D12_SHADER_BYTECODE.BytecodeLength"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint BytecodeLength;
}
