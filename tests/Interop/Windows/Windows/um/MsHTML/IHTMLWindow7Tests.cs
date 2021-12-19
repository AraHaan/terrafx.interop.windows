// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IHTMLWindow7" /> struct.</summary>
public static unsafe partial class IHTMLWindow7Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLWindow7" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLWindow7).GUID, Is.EqualTo(IID_IHTMLWindow7));
    }

    /// <summary>Validates that the <see cref="IHTMLWindow7" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLWindow7>(), Is.EqualTo(sizeof(IHTMLWindow7)));
    }

    /// <summary>Validates that the <see cref="IHTMLWindow7" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLWindow7).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IHTMLWindow7" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLWindow7), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLWindow7), Is.EqualTo(4));
        }
    }
}
