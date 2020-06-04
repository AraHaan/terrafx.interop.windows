// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AUDIOFILE_AF36WAVEFORMAT" /> struct.</summary>
    public static unsafe class AUDIOFILE_AF36WAVEFORMATTests
    {
        /// <summary>Validates that the <see cref="AUDIOFILE_AF36WAVEFORMAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AUDIOFILE_AF36WAVEFORMAT>(), Is.EqualTo(sizeof(AUDIOFILE_AF36WAVEFORMAT)));
        }

        /// <summary>Validates that the <see cref="AUDIOFILE_AF36WAVEFORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AUDIOFILE_AF36WAVEFORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AUDIOFILE_AF36WAVEFORMAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AUDIOFILE_AF36WAVEFORMAT), Is.EqualTo(18));
        }
    }
}