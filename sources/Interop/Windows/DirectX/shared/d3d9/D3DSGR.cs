// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DSGR
{
    [NativeTypeName("#define D3DSGR_NO_CALIBRATION 0x00000000L")]
    public const int D3DSGR_NO_CALIBRATION = 0x00000000;

    [NativeTypeName("#define D3DSGR_CALIBRATE 0x00000001L")]
    public const int D3DSGR_CALIBRATE = 0x00000001;
}
