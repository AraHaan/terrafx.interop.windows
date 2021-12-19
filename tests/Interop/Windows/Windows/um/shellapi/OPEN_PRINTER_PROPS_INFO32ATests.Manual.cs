// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="OPEN_PRINTER_PROPS_INFO32A" /> struct.</summary>
public static unsafe partial class OPEN_PRINTER_PROPS_INFO32ATests
{
    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OPEN_PRINTER_PROPS_INFO32A>(), Is.EqualTo(sizeof(OPEN_PRINTER_PROPS_INFO32A)));
    }

    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OPEN_PRINTER_PROPS_INFO32A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="OPEN_PRINTER_PROPS_INFO32A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OPEN_PRINTER_PROPS_INFO32A), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(OPEN_PRINTER_PROPS_INFO32A), Is.EqualTo(20));
        }
    }
}
