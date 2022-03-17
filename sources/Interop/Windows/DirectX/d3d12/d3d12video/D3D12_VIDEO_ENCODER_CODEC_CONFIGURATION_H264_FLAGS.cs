// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES = 0x8,
}
