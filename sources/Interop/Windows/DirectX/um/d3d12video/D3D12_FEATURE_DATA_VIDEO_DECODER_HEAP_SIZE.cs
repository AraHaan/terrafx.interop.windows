// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.VideoDecoderHeapDesc"]/*' />
    public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.MemoryPoolL0Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE.MemoryPoolL1Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
