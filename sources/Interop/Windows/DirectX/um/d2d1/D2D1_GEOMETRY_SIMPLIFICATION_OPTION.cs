// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_GEOMETRY_SIMPLIFICATION_OPTION.xml' path='doc/member[@name="D2D1_GEOMETRY_SIMPLIFICATION_OPTION"]/*' />
public enum D2D1_GEOMETRY_SIMPLIFICATION_OPTION : uint
{
    /// <include file='D2D1_GEOMETRY_SIMPLIFICATION_OPTION.xml' path='doc/member[@name="D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES"]/*' />
    D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES = 0,

    /// <include file='D2D1_GEOMETRY_SIMPLIFICATION_OPTION.xml' path='doc/member[@name="D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES"]/*' />
    D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES = 1,

    /// <include file='D2D1_GEOMETRY_SIMPLIFICATION_OPTION.xml' path='doc/member[@name="D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_FORCE_DWORD"]/*' />
    D2D1_GEOMETRY_SIMPLIFICATION_OPTION_FORCE_DWORD = 0xffffffff,
}
