// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION"]/*' />
public enum D3D12_VIDEO_PROCESS_ORIENTATION
{
    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT = 0,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL = 1,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90 = 2,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL = 3,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180 = 4,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL = 5,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270 = 6,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL"]/*' />
    D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL = 7,
}
