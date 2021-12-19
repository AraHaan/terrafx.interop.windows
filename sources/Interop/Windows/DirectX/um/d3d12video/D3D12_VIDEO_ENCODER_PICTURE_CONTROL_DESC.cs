// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.IntraRefreshFrameIndex"]/*' />
    public uint IntraRefreshFrameIndex;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.Flags"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.PictureControlCodecData"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA PictureControlCodecData;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC.ReferenceFrames"]/*' />
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;
}
