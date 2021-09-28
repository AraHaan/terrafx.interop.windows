// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_tagSlowAppInfo" /> struct.</summary>
    public static unsafe class _tagSlowAppInfoTests
    {
        /// <summary>Validates that the <see cref="_tagSlowAppInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_tagSlowAppInfo>(), Is.EqualTo(sizeof(_tagSlowAppInfo)));
        }

        /// <summary>Validates that the <see cref="_tagSlowAppInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_tagSlowAppInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_tagSlowAppInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(_tagSlowAppInfo), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(_tagSlowAppInfo), Is.EqualTo(24));
            }
        }
    }
}