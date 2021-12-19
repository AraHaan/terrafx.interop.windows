// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA.xml' path='doc/member[@name="CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA"]/*' />
public unsafe partial struct CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA
{
    /// <include file='CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA.xml' path='doc/member[@name="CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA.cOID"]/*' />
    [NativeTypeName("DWORD")]
    public uint cOID;

    /// <include file='CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA.xml' path='doc/member[@name="CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA.rgpszOID"]/*' />
    [NativeTypeName("LPSTR *")]
    public sbyte** rgpszOID;
}
