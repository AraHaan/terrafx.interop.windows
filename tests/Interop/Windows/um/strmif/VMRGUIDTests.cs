// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VMRGUID" /> struct.</summary>
    public static unsafe class VMRGUIDTests
    {
        /// <summary>Validates that the <see cref="VMRGUID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VMRGUID>(), Is.EqualTo(sizeof(VMRGUID)));
        }

        /// <summary>Validates that the <see cref="VMRGUID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VMRGUID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VMRGUID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VMRGUID), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VMRGUID), Is.EqualTo(20));
            }
        }
    }
}