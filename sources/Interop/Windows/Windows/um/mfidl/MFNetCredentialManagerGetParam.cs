// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam"]/*' />
public unsafe partial struct MFNetCredentialManagerGetParam
{
    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.hrOp"]/*' />
    public HRESULT hrOp;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.fAllowLoggedOnUser"]/*' />
    public BOOL fAllowLoggedOnUser;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.fClearTextPackage"]/*' />
    public BOOL fClearTextPackage;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.pszUrl"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszUrl;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.pszSite"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszSite;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.pszRealm"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszRealm;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.pszPackage"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszPackage;

    /// <include file='MFNetCredentialManagerGetParam.xml' path='doc/member[@name="MFNetCredentialManagerGetParam.nRetries"]/*' />
    [NativeTypeName("LONG")]
    public int nRetries;
}
