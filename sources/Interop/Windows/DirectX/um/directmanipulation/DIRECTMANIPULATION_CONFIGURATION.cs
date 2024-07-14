// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_CONFIGURATION
{
    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_NONE"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_NONE = 0,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_INTERACTION"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_INTERACTION = 0x1,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_X"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_X = 0x2,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_Y"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_Y = 0x4,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_SCALING"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_SCALING = 0x10,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_INERTIA"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_INERTIA = 0x20,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_SCALING_INERTIA"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_SCALING_INERTIA = 0x80,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_RAILS_X"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_RAILS_X = 0x100,

    /// <include file='DIRECTMANIPULATION_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_CONFIGURATION.DIRECTMANIPULATION_CONFIGURATION_RAILS_Y"]/*' />
    DIRECTMANIPULATION_CONFIGURATION_RAILS_Y = 0x200,
}
