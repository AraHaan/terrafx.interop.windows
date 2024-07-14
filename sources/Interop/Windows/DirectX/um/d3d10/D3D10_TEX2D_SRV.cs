// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_TEX2D_SRV.xml' path='doc/member[@name="D3D10_TEX2D_SRV"]/*' />
public partial struct D3D10_TEX2D_SRV
{
    /// <include file='D3D10_TEX2D_SRV.xml' path='doc/member[@name="D3D10_TEX2D_SRV.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D10_TEX2D_SRV.xml' path='doc/member[@name="D3D10_TEX2D_SRV.MipLevels"]/*' />
    public uint MipLevels;
}
