// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDefaultExtractIconInit" /> struct.</summary>
    public static unsafe class IDefaultExtractIconInitTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDefaultExtractIconInit" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDefaultExtractIconInit).GUID, Is.EqualTo(IID_IDefaultExtractIconInit));
        }

        /// <summary>Validates that the <see cref="IDefaultExtractIconInit" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDefaultExtractIconInit>(), Is.EqualTo(sizeof(IDefaultExtractIconInit)));
        }

        /// <summary>Validates that the <see cref="IDefaultExtractIconInit" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDefaultExtractIconInit).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDefaultExtractIconInit" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDefaultExtractIconInit), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDefaultExtractIconInit), Is.EqualTo(4));
            }
        }
    }
}