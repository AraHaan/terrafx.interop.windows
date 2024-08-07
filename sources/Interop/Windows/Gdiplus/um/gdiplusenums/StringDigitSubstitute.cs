// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='StringDigitSubstitute.xml' path='doc/member[@name="StringDigitSubstitute"]/*' />
public enum StringDigitSubstitute
{
    /// <include file='StringDigitSubstitute.xml' path='doc/member[@name="StringDigitSubstitute.StringDigitSubstituteUser"]/*' />
    StringDigitSubstituteUser = 0,

    /// <include file='StringDigitSubstitute.xml' path='doc/member[@name="StringDigitSubstitute.StringDigitSubstituteNone"]/*' />
    StringDigitSubstituteNone = 1,

    /// <include file='StringDigitSubstitute.xml' path='doc/member[@name="StringDigitSubstitute.StringDigitSubstituteNational"]/*' />
    StringDigitSubstituteNational = 2,

    /// <include file='StringDigitSubstitute.xml' path='doc/member[@name="StringDigitSubstitute.StringDigitSubstituteTraditional"]/*' />
    StringDigitSubstituteTraditional = 3,
}
