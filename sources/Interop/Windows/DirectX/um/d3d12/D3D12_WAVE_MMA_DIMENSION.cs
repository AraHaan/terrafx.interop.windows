// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WAVE_MMA_DIMENSION.xml' path='doc/member[@name="D3D12_WAVE_MMA_DIMENSION"]/*' />
public enum D3D12_WAVE_MMA_DIMENSION
{
    /// <include file='D3D12_WAVE_MMA_DIMENSION.xml' path='doc/member[@name="D3D12_WAVE_MMA_DIMENSION.D3D12_WAVE_MMA_DIMENSION_INVALID"]/*' />
    D3D12_WAVE_MMA_DIMENSION_INVALID = 0,

    /// <include file='D3D12_WAVE_MMA_DIMENSION.xml' path='doc/member[@name="D3D12_WAVE_MMA_DIMENSION.D3D12_WAVE_MMA_DIMENSION_16"]/*' />
    D3D12_WAVE_MMA_DIMENSION_16 = (D3D12_WAVE_MMA_DIMENSION_INVALID + 1),

    /// <include file='D3D12_WAVE_MMA_DIMENSION.xml' path='doc/member[@name="D3D12_WAVE_MMA_DIMENSION.D3D12_WAVE_MMA_DIMENSION_64"]/*' />
    D3D12_WAVE_MMA_DIMENSION_64 = (D3D12_WAVE_MMA_DIMENSION_16 + 1),
}
