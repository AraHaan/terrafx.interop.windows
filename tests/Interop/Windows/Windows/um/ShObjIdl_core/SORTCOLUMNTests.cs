// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SORTCOLUMN" /> struct.</summary>
public static unsafe partial class SORTCOLUMNTests
{
    /// <summary>Validates that the <see cref="SORTCOLUMN" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SORTCOLUMN>(), Is.EqualTo(sizeof(SORTCOLUMN)));
    }

    /// <summary>Validates that the <see cref="SORTCOLUMN" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SORTCOLUMN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SORTCOLUMN" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SORTCOLUMN), Is.EqualTo(24));
    }
}
