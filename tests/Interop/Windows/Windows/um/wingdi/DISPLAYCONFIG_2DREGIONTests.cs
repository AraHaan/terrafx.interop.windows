// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DISPLAYCONFIG_2DREGION" /> struct.</summary>
public static unsafe partial class DISPLAYCONFIG_2DREGIONTests
{
    /// <summary>Validates that the <see cref="DISPLAYCONFIG_2DREGION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISPLAYCONFIG_2DREGION>(), Is.EqualTo(sizeof(DISPLAYCONFIG_2DREGION)));
    }

    /// <summary>Validates that the <see cref="DISPLAYCONFIG_2DREGION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISPLAYCONFIG_2DREGION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DISPLAYCONFIG_2DREGION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPLAYCONFIG_2DREGION), Is.EqualTo(8));
    }
}
