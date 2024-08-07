// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationViewBoundsMode.xml' path='doc/member[@name="ApplicationViewBoundsMode"]/*' />
public enum ApplicationViewBoundsMode
{
    /// <include file='ApplicationViewBoundsMode.xml' path='doc/member[@name="ApplicationViewBoundsMode.ApplicationViewBoundsMode_UseVisible"]/*' />
    ApplicationViewBoundsMode_UseVisible = 0,

    /// <include file='ApplicationViewBoundsMode.xml' path='doc/member[@name="ApplicationViewBoundsMode.ApplicationViewBoundsMode_UseCoreWindow"]/*' />
    ApplicationViewBoundsMode_UseCoreWindow = 1,
}
