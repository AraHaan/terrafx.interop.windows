// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DISCDLGSTRUCTA" /> struct.</summary>
public static unsafe partial class DISCDLGSTRUCTATests
{
    /// <summary>Validates that the <see cref="DISCDLGSTRUCTA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISCDLGSTRUCTA>(), Is.EqualTo(sizeof(DISCDLGSTRUCTA)));
    }

    /// <summary>Validates that the <see cref="DISCDLGSTRUCTA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISCDLGSTRUCTA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DISCDLGSTRUCTA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DISCDLGSTRUCTA), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DISCDLGSTRUCTA), Is.EqualTo(20));
        }
    }
}
