// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE"]/*' />
public enum D3D12_TEXTURE_COPY_TYPE
{
    /// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE.D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX"]/*' />
    D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX = 0,

    /// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE.D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT"]/*' />
    D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT = 1,
}
