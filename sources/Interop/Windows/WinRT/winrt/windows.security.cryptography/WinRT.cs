// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Security_Cryptography_ICryptographicBufferStatics = "Windows.Security.Cryptography.ICryptographicBufferStatics";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Security_Cryptography_CryptographicBuffer = "Windows.Security.Cryptography.CryptographicBuffer";
}
