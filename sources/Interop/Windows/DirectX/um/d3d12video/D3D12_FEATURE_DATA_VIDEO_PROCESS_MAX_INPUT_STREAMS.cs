// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.MaxInputStreams"]/*' />
    public uint MaxInputStreams;
}
