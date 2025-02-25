// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

public partial struct D2D_VECTOR_4F : IEquatable<D2D_VECTOR_4F>
{
    public D2D_VECTOR_4F(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public static bool operator ==([NativeTypeName("const D2D_VECTOR_2F &")] in D2D_VECTOR_4F l, [NativeTypeName("const D2D_VECTOR_2F &")] in D2D_VECTOR_4F r)
    {
        return (l.x == r.x)
            && (l.y == r.y)
            && (l.z == r.z)
            && (l.w == r.w);
    }

    public static bool operator !=([NativeTypeName("const D2D_VECTOR_2F &")] in D2D_VECTOR_4F l, [NativeTypeName("const D2D_VECTOR_2F &")] in D2D_VECTOR_4F r)
        => !(l == r);

    public readonly bool Equals(D2D_VECTOR_4F other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is D2D_VECTOR_4F other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);
}
