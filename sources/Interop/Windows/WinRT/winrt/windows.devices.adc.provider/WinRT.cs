// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.adc.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_Adc_Provider_IAdcControllerProvider = "Windows.Devices.Adc.Provider.IAdcControllerProvider";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Adc_Provider_IAdcProvider = "Windows.Devices.Adc.Provider.IAdcProvider";
}
