// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SYSTEM_PROCESS_INFORMATION" /> struct.</summary>
public static unsafe partial class SYSTEM_PROCESS_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="SYSTEM_PROCESS_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SYSTEM_PROCESS_INFORMATION>(), Is.EqualTo(sizeof(SYSTEM_PROCESS_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="SYSTEM_PROCESS_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SYSTEM_PROCESS_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SYSTEM_PROCESS_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SYSTEM_PROCESS_INFORMATION), Is.EqualTo(256));
        }
        else
        {
            Assert.That(sizeof(SYSTEM_PROCESS_INFORMATION), Is.EqualTo(184));
        }
    }
}
