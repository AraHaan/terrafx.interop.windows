// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DROPDESCRIPTION" /> struct.</summary>
    public static unsafe partial class DROPDESCRIPTIONTests
    {
        /// <summary>Validates that the <see cref="DROPDESCRIPTION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DROPDESCRIPTION>(), Is.EqualTo(sizeof(DROPDESCRIPTION)));
        }

        /// <summary>Validates that the <see cref="DROPDESCRIPTION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DROPDESCRIPTION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DROPDESCRIPTION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DROPDESCRIPTION), Is.EqualTo(1044));
        }
    }
}
