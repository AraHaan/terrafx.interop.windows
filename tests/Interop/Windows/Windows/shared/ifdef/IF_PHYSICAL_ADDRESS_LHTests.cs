// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IF_PHYSICAL_ADDRESS_LH" /> struct.</summary>
public static unsafe partial class IF_PHYSICAL_ADDRESS_LHTests
{
    /// <summary>Validates that the <see cref="IF_PHYSICAL_ADDRESS_LH" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IF_PHYSICAL_ADDRESS_LH>(), Is.EqualTo(sizeof(IF_PHYSICAL_ADDRESS_LH)));
    }

    /// <summary>Validates that the <see cref="IF_PHYSICAL_ADDRESS_LH" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IF_PHYSICAL_ADDRESS_LH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IF_PHYSICAL_ADDRESS_LH" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IF_PHYSICAL_ADDRESS_LH), Is.EqualTo(34));
    }
}
