// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IShellRunDll" /> struct.</summary>
public static unsafe partial class IShellRunDllTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IShellRunDll" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellRunDll).GUID, Is.EqualTo(IID_IShellRunDll));
    }

    /// <summary>Validates that the <see cref="IShellRunDll" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellRunDll>(), Is.EqualTo(sizeof(IShellRunDll)));
    }

    /// <summary>Validates that the <see cref="IShellRunDll" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellRunDll).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IShellRunDll" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellRunDll), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellRunDll), Is.EqualTo(4));
        }
    }
}
