// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ACTRL_PROPERTY_ENTRYA" /> struct.</summary>
public static unsafe partial class ACTRL_PROPERTY_ENTRYATests
{
    /// <summary>Validates that the <see cref="ACTRL_PROPERTY_ENTRYA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTRL_PROPERTY_ENTRYA>(), Is.EqualTo(sizeof(ACTRL_PROPERTY_ENTRYA)));
    }

    /// <summary>Validates that the <see cref="ACTRL_PROPERTY_ENTRYA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTRL_PROPERTY_ENTRYA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ACTRL_PROPERTY_ENTRYA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTRL_PROPERTY_ENTRYA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(ACTRL_PROPERTY_ENTRYA), Is.EqualTo(12));
        }
    }
}
