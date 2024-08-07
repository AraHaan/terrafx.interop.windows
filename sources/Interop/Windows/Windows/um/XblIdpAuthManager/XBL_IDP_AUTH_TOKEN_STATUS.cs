// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS"]/*' />
public enum XBL_IDP_AUTH_TOKEN_STATUS
{
    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_SUCCESS"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_SUCCESS = 0,

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_SUCCESS"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_SUCCESS = (XBL_IDP_AUTH_TOKEN_STATUS_SUCCESS + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_NO_ACCOUNT_SET"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_NO_ACCOUNT_SET = (XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_SUCCESS + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_LOAD_MSA_ACCOUNT_FAILED"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_LOAD_MSA_ACCOUNT_FAILED = (XBL_IDP_AUTH_TOKEN_STATUS_NO_ACCOUNT_SET + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_XBOX_VETO"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_XBOX_VETO = (XBL_IDP_AUTH_TOKEN_STATUS_LOAD_MSA_ACCOUNT_FAILED + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_MSA_INTERRUPT"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_MSA_INTERRUPT = (XBL_IDP_AUTH_TOKEN_STATUS_XBOX_VETO + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_NO_CONSENT"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_NO_CONSENT = (XBL_IDP_AUTH_TOKEN_STATUS_MSA_INTERRUPT + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_VIEW_NOT_SET"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_VIEW_NOT_SET = (XBL_IDP_AUTH_TOKEN_STATUS_OFFLINE_NO_CONSENT + 1),

    /// <include file='XBL_IDP_AUTH_TOKEN_STATUS.xml' path='doc/member[@name="XBL_IDP_AUTH_TOKEN_STATUS.XBL_IDP_AUTH_TOKEN_STATUS_UNKNOWN"]/*' />
    XBL_IDP_AUTH_TOKEN_STATUS_UNKNOWN = unchecked((int)(0xffffffff)),
}
