// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC"]/*' />
public partial struct D3D12_VIDEO_DECODER_HEAP_DESC
{
    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.Configuration"]/*' />
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.DecodeWidth"]/*' />
    public uint DecodeWidth;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.DecodeHeight"]/*' />
    public uint DecodeHeight;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.FrameRate"]/*' />
    public DXGI_RATIONAL FrameRate;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.BitRate"]/*' />
    public uint BitRate;

    /// <include file='D3D12_VIDEO_DECODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_HEAP_DESC.MaxDecodePictureBufferCount"]/*' />
    public uint MaxDecodePictureBufferCount;
}
