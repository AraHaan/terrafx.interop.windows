// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM
{
    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.pBuffer"]/*' />
    public ID3D12Resource* pBuffer;

    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Size;
}
