// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct SP_PROPCHANGE_PARAMS64
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("DWORD")]
    public uint StateChange;

    [NativeTypeName("DWORD")]
    public uint Scope;

    [NativeTypeName("DWORD")]
    public uint HwProfile;
}
