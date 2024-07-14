// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_GESTURE_CONFIGURATION
{
    /// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION.DIRECTMANIPULATION_GESTURE_NONE"]/*' />
    DIRECTMANIPULATION_GESTURE_NONE = 0,

    /// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION.DIRECTMANIPULATION_GESTURE_DEFAULT"]/*' />
    DIRECTMANIPULATION_GESTURE_DEFAULT = 0,

    /// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION.DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_VERTICAL"]/*' />
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_VERTICAL = 0x8,

    /// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION.DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_HORIZONTAL"]/*' />
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_HORIZONTAL = 0x10,

    /// <include file='DIRECTMANIPULATION_GESTURE_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_GESTURE_CONFIGURATION.DIRECTMANIPULATION_GESTURE_PINCH_ZOOM"]/*' />
    DIRECTMANIPULATION_GESTURE_PINCH_ZOOM = 0x20,
}
