// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DispSVGTSpanElement" /> struct.</summary>
    public static unsafe partial class DispSVGTSpanElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispSVGTSpanElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DispSVGTSpanElement).GUID, Is.EqualTo(IID_DispSVGTSpanElement));
        }

        /// <summary>Validates that the <see cref="DispSVGTSpanElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DispSVGTSpanElement>(), Is.EqualTo(sizeof(DispSVGTSpanElement)));
        }

        /// <summary>Validates that the <see cref="DispSVGTSpanElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DispSVGTSpanElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DispSVGTSpanElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DispSVGTSpanElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(DispSVGTSpanElement), Is.EqualTo(4));
            }
        }
    }
}
