// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FSCTL_OFFLOAD_READ_INPUT" /> struct.</summary>
public static unsafe partial class FSCTL_OFFLOAD_READ_INPUTTests
{
    /// <summary>Validates that the <see cref="FSCTL_OFFLOAD_READ_INPUT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FSCTL_OFFLOAD_READ_INPUT>(), Is.EqualTo(sizeof(FSCTL_OFFLOAD_READ_INPUT)));
    }

    /// <summary>Validates that the <see cref="FSCTL_OFFLOAD_READ_INPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FSCTL_OFFLOAD_READ_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FSCTL_OFFLOAD_READ_INPUT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FSCTL_OFFLOAD_READ_INPUT), Is.EqualTo(32));
    }
}
