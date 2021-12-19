// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CRL_DIST_POINT_NAME" /> struct.</summary>
public static unsafe partial class CRL_DIST_POINT_NAMETests
{
    /// <summary>Validates that the <see cref="CRL_DIST_POINT_NAME" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRL_DIST_POINT_NAME>(), Is.EqualTo(sizeof(CRL_DIST_POINT_NAME)));
    }

    /// <summary>Validates that the <see cref="CRL_DIST_POINT_NAME" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRL_DIST_POINT_NAME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CRL_DIST_POINT_NAME" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRL_DIST_POINT_NAME), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CRL_DIST_POINT_NAME), Is.EqualTo(12));
        }
    }
}
