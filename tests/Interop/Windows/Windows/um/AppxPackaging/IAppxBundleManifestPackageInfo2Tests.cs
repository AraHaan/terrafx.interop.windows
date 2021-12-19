// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAppxBundleManifestPackageInfo2" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IAppxBundleManifestPackageInfo2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxBundleManifestPackageInfo2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxBundleManifestPackageInfo2).GUID, Is.EqualTo(IID_IAppxBundleManifestPackageInfo2));
    }

    /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxBundleManifestPackageInfo2>(), Is.EqualTo(sizeof(IAppxBundleManifestPackageInfo2)));
    }

    /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxBundleManifestPackageInfo2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxBundleManifestPackageInfo2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxBundleManifestPackageInfo2), Is.EqualTo(4));
        }
    }
}
