// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SHFILEOPSTRUCT32W" /> struct.</summary>
public static unsafe partial class SHFILEOPSTRUCT32WTests
{
    /// <summary>Validates that the <see cref="SHFILEOPSTRUCT32W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHFILEOPSTRUCT32W>(), Is.EqualTo(sizeof(SHFILEOPSTRUCT32W)));
    }

    /// <summary>Validates that the <see cref="SHFILEOPSTRUCT32W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHFILEOPSTRUCT32W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SHFILEOPSTRUCT32W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SHFILEOPSTRUCT32W), Is.EqualTo(50));
        }
        else
        {
            Assert.That(sizeof(SHFILEOPSTRUCT32W), Is.EqualTo(30));
        }
    }
}
