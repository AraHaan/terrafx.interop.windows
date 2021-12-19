// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE"]/*' />
public enum D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE
{
    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD"]/*' />
    D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD = 0,

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE"]/*' />
    D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR"]/*' />
    D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS"]/*' />
    D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS = (D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR + 1),
}
