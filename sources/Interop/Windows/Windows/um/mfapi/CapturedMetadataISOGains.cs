// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CapturedMetadataISOGains.xml' path='doc/member[@name="CapturedMetadataISOGains"]/*' />
public partial struct CapturedMetadataISOGains
{
    /// <include file='CapturedMetadataISOGains.xml' path='doc/member[@name="CapturedMetadataISOGains.AnalogGain"]/*' />
    public float AnalogGain;

    /// <include file='CapturedMetadataISOGains.xml' path='doc/member[@name="CapturedMetadataISOGains.DigitalGain"]/*' />
    public float DigitalGain;
}
