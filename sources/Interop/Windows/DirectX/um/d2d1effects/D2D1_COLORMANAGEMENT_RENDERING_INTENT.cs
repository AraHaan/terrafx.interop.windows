// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT"]/*' />
public enum D2D1_COLORMANAGEMENT_RENDERING_INTENT : uint
{
    /// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT.D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL"]/*' />
    D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL = 0,

    /// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT.D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC"]/*' />
    D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC = 1,

    /// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT.D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION"]/*' />
    D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION = 2,

    /// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT.D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC"]/*' />
    D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC = 3,

    /// <include file='D2D1_COLORMANAGEMENT_RENDERING_INTENT.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_RENDERING_INTENT.D2D1_COLORMANAGEMENT_RENDERING_INTENT_FORCE_DWORD"]/*' />
    D2D1_COLORMANAGEMENT_RENDERING_INTENT_FORCE_DWORD = 0xffffffff,
}
