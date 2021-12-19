// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS"]/*' />
[Flags]
public enum D3D12_PIPELINE_STATE_FLAGS
{
    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_NONE"]/*' />
    D3D12_PIPELINE_STATE_FLAG_NONE = 0,

    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG"]/*' />
    D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG = 0x1,
}
