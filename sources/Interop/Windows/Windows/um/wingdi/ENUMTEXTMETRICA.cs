// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ENUMTEXTMETRICA.xml' path='doc/member[@name="ENUMTEXTMETRICA"]/*' />
public partial struct ENUMTEXTMETRICA
{
    /// <include file='ENUMTEXTMETRICA.xml' path='doc/member[@name="ENUMTEXTMETRICA.etmNewTextMetricEx"]/*' />
    public NEWTEXTMETRICEXA etmNewTextMetricEx;

    /// <include file='ENUMTEXTMETRICA.xml' path='doc/member[@name="ENUMTEXTMETRICA.etmAxesList"]/*' />
    public AXESLISTA etmAxesList;
}
