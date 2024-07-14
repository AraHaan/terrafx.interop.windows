// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SECURITY_ALGORITHM_PROPERTY.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_PROPERTY"]/*' />
public unsafe partial struct WS_SECURITY_ALGORITHM_PROPERTY
{
    /// <include file='WS_SECURITY_ALGORITHM_PROPERTY.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_PROPERTY.id"]/*' />
    public WS_SECURITY_ALGORITHM_PROPERTY_ID id;

    /// <include file='WS_SECURITY_ALGORITHM_PROPERTY.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_PROPERTY.value"]/*' />
    public void* value;

    /// <include file='WS_SECURITY_ALGORITHM_PROPERTY.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_PROPERTY.valueSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint valueSize;
}
