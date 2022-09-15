// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMAGE_FUNCTION_OVERRIDE_HEADER" /> struct.</summary>
public static unsafe partial class IMAGE_FUNCTION_OVERRIDE_HEADERTests
{
    /// <summary>Validates that the <see cref="IMAGE_FUNCTION_OVERRIDE_HEADER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_FUNCTION_OVERRIDE_HEADER>(), Is.EqualTo(sizeof(IMAGE_FUNCTION_OVERRIDE_HEADER)));
    }

    /// <summary>Validates that the <see cref="IMAGE_FUNCTION_OVERRIDE_HEADER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_FUNCTION_OVERRIDE_HEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMAGE_FUNCTION_OVERRIDE_HEADER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_FUNCTION_OVERRIDE_HEADER), Is.EqualTo(4));
    }
}