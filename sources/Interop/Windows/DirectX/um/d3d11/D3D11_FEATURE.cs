// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE"]/*' />
public enum D3D11_FEATURE
{
    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_THREADING"]/*' />
    D3D11_FEATURE_THREADING = 0,

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_DOUBLES"]/*' />
    D3D11_FEATURE_DOUBLES = (D3D11_FEATURE_THREADING + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_FORMAT_SUPPORT"]/*' />
    D3D11_FEATURE_FORMAT_SUPPORT = (D3D11_FEATURE_DOUBLES + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_FORMAT_SUPPORT2"]/*' />
    D3D11_FEATURE_FORMAT_SUPPORT2 = (D3D11_FEATURE_FORMAT_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS"]/*' />
    D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS = (D3D11_FEATURE_FORMAT_SUPPORT2 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS = (D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_ARCHITECTURE_INFO"]/*' />
    D3D11_FEATURE_ARCHITECTURE_INFO = (D3D11_FEATURE_D3D11_OPTIONS + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_OPTIONS"]/*' />
    D3D11_FEATURE_D3D9_OPTIONS = (D3D11_FEATURE_ARCHITECTURE_INFO + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT"]/*' />
    D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT = (D3D11_FEATURE_D3D9_OPTIONS + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_SHADOW_SUPPORT"]/*' />
    D3D11_FEATURE_D3D9_SHADOW_SUPPORT = (D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS1"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS1 = (D3D11_FEATURE_D3D9_SHADOW_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT"]/*' />
    D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT = (D3D11_FEATURE_D3D11_OPTIONS1 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_MARKER_SUPPORT"]/*' />
    D3D11_FEATURE_MARKER_SUPPORT = (D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_OPTIONS1"]/*' />
    D3D11_FEATURE_D3D9_OPTIONS1 = (D3D11_FEATURE_MARKER_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS2"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS2 = (D3D11_FEATURE_D3D9_OPTIONS1 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS3"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS3 = (D3D11_FEATURE_D3D11_OPTIONS2 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*' />
    D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT = (D3D11_FEATURE_D3D11_OPTIONS3 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS4"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS4 = (D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_SHADER_CACHE"]/*' />
    D3D11_FEATURE_SHADER_CACHE = (D3D11_FEATURE_D3D11_OPTIONS4 + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS5"]/*' />
    D3D11_FEATURE_D3D11_OPTIONS5 = (D3D11_FEATURE_SHADER_CACHE + 1),

    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_DISPLAYABLE"]/*' />
    D3D11_FEATURE_DISPLAYABLE = (D3D11_FEATURE_D3D11_OPTIONS5 + 1),
}
