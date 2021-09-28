// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="INameSpaceTreeControlDropHandler" /> struct.</summary>
    public static unsafe class INameSpaceTreeControlDropHandlerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="INameSpaceTreeControlDropHandler" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(INameSpaceTreeControlDropHandler).GUID, Is.EqualTo(IID_INameSpaceTreeControlDropHandler));
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeControlDropHandler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<INameSpaceTreeControlDropHandler>(), Is.EqualTo(sizeof(INameSpaceTreeControlDropHandler)));
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeControlDropHandler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(INameSpaceTreeControlDropHandler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeControlDropHandler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(INameSpaceTreeControlDropHandler), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(INameSpaceTreeControlDropHandler), Is.EqualTo(4));
            }
        }
    }
}