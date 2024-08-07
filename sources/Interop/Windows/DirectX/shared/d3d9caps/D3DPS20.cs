// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPS20
{
    [NativeTypeName("#define D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH 24")]
    public const int D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;

    [NativeTypeName("#define D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH 0")]
    public const int D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;

    [NativeTypeName("#define D3DPS20_MAX_NUMTEMPS 32")]
    public const int D3DPS20_MAX_NUMTEMPS = 32;

    [NativeTypeName("#define D3DPS20_MIN_NUMTEMPS 12")]
    public const int D3DPS20_MIN_NUMTEMPS = 12;

    [NativeTypeName("#define D3DPS20_MAX_STATICFLOWCONTROLDEPTH 4")]
    public const int D3DPS20_MAX_STATICFLOWCONTROLDEPTH = 4;

    [NativeTypeName("#define D3DPS20_MIN_STATICFLOWCONTROLDEPTH 0")]
    public const int D3DPS20_MIN_STATICFLOWCONTROLDEPTH = 0;

    [NativeTypeName("#define D3DPS20_MAX_NUMINSTRUCTIONSLOTS 512")]
    public const int D3DPS20_MAX_NUMINSTRUCTIONSLOTS = 512;

    [NativeTypeName("#define D3DPS20_MIN_NUMINSTRUCTIONSLOTS 96")]
    public const int D3DPS20_MIN_NUMINSTRUCTIONSLOTS = 96;
}
