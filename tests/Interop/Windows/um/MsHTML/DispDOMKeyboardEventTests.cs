// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DispDOMKeyboardEvent" /> struct.</summary>
    public static unsafe partial class DispDOMKeyboardEventTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispDOMKeyboardEvent" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DispDOMKeyboardEvent).GUID, Is.EqualTo(IID_DispDOMKeyboardEvent));
        }

        /// <summary>Validates that the <see cref="DispDOMKeyboardEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DispDOMKeyboardEvent>(), Is.EqualTo(sizeof(DispDOMKeyboardEvent)));
        }

        /// <summary>Validates that the <see cref="DispDOMKeyboardEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DispDOMKeyboardEvent).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DispDOMKeyboardEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DispDOMKeyboardEvent), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(DispDOMKeyboardEvent), Is.EqualTo(4));
            }
        }
    }
}
