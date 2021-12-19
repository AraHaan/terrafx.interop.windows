// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PROFILE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_H264"]/*' />
public enum D3D12_VIDEO_ENCODER_PROFILE_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_H264.D3D12_VIDEO_ENCODER_PROFILE_H264_MAIN"]/*' />
    D3D12_VIDEO_ENCODER_PROFILE_H264_MAIN = 0,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_H264.D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH"]/*' />
    D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH = 1,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_H264.D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH_10"]/*' />
    D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH_10 = 2,
}
