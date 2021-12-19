// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timeapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TIMECAPS" /> struct.</summary>
public static unsafe partial class TIMECAPSTests
{
    /// <summary>Validates that the <see cref="TIMECAPS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TIMECAPS>(), Is.EqualTo(sizeof(TIMECAPS)));
    }

    /// <summary>Validates that the <see cref="TIMECAPS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TIMECAPS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TIMECAPS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TIMECAPS), Is.EqualTo(8));
    }
}
