// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxFilesEnumerator" /> struct.</summary>
    [SupportedOSPlatform("windows8.0")]
    public static unsafe partial class IAppxFilesEnumeratorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxFilesEnumerator" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxFilesEnumerator).GUID, Is.EqualTo(IID_IAppxFilesEnumerator));
        }

        /// <summary>Validates that the <see cref="IAppxFilesEnumerator" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxFilesEnumerator>(), Is.EqualTo(sizeof(IAppxFilesEnumerator)));
        }

        /// <summary>Validates that the <see cref="IAppxFilesEnumerator" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxFilesEnumerator).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxFilesEnumerator" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxFilesEnumerator), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxFilesEnumerator), Is.EqualTo(4));
            }
        }
    }
}