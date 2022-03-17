// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES = 0x20,
}
