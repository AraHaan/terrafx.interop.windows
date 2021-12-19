// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SECURITY_CONSTRAINTS.xml' path='doc/member[@name="WS_SECURITY_CONSTRAINTS"]/*' />
public unsafe partial struct WS_SECURITY_CONSTRAINTS
{
    /// <include file='WS_SECURITY_CONSTRAINTS.xml' path='doc/member[@name="WS_SECURITY_CONSTRAINTS.securityPropertyConstraints"]/*' />
    public WS_SECURITY_PROPERTY_CONSTRAINT* securityPropertyConstraints;

    /// <include file='WS_SECURITY_CONSTRAINTS.xml' path='doc/member[@name="WS_SECURITY_CONSTRAINTS.securityPropertyConstraintCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint securityPropertyConstraintCount;

    /// <include file='WS_SECURITY_CONSTRAINTS.xml' path='doc/member[@name="WS_SECURITY_CONSTRAINTS.securityBindingConstraints"]/*' />
    public WS_SECURITY_BINDING_CONSTRAINT** securityBindingConstraints;

    /// <include file='WS_SECURITY_CONSTRAINTS.xml' path='doc/member[@name="WS_SECURITY_CONSTRAINTS.securityBindingConstraintCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint securityBindingConstraintCount;
}
