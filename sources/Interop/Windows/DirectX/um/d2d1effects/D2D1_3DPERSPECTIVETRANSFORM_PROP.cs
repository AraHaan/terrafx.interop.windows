// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP"]/*' />
public enum D2D1_3DPERSPECTIVETRANSFORM_PROP : uint
{
    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE = 0,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE = 1,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH = 2,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN = 3,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET = 4,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET = 5,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN = 6,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION = 7,

    /// <include file='D2D1_3DPERSPECTIVETRANSFORM_PROP.xml' path='doc/member[@name="D2D1_3DPERSPECTIVETRANSFORM_PROP.D2D1_3DPERSPECTIVETRANSFORM_PROP_FORCE_DWORD"]/*' />
    D2D1_3DPERSPECTIVETRANSFORM_PROP_FORCE_DWORD = 0xffffffff,
}
