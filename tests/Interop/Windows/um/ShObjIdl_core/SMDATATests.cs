// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SMDATA" /> struct.</summary>
    public static unsafe class SMDATATests
    {
        /// <summary>Validates that the <see cref="SMDATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SMDATA>(), Is.EqualTo(sizeof(SMDATA)));
        }

        /// <summary>Validates that the <see cref="SMDATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SMDATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SMDATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SMDATA), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(SMDATA), Is.EqualTo(48));
            }
        }
    }
}