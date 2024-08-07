// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_ASYNC_GETDATA_FLAG.xml' path='doc/member[@name="D3D10_ASYNC_GETDATA_FLAG"]/*' />
[Flags]
public enum D3D10_ASYNC_GETDATA_FLAG
{
    /// <include file='D3D10_ASYNC_GETDATA_FLAG.xml' path='doc/member[@name="D3D10_ASYNC_GETDATA_FLAG.D3D10_ASYNC_GETDATA_DONOTFLUSH"]/*' />
    D3D10_ASYNC_GETDATA_DONOTFLUSH = 0x1,
}
