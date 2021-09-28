// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IQueryCodePage" /> struct.</summary>
    public static unsafe class IQueryCodePageTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IQueryCodePage" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IQueryCodePage).GUID, Is.EqualTo(IID_IQueryCodePage));
        }

        /// <summary>Validates that the <see cref="IQueryCodePage" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IQueryCodePage>(), Is.EqualTo(sizeof(IQueryCodePage)));
        }

        /// <summary>Validates that the <see cref="IQueryCodePage" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IQueryCodePage).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IQueryCodePage" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IQueryCodePage), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IQueryCodePage), Is.EqualTo(4));
            }
        }
    }
}