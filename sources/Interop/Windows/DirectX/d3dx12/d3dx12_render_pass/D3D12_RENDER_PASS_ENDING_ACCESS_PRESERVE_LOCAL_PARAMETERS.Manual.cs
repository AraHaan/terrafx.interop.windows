// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics.CodeAnalysis;

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS>
{
    public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS b)
        => (a.AdditionalWidth == b.AdditionalWidth)
        && (a.AdditionalHeight == b.AdditionalHeight);

    public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS b)
        => !(a == b);

    public override bool Equals([NotNullWhen(true)] object? obj)
        => (obj is D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS other) => this == other;

    public override int GetHashCode() => HashCode.Combine(AdditionalWidth, AdditionalHeight);
}
