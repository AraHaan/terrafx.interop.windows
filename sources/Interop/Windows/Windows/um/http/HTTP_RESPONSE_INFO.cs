// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_RESPONSE_INFO.xml' path='doc/member[@name="HTTP_RESPONSE_INFO"]/*' />
public unsafe partial struct HTTP_RESPONSE_INFO
{
    /// <include file='HTTP_RESPONSE_INFO.xml' path='doc/member[@name="HTTP_RESPONSE_INFO.Type"]/*' />
    public HTTP_RESPONSE_INFO_TYPE Type;

    /// <include file='HTTP_RESPONSE_INFO.xml' path='doc/member[@name="HTTP_RESPONSE_INFO.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='HTTP_RESPONSE_INFO.xml' path='doc/member[@name="HTTP_RESPONSE_INFO.pInfo"]/*' />
    [NativeTypeName("PVOID")]
    public void* pInfo;
}
