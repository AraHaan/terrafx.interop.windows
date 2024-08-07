// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS"]/*' />
public enum D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP"]/*' />
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SMOOTH"]/*' />
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SMOOTH = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SHARP"]/*' />
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SHARP = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_BILINEAR"]/*' />
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_BILINEAR = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_SWITCHABLE"]/*' />
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_SWITCHABLE = 4,
}
