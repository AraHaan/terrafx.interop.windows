// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL"]/*' />
public partial struct WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL
{
    /// <include file='WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_DEFAULT_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.credential"]/*' />
    public WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL credential;
}
