// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionConfidence.xml' path='doc/member[@name="SpeechRecognitionConfidence"]/*' />
public enum SpeechRecognitionConfidence
{
    /// <include file='SpeechRecognitionConfidence.xml' path='doc/member[@name="SpeechRecognitionConfidence.SpeechRecognitionConfidence_High"]/*' />
    SpeechRecognitionConfidence_High = 0,

    /// <include file='SpeechRecognitionConfidence.xml' path='doc/member[@name="SpeechRecognitionConfidence.SpeechRecognitionConfidence_Medium"]/*' />
    SpeechRecognitionConfidence_Medium = 1,

    /// <include file='SpeechRecognitionConfidence.xml' path='doc/member[@name="SpeechRecognitionConfidence.SpeechRecognitionConfidence_Low"]/*' />
    SpeechRecognitionConfidence_Low = 2,

    /// <include file='SpeechRecognitionConfidence.xml' path='doc/member[@name="SpeechRecognitionConfidence.SpeechRecognitionConfidence_Rejected"]/*' />
    SpeechRecognitionConfidence_Rejected = 3,
}
