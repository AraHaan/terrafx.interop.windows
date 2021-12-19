// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDWriteFontSet3" /> struct.</summary>
public static unsafe partial class IDWriteFontSet3Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFontSet3" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontSet3).GUID, Is.EqualTo(IID_IDWriteFontSet3));
    }

    /// <summary>Validates that the <see cref="IDWriteFontSet3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontSet3>(), Is.EqualTo(sizeof(IDWriteFontSet3)));
    }

    /// <summary>Validates that the <see cref="IDWriteFontSet3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontSet3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDWriteFontSet3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontSet3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontSet3), Is.EqualTo(4));
        }
    }
}
