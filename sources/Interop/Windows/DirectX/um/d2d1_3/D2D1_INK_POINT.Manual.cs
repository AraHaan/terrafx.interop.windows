// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public partial struct D2D1_INK_POINT
{
    public D2D1_INK_POINT([NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point, float radius)
    {
        this = InkPoint(point, radius);
    }
}
