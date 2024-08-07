// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='LOCALMANAGEDAPPLICATION.xml' path='doc/member[@name="LOCALMANAGEDAPPLICATION"]/*' />
public unsafe partial struct LOCALMANAGEDAPPLICATION
{
    /// <include file='LOCALMANAGEDAPPLICATION.xml' path='doc/member[@name="LOCALMANAGEDAPPLICATION.pszDeploymentName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszDeploymentName;

    /// <include file='LOCALMANAGEDAPPLICATION.xml' path='doc/member[@name="LOCALMANAGEDAPPLICATION.pszPolicyName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszPolicyName;

    /// <include file='LOCALMANAGEDAPPLICATION.xml' path='doc/member[@name="LOCALMANAGEDAPPLICATION.pszProductId"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszProductId;

    /// <include file='LOCALMANAGEDAPPLICATION.xml' path='doc/member[@name="LOCALMANAGEDAPPLICATION.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;
}
