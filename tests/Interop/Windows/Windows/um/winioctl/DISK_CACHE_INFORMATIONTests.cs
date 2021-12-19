// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DISK_CACHE_INFORMATION" /> struct.</summary>
public static unsafe partial class DISK_CACHE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="DISK_CACHE_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISK_CACHE_INFORMATION>(), Is.EqualTo(sizeof(DISK_CACHE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="DISK_CACHE_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISK_CACHE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DISK_CACHE_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISK_CACHE_INFORMATION), Is.EqualTo(24));
    }
}
