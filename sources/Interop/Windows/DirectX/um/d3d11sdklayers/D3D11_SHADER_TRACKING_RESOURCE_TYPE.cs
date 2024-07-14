// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_SHADER_TRACKING_RESOURCE_TYPE
{
    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_NONE"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_NONE = 0,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_UAV_DEVICEMEMORY"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_UAV_DEVICEMEMORY = 1,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_NON_UAV_DEVICEMEMORY"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_NON_UAV_DEVICEMEMORY = 2,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_DEVICEMEMORY"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_DEVICEMEMORY = 3,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_MEMORY"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_MEMORY = 4,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_SHARED_MEMORY"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_SHARED_MEMORY = 5,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_NON_UAV"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_NON_UAV = 6,

    /// <include file='D3D11_SHADER_TRACKING_RESOURCE_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TRACKING_RESOURCE_TYPE.D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL"]/*' />
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL = 7,
}
