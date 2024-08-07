// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FindPackageDependencyCriteria.xml' path='doc/member[@name="FindPackageDependencyCriteria"]/*' />
public unsafe partial struct FindPackageDependencyCriteria
{
    /// <include file='FindPackageDependencyCriteria.xml' path='doc/member[@name="FindPackageDependencyCriteria.User"]/*' />
    [NativeTypeName("PSID")]
    public void* User;

    /// <include file='FindPackageDependencyCriteria.xml' path='doc/member[@name="FindPackageDependencyCriteria.ScopeIsSystem"]/*' />
    public BOOL ScopeIsSystem;

    /// <include file='FindPackageDependencyCriteria.xml' path='doc/member[@name="FindPackageDependencyCriteria.PackageFamilyName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* PackageFamilyName;
}
