// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON"]/*' />
public partial struct MSV1_0_LM20_LOGON
{
    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.MessageType"]/*' />
    public MSV1_0_LOGON_SUBMIT_TYPE MessageType;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.LogonDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.UserName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.Workstation"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Workstation;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.ChallengeToClient"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public _ChallengeToClient_e__FixedBuffer ChallengeToClient;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.CaseSensitiveChallengeResponse"]/*' />
    [NativeTypeName("STRING")]
    public LSA_STRING CaseSensitiveChallengeResponse;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.CaseInsensitiveChallengeResponse"]/*' />
    [NativeTypeName("STRING")]
    public LSA_STRING CaseInsensitiveChallengeResponse;

    /// <include file='MSV1_0_LM20_LOGON.xml' path='doc/member[@name="MSV1_0_LM20_LOGON.ParameterControl"]/*' />
    [NativeTypeName("ULONG")]
    public uint ParameterControl;

    /// <include file='_ChallengeToClient_e__FixedBuffer.xml' path='doc/member[@name="_ChallengeToClient_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _ChallengeToClient_e__FixedBuffer
    {
        public byte e0;
    }
}
