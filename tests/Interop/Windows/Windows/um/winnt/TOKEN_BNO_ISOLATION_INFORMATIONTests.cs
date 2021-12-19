// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TOKEN_BNO_ISOLATION_INFORMATION" /> struct.</summary>
public static unsafe partial class TOKEN_BNO_ISOLATION_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="TOKEN_BNO_ISOLATION_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_BNO_ISOLATION_INFORMATION>(), Is.EqualTo(sizeof(TOKEN_BNO_ISOLATION_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="TOKEN_BNO_ISOLATION_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_BNO_ISOLATION_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TOKEN_BNO_ISOLATION_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOKEN_BNO_ISOLATION_INFORMATION), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(TOKEN_BNO_ISOLATION_INFORMATION), Is.EqualTo(8));
        }
    }
}
