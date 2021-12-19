// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR = 0,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE"]/*' />
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE = 0x10,
}
