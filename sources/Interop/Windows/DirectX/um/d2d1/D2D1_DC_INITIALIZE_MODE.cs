// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_DC_INITIALIZE_MODE.xml' path='doc/member[@name="D2D1_DC_INITIALIZE_MODE"]/*' />
public enum D2D1_DC_INITIALIZE_MODE : uint
{
    /// <include file='D2D1_DC_INITIALIZE_MODE.xml' path='doc/member[@name="D2D1_DC_INITIALIZE_MODE.D2D1_DC_INITIALIZE_MODE_COPY"]/*' />
    D2D1_DC_INITIALIZE_MODE_COPY = 0,

    /// <include file='D2D1_DC_INITIALIZE_MODE.xml' path='doc/member[@name="D2D1_DC_INITIALIZE_MODE.D2D1_DC_INITIALIZE_MODE_CLEAR"]/*' />
    D2D1_DC_INITIALIZE_MODE_CLEAR = 1,

    /// <include file='D2D1_DC_INITIALIZE_MODE.xml' path='doc/member[@name="D2D1_DC_INITIALIZE_MODE.D2D1_DC_INITIALIZE_MODE_FORCE_DWORD"]/*' />
    D2D1_DC_INITIALIZE_MODE_FORCE_DWORD = 0xffffffff,
}
