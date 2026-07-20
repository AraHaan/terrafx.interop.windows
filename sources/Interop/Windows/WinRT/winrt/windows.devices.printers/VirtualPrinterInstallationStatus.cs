// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VirtualPrinterInstallationStatus.xml' path='doc/member[@name="VirtualPrinterInstallationStatus"]/*' />
public enum VirtualPrinterInstallationStatus
{
    /// <include file='VirtualPrinterInstallationStatus.xml' path='doc/member[@name="VirtualPrinterInstallationStatus.VirtualPrinterInstallationStatus_InstallationSucceeded"]/*' />
    VirtualPrinterInstallationStatus_InstallationSucceeded = 0,

    /// <include file='VirtualPrinterInstallationStatus.xml' path='doc/member[@name="VirtualPrinterInstallationStatus.VirtualPrinterInstallationStatus_PrinterAlreadyInstalled"]/*' />
    VirtualPrinterInstallationStatus_PrinterAlreadyInstalled = 1,

    /// <include file='VirtualPrinterInstallationStatus.xml' path='doc/member[@name="VirtualPrinterInstallationStatus.VirtualPrinterInstallationStatus_PrinterInstallationAccessDenied"]/*' />
    VirtualPrinterInstallationStatus_PrinterInstallationAccessDenied = 2,

    /// <include file='VirtualPrinterInstallationStatus.xml' path='doc/member[@name="VirtualPrinterInstallationStatus.VirtualPrinterInstallationStatus_PrinterInstallationFailed"]/*' />
    VirtualPrinterInstallationStatus_PrinterInstallationFailed = 3,
}
