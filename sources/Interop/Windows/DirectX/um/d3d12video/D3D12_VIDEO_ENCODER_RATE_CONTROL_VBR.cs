// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.InitialQP"]/*' />
    public uint InitialQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.MinQP"]/*' />
    public uint MinQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.MaxQP"]/*' />
    public uint MaxQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.MaxFrameBitSize"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaxFrameBitSize;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.TargetAvgBitRate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TargetAvgBitRate;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.PeakBitRate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PeakBitRate;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.VBVCapacity"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VBVCapacity;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR.InitialVBVFullness"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InitialVBVFullness;
}
