// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_BINDING_A.xml' path='doc/member[@name="HTTP_SERVICE_BINDING_A"]/*' />
public unsafe partial struct HTTP_SERVICE_BINDING_A
{
    /// <include file='HTTP_SERVICE_BINDING_A.xml' path='doc/member[@name="HTTP_SERVICE_BINDING_A.Base"]/*' />
    public HTTP_SERVICE_BINDING_BASE Base;

    /// <include file='HTTP_SERVICE_BINDING_A.xml' path='doc/member[@name="HTTP_SERVICE_BINDING_A.Buffer"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Buffer;

    /// <include file='HTTP_SERVICE_BINDING_A.xml' path='doc/member[@name="HTTP_SERVICE_BINDING_A.BufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint BufferSize;
}
